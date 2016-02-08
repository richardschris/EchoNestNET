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

        [JsonObject]
        public class audioSummary
        {
            [JsonProperty(PropertyName = "analysis_url")]
            public string analysisUrl { get; set; }
            [JsonProperty(PropertyName = "danceability")]
            public float danceability { get; set; }
            [JsonProperty(PropertyName = "duration")]
            public float duration { get; set; }
            [JsonProperty(PropertyName = "energy")]
            public float energy { get; set; }
            [JsonProperty(PropertyName = "key")]
            public int key { get; set; }
            [JsonProperty(PropertyName = "loudness")]
            public float loudness { get; set; }
            [JsonProperty(PropertyName = "mode")]
            public int mode { get; set; }
            [JsonProperty(PropertyName = "speechiness")]
            public float speechiness { get; set; }
            [JsonProperty(PropertyName = "acousticness")]
            public float acousticness { get; set; }
            [JsonProperty(PropertyName = "liveness")]
            public float liveness { get; set; }
            [JsonProperty(PropertyName = "tempo")]
            public float tempo { get; set; }
            [JsonProperty(PropertyName = "time_signature")]
            public int timeSignature { get; set; }
        }
    }
}

