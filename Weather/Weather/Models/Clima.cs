using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Weather.Models
{
    public class Clima
    {
        [JsonProperty("temp")]
        public string Temperatura { get; set; }

        [JsonProperty("temp_min")]
        public string TemperaturaMinina { get; set; }

        [JsonProperty("temp_max")]
        public string TemperaturaMaxima { get; set; }

        [JsonProperty("humidity")]
        public string Humidade { get; set; }
               
        //[JsonProperty("sys")]
        //public SysInfo SysInfo { get; set; }

        //[JsonProperty("wind")]
        //public VentoInfo VentoInfo { get; set; }
    }

    //public class SysInfo
    //{
    //    [JsonProperty("sunrise")]
    //    public long NascerDoSol { get; set; }

    //    [JsonProperty("sunset")]
    //    public long PorDoSol { get; set; }
    //}

    //public class VentoInfo
    //{
    //    [JsonProperty("speed")]
    //    public double Velocidade { get; set; }

    //    // Inclua outras propriedades do vento, se necessário
    //}
}
