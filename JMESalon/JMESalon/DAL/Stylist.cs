using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace JMESalon.DAL
{
    public class Stylist
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string associatedImg { get; set; }
        [Required]
        [MaxLength(200)]
        public string Bio { get; set; }

        public static Stylist[] Stylists =
        {
            new DAL.Stylist()
            {
                Id = 1,
                FirstName = "Eva",
                LastName = "Lam",
                Phone = "703-123-4567",
                Email = "eva.lam@jmesalon.com",
                Title = "Director",
                associatedImg = "../images/eva.jpg",
                Bio = "I am the owner of JME Salon."
            },

            new DAL.Stylist()
            {
                Id = 2,
                FirstName = "Jade",
                LastName = "Ly",
                Phone = "703-987-6543",
                Email = "jade.ly@jmesalon.com",
                Title = "Stylist",
                associatedImg = "../images/jade.jpg",
                Bio = "I am a junior stylist at JME Salon."
            },
            new DAL.Stylist()
            {
                Id = 3,
                FirstName = "Lorean",
                LastName = "Lee",
                Phone = "703-112-2334",
                Email = "lo.rean@jmesalon.com",
                Title = "Stylist",
                associatedImg = "../images/lorean.jpg",
                Bio = "I am the lead stylist at JME Salon."
            }
        };
    }
}