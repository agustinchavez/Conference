using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class ConferenceContextInitializer : DropCreateDatabaseAlways<ConferenceContext>
    {
        public override void Seed(ConferenceContext context)
        {
            context.Sessions.Add(
                new Session()
                {
                    Title = "I want tacos",
                    Abstract = "The life and times of a taco lover",
                    Speaker = context.Speakers.Add(
                    new Speaker()
                    {
                        Name = "Agustin",
                        EmailAddress = "agustin@agustin.com"
                    })
                });
        }
    }
}
