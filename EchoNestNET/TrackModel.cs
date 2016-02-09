using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EchoNestNET
{
    [JsonObject]
    public class TrackModel
    {
        // TODO: reorder into alphabetical order
        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }
        [JsonProperty(PropertyName = "foreign_release_ids")]
        public List<String> foreignReleaseIds { get; set; }
        [JsonProperty(PropertyName = "catalog")]
        public string catalog { get; set; }
        [JsonProperty(PropertyName = "audio_md5")]
        public string audioMd5 { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
        [JsonProperty(PropertyName = "song_id")]
        public string songId { get; set; }
        [JsonProperty(PropertyName = "release_image")]
        public string releaseImage { get; set; }
        [JsonProperty(PropertyName = "artist")]
        public string artist { get; set; }
        [JsonProperty(PropertyName = "foreign_ids")]
        public List<String> foreignIds { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }
        [JsonProperty(PropertyName = "preview_url")]
        public string previewUrl { get; set; }
        [JsonProperty(PropertyName = "foreign_release_id")]
        public string foreignReleaseId { get; set; }
        [JsonProperty(PropertyName = "release")]
        public string release { get; set; }
        [JsonProperty(PropertyName = "foreign_id")]
        public string foreignId { get; set; }

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
