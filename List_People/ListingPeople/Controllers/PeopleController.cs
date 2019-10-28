using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ListingPeople.Models;

namespace ListingPeople.Controllers
{
    public class PeopleController : ApiController
    {
        List<People> peoplesList = new List<People>()
        {
            new People(){Name="Anuxki",Age=90},
            new People(){Name="Nuki",Age=80},
            new People(){Name="Nuska",Age=70},
            new People(){Name="Anuzka",Age=60},
            new People(){Name="Anucha",Age=50},
            new People(){Name="Lavanda",Age=40},
            new People(){Name="Nuski",Age=30},

        };
        public List<People> Get()
        {
            return peoplesList;
        }

        //public string Get(People peopleObject)
        //{
        //    People people = peopleObject;
        //    people.Name = people.Name;
        //    people.Age=
        //}

    }
}
