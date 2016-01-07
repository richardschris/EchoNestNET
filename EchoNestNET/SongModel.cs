using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EchoNestNET
{
    // song class
    [JsonObject]
    public class Song
    {
        // artist data is represented differently than in an artist object, be aware!
        [JsonProperty(PropertyName = "artist_name")]
        public string artistName { get; set; }
        [JsonProperty(PropertyName = "artist_id")]
        public string artistId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string songId { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string songName { get; set; }

        [JsonProperty(PropertyName = "audio_summary")]
        public string audioSummary { get; set; }
        [JsonProperty(PropertyName = "artist_discovery")]
        public float artistDiscovery { get; set; }
        [JsonProperty(PropertyName = "artist_discovery_rank")]
        public float artistDiscoveryRank { get; set; }
        [JsonProperty(PropertyName = "artist_familiarity")]
        public float artistFamiliarity { get; set; }
        [JsonProperty(PropertyName = "artist_familiarity_rank")]
        public float artistFamiliarityRank { get; set; }
        [JsonProperty(PropertyName = "artist_location")]
        public string artistLocation { get; set; }
        [JsonProperty(PropertyName = "song_currency")]
        public float songCurrency { get; set; }
        [JsonProperty(PropertyName = "song_currency_rank")]
        public float songCurrencyRank { get; set; }
        [JsonProperty(PropertyName = "song_discovery")]
        public float songDiscovery { get; set; }
        [JsonProperty(PropertyName = "song_discovery_rank")]
        public float songDiscoveryRank { get; set; }
        [JsonProperty(PropertyName = "song_hotttnesss")]
        public float songHotttnesss { get; set; }
        [JsonProperty(PropertyName = "song_hotttnesss_rank")]
        public float songHotttnesssRank { get; set; }
        [JsonProperty(PropertyName = "song_type")]
        public string songType { get; set; }
        [JsonProperty(PropertyName = "tracks")]
        public string tracks { get; set; }

        public Song()
        {

        }
    }
}

