﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Models
{
    public static class Initializer
    {
        public static void InitializeContext(ProfileContext context)
        {
            context.Database.EnsureCreated();
           
            if (context.Individuals.Any())
            {
                return;   
            }

            // Individuals
            var individual = new Individual
            {
                FullName = "Carson",
                DateOfBirth = DateTime.Now,
                Address = "4437 Texas Street",
                AspNetUserId = "cba7ab46-219b-45d3-995b-28392b908683",
                State = "TX",
                City = "Allen",
                ZipCode = "75254"
            };

            context.Individuals.Add(individual);
            context.SaveChanges();

            // Organizations
            var organization = new Organization
            {
                BusinessName = "IT Group",
                HireDate = DateTime.Now,
                Address = "205 Joiner Street",
                AspNetUserId = "cba7ab46-219b-45d3-995b-28392b908683",
                State = "TX",
                Profession = "Developer",
                City = "Allen",
                ZipCode = "75254"
            };
            context.Organizations.Add(organization);
            context.SaveChanges();
            
            // Hobbies
            var hobby = new Hobbies
            {
                HobbieId = Guid.NewGuid(),
                Name = "Exercise",
                Rating = 5,
                AspNetUserId = "cba7ab46-219b-45d3-995b-28392b908683",
            };
            context.Hobby.Add(hobby);
            context.SaveChanges();

         
           
        }
    }
}