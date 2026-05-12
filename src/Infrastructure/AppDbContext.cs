using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class MockDbContext
    {
        public List<User> Users { get; set; } = new List<User>()
        {
            new User()
            {
                Id = 1,
                Name = "TestUser1",
                Email = "user1@example.com",
                Password = "admin1234",
                Role = Roles.Admin
            },
            new User()
            {
                Id = 2,
                Name = "TestUser2",
                Email = "user2@example.com",
                Password = "user1234",
                Role = Roles.Client
            }
        };
    }
}
