using System;
using System.Collections.Generic;
using MyApp.Api.Identity;

namespace MyApp.Api.Models
{
    public class Palestrante
    {
        public int Id { get; set; }
        public string MiniCurriculo { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }
    }
}