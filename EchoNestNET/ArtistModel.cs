using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EchoNestNET
{
   
    // artist class
    [JsonObject]
    public class Artist
    {
        // basic fields   
        [JsonProperty(PropertyName = "id")]
        public string artistId { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string artistName { get; set; }
        [JsonProperty(PropertyName = "familiarity")]
        public float artistFamiliarity { get; set; }
        [JsonProperty(PropertyName = "hotttnesss")]
        public float hotttnesss { get; set; }
        [JsonProperty(PropertyName = "twitter")]
        public string twitter { get; set; }

        // bucket lists
        [JsonProperty(PropertyName = "biographies")]
        public IList<Biography> artistBiographies { get; set; }
        [JsonProperty(PropertyName = "blogs")]
        public IList<Blog> artistBlogs { get; set; }
        [JsonProperty(PropertyName = "songs")]
        public IList<Song> artistSongs { get; set; }
        [JsonProperty(PropertyName = "news")]
        public IList<News> artistNews { get; set; }

        public Artist()
        {
            
        }
    }
    
    [JsonObject]
    public class Biography
    {
        [JsonProperty(PropertyName = "text")]
        public string biographyText { get; set; }
        [JsonProperty(PropertyName = "site")]
        public string siteName { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string siteUrl { get; set; }

        [JsonObject]
        class License
        {
            [JsonProperty(PropertyName = "type")]
            string licenseType { get; set; }
            [JsonProperty(PropertyName = "attribution")]
            string attribution { get; set; }
            [JsonProperty(PropertyName = "attribution-url")]
            string attributionUrl { get; set; }
            [JsonProperty(PropertyName = "url")]
            string licenseUrl { get; set; }
            [JsonProperty(PropertyName = "version")]
            string licenseVersion { get; set; }
        }
    }

    [JsonObject]
    public class Blog
    {
        [JsonProperty(PropertyName = "name")]
        public string blogName { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string blogUrl { get; set; }
        [JsonProperty(PropertyName = "summary")]
        public string blogSummary { get; set; }
        [JsonProperty(PropertyName = "date_found")]
        public DateTime dateFound { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string blogId { get; set; }
        [JsonProperty(PropertyName = "date_posted")]
        public DateTime datePosted { get; set; }
    }

    [JsonObject]
    public class Image
    {
        [JsonProperty(PropertyName = "url")]
        public string imageUrl { get; set; }
        [JsonProperty(PropertyName = "tags")]
        public string[] tags { get; set; }
        [JsonProperty(PropertyName = "width")]
        public int width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int height { get; set; }
        [JsonProperty(PropertyName = "aspect_ratio")]
        public float aspectRatio { get; set; }
        [JsonProperty(PropertyName = "verified")]
        public bool verified { get; set; }

        [JsonObject]
        class License
        {
            [JsonProperty(PropertyName = "type")]
            string licenseType { get; set; }
            [JsonProperty(PropertyName = "attribution")]
            string attribution { get; set; }
            [JsonProperty(PropertyName = "attribution-url")]
            string attributionUrl { get; set; }
            [JsonProperty(PropertyName = "url")]
            string licenseUrl { get; set; }
            [JsonProperty(PropertyName = "version")]
            string licenseVersion { get; set; }
        }
    }

    [JsonObject]
    public class ListTerms
    {
        // this implementation is adequate, but it does not reflect the Echo Nest object model.
        // The returned JSON differs from other kinds of returns, and is otherwise a mess.
        [JsonProperty(PropertyName = "type")]
        public string type { get; set; }
        [JsonProperty(PropertyName = "terms")]
        public IList<string> terms = new List<string>();
    }

    [JsonObject]
    public class News
    {
        [JsonProperty(PropertyName = "name")]
        public string newsName { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string newsUrl { get; set; }
        [JsonProperty(PropertyName = "date_posted")]
        public DateTime datePosted { get; set; }
        [JsonProperty(PropertyName = "date_found")]
        public DateTime dateFound { get; set; }
        [JsonProperty(PropertyName = "summary")]
        public string newsSummary { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string newsId { get; set; }
    }

    [JsonObject]
    public class Review
    {
        [JsonProperty(PropertyName = "name")]
        public string reviewName { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string reviewUrl { get; set; }
        [JsonProperty(PropertyName = "summary")]
        public string reviewSummary { get; set; }
        [JsonProperty(PropertyName = "date_reviewed")]
        public DateTime reviewDate { get; set; }
        [JsonProperty(PropertyName = "date_found")]
        public DateTime reviewFound { get; set; }
        [JsonProperty(PropertyName = "image_url")]
        public string reviewImage { get; set; }
        [JsonProperty(PropertyName = "release")]
        public string reviewRelease { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string reviewId { get; set; }
    }

    [JsonObject]
    public class Term
    {
        [JsonProperty(PropertyName = "name")]
        public string termName { get; set; }
        [JsonProperty(PropertyName = "frequency")]
        public double termFrequency { get; set; }
        [JsonProperty(PropertyName = "weight")]
        public double termWeight { get; set; }
    }

    [JsonObject]
    public class Urls
    {
        [JsonProperty(PropertyName = "official_url")]
        public string officialUrl { get; set; }
        [JsonProperty(PropertyName = "lastfm_url")]
        public string lastfmUrl { get; set; }
        [JsonProperty(PropertyName = "twitter_url")]
        public string twitterUrl { get; set; }
        [JsonProperty(PropertyName = "wikipedia_url")]
        public string wikipediaUrl { get; set; }
        [JsonProperty(PropertyName = "myspace_url")]
        public string myspaceUrl { get; set; }
        [JsonProperty(PropertyName = "mb_url")]
        public string musicbrainzUrl { get; set; }
    }

    [JsonObject]
    public class Video
    {
        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string url { get; set; }
        [JsonProperty(PropertyName = "site")]
        public string site { get; set; }
        [JsonProperty(PropertyName = "date_found")]
        public DateTime dateFound { get; set; }
        [JsonProperty(PropertyName = "image_url")]
        public string imageUrl { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
    }
}


