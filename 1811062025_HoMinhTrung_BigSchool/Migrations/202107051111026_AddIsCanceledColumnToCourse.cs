namespace _1811062025_HoMinhTrung_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    public partial class AddIsCanceledColumnToCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
        }
        public override void Down()
        {
            DropColumn("dbo.Courses", "IsCanceled");
        }
    }
}
