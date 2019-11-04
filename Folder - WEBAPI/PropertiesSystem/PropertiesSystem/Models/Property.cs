using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PropertiesSystem.Models
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public string PostalCode { get; set; }
        public string AdressStreet { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string Complement { get; set; }
        public int Number { get; set; }
        public int OwnerId { get; set; }
    }
}