using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.Linq;
using Weather.API.Controllers;
using Weather.API.Weather.Models;

namespace Weather.API.Weather.Data.Configurations
{
    public class WeatherConfiguration : IEntityTypeConfiguration<Weathers>
    {
        private static readonly string[] Summaries = new[]
            {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
        public void Configure(EntityTypeBuilder<Weathers> builder)
        {
            builder.HasData(
                new Weathers
                {
                    Id = 1,
                    Date = DateTime.Now,
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]

                },
                new Weathers
                {
                    Id = 2,
                    Date = DateTime.Now,
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]

                },
                new Weathers
                {
                    Id = 3,
                    Date = DateTime.Now,
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]

                }
                );

        }
    }
    
}