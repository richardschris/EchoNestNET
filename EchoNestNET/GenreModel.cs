using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EchoNestNET
{
    [JsonObject]
    public class Genre
    {
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string description { get; set; }
        [JsonProperty(PropertyName = "similarity")] 
        public float similarity { get; set; }

        [JsonObject]
        public class Urls
        {
            [JsonProperty(PropertyName = "wikipedia_url")]
            public string wikipediaUrl { get; set; }
        }
    }
}
