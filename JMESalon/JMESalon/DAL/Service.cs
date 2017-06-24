using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace JMESalon.DAL
{
    public class Service
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public double Cost { get; set; }
        [Required]
        public string Hours { get; set; }
        [Required]
        public string associatedImg { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        [MaxLength(200)]
        public string serviceLink { get; set; }

        public static Service[] Services =
        {
            new DAL.Service()
            {
                Id = 1,
                Name = "Hair Cut - Short/Medium",
                Cost = 25.0,
                Hours = "1-2 Hours",
                associatedImg = "../images/short-hair.jpg",
                serviceLink = "/Home/Services#haircuts",
                description = "A dream haircut for clients with short or medium hair length. Includes shampoo and blow dry."
            },

            new DAL.Service()
            {
                Id = 2,
                Name = "Hair Cut - Long",
                Cost = 35.0,
                Hours = "1-2 Hours",
                associatedImg = "../images/long-hair.jpg",
                serviceLink = "/Home/Services#haircuts",
                description = "A dream haircut for clients with long hair length. Includes shampoo and blow dry."
            },
            new DAL.Service()
            {
                Id = 3,
                Name = "Balayage - Short/Medium",
                Cost = 150.0,
                Hours = "2-5 Hours",
                associatedImg = "../images/balayges.jpg",
                serviceLink = "/Home/Services#haircolor",
                description = "A coloring service with beautiful, highlights with a specialized technique for clients with short or medium length hair."
            },
            new DAL.Service()
            {
                Id = 4,
                Name = "Balayage - Long",
                Cost = 225.0,
                Hours = "2-6 Hours",
                associatedImg = "../images/balayage.jpg",
                serviceLink = "/Home/Services#haircolor",
                description = "A coloring service with beautiful, highlights with a specialized technique for clients with long length hair."
            },
            new DAL.Service()
            {
                Id = 5,
                Name = "Makeup - Formal Event",
                Cost = 75.0,
                Hours = "1-3 Hours",
                associatedImg = "../images/makeup-brushes.jpg",
                serviceLink = "/Home/Services#makeup",
                description = "A full-face makeover for all your formal events - weddings, proms, dinners, etc."
            },
        };
    }
}