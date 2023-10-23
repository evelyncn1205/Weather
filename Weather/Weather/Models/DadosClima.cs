using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Models
{
    public class DadosClima
    {
        [JsonProperty("name")]
        public string NomeCidade { get; set; }

        [JsonProperty("main")]
        public Clima Clima { get; set; }
    }
}
