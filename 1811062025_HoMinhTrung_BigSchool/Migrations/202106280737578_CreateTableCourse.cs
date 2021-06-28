namespace _1811062025_HoMinhTrung_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LectureID = c.String(nullable: false),
                        Place = c.String(nullable: false, maxLength: 255),
                        DateTime = c.DateTime(nullable: false),
                        CategoryID = c.Byte(nullable: false),
                        Lecturer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Lecturer_Id)
                .Index(t => t.CategoryID)
                .Index(t => t.Lecturer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Lecturer_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Lecturer_Id" });
            DropIndex("dbo.Courses", new[] { "CategoryID" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
