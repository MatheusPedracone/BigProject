using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Api.Identity
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
    }
}