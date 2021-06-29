using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _1811062025_HoMinhTrung_BigSchool.Models;
using _1811062025_HoMinhTrung_BigSchool.DTOs;
using Microsoft.AspNet.Identity;

namespace _1811062025_HoMinhTrung_BigSchool.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingdto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingdto.FolloweeID))
                return BadRequest("Following already exists");
            var following = new Following
            {
                FollowerId = userId,
                FolloweeId = followingdto.FolloweeID
            };
            _dbContext.Followings.Add(following);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}