using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace EchoNestNET
{
    public class Connect
    {
        static string APIKey;
        public static WebClient echo = new WebClient();
        NameId query = new NameId();

        public Connect(string key)
        {
            APIKey = key;
            echo.BaseAddress = "http://developer.echonest.com/api/v4/";
        }

        // artist/search

        /// <summary>
        /// Basic search for artist or ID
        /// </summary>
        /// <param name="search">String of artist name or artist ID</param>
        /// <returns>returns json string for parsing</returns>
        public string ArtistSearch(string search)
        {
            string artist;

            string urlSuffix = "artist/search?api_key=" + APIKey + query.NameOrArtistId(search);
            artist = echo.DownloadString(urlSuffix);

            return artist;
        }

        /// <summary>
        /// Overload for ArtistSearch; searches for an artist or ID given parameters. Will throw an exception if artist or id parameter is set on Parameters object.
        /// </summary>
        /// <param name="search">String of artist name or ID</param>
        /// <param name="parameters">Parameters object</param>
        /// <returns></returns>
        public string ArtistSearch(string search, Parameters parameters)
        {

            // TODO: Add exception.
            string artist;

            if (search != parameters.artistSearchParameters.name) { parameters.artistSearchParameters.name = null; }
            string urlSuffix = "artist/search?api_key=" + APIKey + query.NameOrArtistId(search) + parameters.ArtistSearchString() + parameters.ArtistBucketString();
            artist = echo.DownloadString(urlSuffix);

            return artist;
        }

        /// <summary>
        /// Safest search.
        /// </summary>
        /// <param name="parameters">Parameters object</param>
        /// <returns></returns>
        public string ArtistSearch(Parameters parameters)
        {
            string artist;

            string urlSuffix = "artist/search?api_key=" + APIKey + parameters.ArtistSearchString() + parameters.ArtistBucketString();
            artist = echo.DownloadString(urlSuffix);
            return artist;
        }

        /// <summary>
        /// artist/biographies call. Returns a list of biographies of the artist in question.
        /// </summary>
        /// <param name="search">a string for the search; can be either an ID or an artist name</param>
        /// <param name="results">the number of results to return (default = 15)</param>
        /// <param name="start">the desired index of the first result returned (default = 0)</param>
        /// <param name="license">license of the returned text (default = null)</param>
        /// <returns>JSON string of biographies</returns>
        public string ArtistBiographies(string search, int results = 15, int start = 0, string license = null)
        {
            string artist;

            string urlSuffix = "artist/biographies?api_key=" + APIKey + "&name=" + search;

            if (results != 15) { urlSuffix += "&results=" + results; }
            if (start != 0) { urlSuffix += "&start=" + start; }
            if (license != null) { urlSuffix += "&license=" + license; }

            artist = echo.DownloadString(urlSuffix);

            return artist;
        }

        /// <summary>
        /// artist/blogs call. Returns a list of blogs with  posts about the artist in question.
        /// </summary>
        /// <param name="search">a string for the search; can be either an ID or an artist name</param>
        /// <param name="results">the number of results to return (default = 15)</param>
        /// <param name="start">the desired index of the first result returned (default = 0)</param>
        /// <param name="highRelevance">if true only items that are highly relevant are returned (default = false)</param>
        /// <returns>JSON string</returns>
        public string ArtistBlogs(string search, int results = 15, int start = 0, bool highRelevance = false)
        {
            string json;
            string urlSuffix = "artist/blogs?api_key=" + APIKey + "&name=" + search;

            if (results != 15) { urlSuffix += "&results=" + results; }
            if (start != 0) { urlSuffix += "&start=" + start; }
            if (highRelevance != false) { urlSuffix += "&high_relevance=" + highRelevance.ToString(); }

            json = echo.DownloadString(urlSuffix);

            return json;
        }

        /// <summary>
        /// Search for artist based on familiarity
        /// </summary>
        /// <param name="search">String of rtist name or ID</param>
        /// <returns>json string for parsing</returns>
        public string ArtistFamiliarity(string search)
        {
            string json;
            string urlSuffix = "artist/familiarity?api_key=" + APIKey + query.NameOrArtistId(search);
            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Hotttnesss search
        /// </summary>
        /// <param name="search">string of artist ame or ID</param>
        /// <param name="type">string of type</param>
        /// <returns></returns>
        public string ArtistHotttnesss(string search, string type = null)
        {
            string json;
            string urlSuffix = "artist/hotttnesss?api_key=" + APIKey + query.NameOrArtistId(search);

            switch (type) //should this be a string?
            {
                case "overall":
                    urlSuffix += "&type=overall";
                    break;
                case "social":
                    urlSuffix += "&type=social";
                    break;
                case "reviews":
                    urlSuffix += "&type=reviews";
                    break;
                case "mainstream":
                    urlSuffix += "&type=mainstream";
                    break;
            }

            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Gets images related with an artist
        /// </summary>
        /// <param name="search">String of artist name or ID</param>
        /// <param name="results">Int of how many results to return (default = 15)</param>
        /// <param name="start">Int of where to start in the results (default = 0)</param>
        /// <param name="license">License of images (default = null)</param>
        /// <returns>json string</returns>
        public string ArtistImages(string search, int results = 15, int start = 0, string license = null)
        {
            string json;
            string urlSuffix = "artist/images?api_key=" + APIKey + query.NameOrArtistId(search);

            if (results != 15) { urlSuffix += "&results=" + results; }
            if (start != 0) { urlSuffix += "&start=" + start; }
            if (license != null) { urlSuffix += "&license=" + license; }

            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Gets the "list terms"
        /// </summary>
        /// <param name="type">string of type (default = "style"; other option = "mood")</param>
        /// <returns>json string</returns>
        public string ArtistListTerms(string type = "style")
        {
            string json;
            string urlSuffix = "artist/list_terms?api_key=" + APIKey + "&type=" + type;
            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Gets news about an artist
        /// </summary>
        /// <param name="search">String of artist name or ID</param>
        /// <param name="results">number of results to return (default = 15)</param>
        /// <param name="start">where to start in results returned (default = 0)</param>
        /// <param name="highRelevance">relevance of news (default = false)</param>
        /// <returns>json string</returns>
        public string ArtistNews(string search, int results = 15, int start = 0, bool highRelevance = false)
        {
            string json;
            string urlSuffix = "artist/news?api_key=" + APIKey + query.NameOrArtistId(search);

            if (results != 15) { urlSuffix += "&results=" + results; }
            if (start != 0) { urlSuffix += "&start=" + start; }
            if (highRelevance != false) { urlSuffix += "&high_relevance=" + highRelevance.ToString(); }

            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Gets the artist profile (or most relevant profile)
        /// </summary>
        /// <param name="search">string of artist name or ID</param>
        /// <returns>json string</returns>
        public string ArtistProfile(string search)
        {
            string urlSuffix = "artist/profile?api_key=" + APIKey + query.NameOrArtistId(search);
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Gets the artist profile (or most relevant profile)
        /// </summary>
        /// <param name="search">string of artist name or ID</param>
        /// <param name="bucket">Parameters object (only bucket options are relevant)</param>
        /// <returns>json string</returns>
        public string ArtistProfile(string search, Parameters bucket)
        {
            string json;
            Parameters bucketProcess = new Parameters();
            string parameters = bucketProcess.ArtistBucketString();
            string urlSuffix = "artist/profile?api_key=" + APIKey + query.NameOrArtistId(search) + parameters;

            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Gets reviews about an artist
        /// </summary>
        /// <param name="search">string of artist name or ID</param>
        /// <param name="results">number of results to get (default = 15)</param>
        /// <param name="start">where to start in results retured (default = 0)</param>
        /// <returns>json string</returns>
        public string ArtistReview(string search, int results = 15, int start = 0)
        {
            string json;
            string urlSuffix = "artist/reviews?api_key=" + APIKey + query.NameOrArtistId(search);
            if (results != 15) { urlSuffix += "&results=" + results; }
            if (start != 0) { urlSuffix += "&start=" + start; }
            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Extract any artists from a string
        /// </summary>
        /// <param name="search">String containing artist text</param>
        /// <returns>json string</returns>
        public string ArtistExtract(string search, Parameters parameters, int results = 15)
        {
            string json;
            string urlSuffix = "artist/extract?api_key=" + APIKey + query.NameOrArtistId(search);
            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Get similar artists
        /// </summary>
        /// <param name="search">string of artist name or ID</param>
        /// <param name="parameters">Parameters object</param>
        /// <param name="results">number of results to get (default = 15)</param>
        /// <returns>json string</returns>
        public string ArtistSimilar(string search, Parameters parameters, int results = 15)
        {
            string json;
            string urlSuffix = "artist/similar?api_key=" + APIKey + query.NameOrArtistId(search);
            if (results != 15) { urlSuffix += "&results=" + results; }
            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Suggested artists based on name/fragment of name
        /// </summary>
        /// <param name="search">string of artist name or fragment of name (or ID)</param>
        /// <returns></returns>
        public string ArtistSuggest(string search)
        {
            string json;
            string urlSuffix = "artist/suggest?api_key=" + APIKey + query.NameOrArtistId(search);
            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Get terms associated with an artist
        /// </summary>
        /// <param name="search">String of artist name or ID</param>
        /// <returns></returns>
        public string ArtistTerms(string search)
        {
            string json;
            string urlSuffix = "artist/terms?api_key=" + APIKey + query.NameOrArtistId(search);
            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Top Hott for artists
        /// </summary>
        /// <returns>json string</returns>
        public string ArtistTopHottt()
        {
            string json;
            string urlSuffix = "artist/top_hottt?api_key=" + APIKey;
            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Top Hott for artists
        /// </summary>
        /// <param name="bucket">Parameters object (only bucket options are relevant)</param>
        /// <returns>json string</returns>
        public string ArtistTopHottt(Parameters bucket)
        {
            // todo: implement genre search

            string json;
            Parameters bucketProcess = new Parameters();
            string parameters = bucketProcess.ArtistBucketString();
            string urlSuffix = "artist/top_hottt?api_key=" + APIKey + parameters;
            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Gets top terms.
        /// </summary>
        /// <returns>json string</returns>
        public string ArtistTopTerms()
        {
            string json;
            string urlSuffix = "artist/top_terms?api_key=" + APIKey;
            json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Gets an artist's twitter
        /// </summary>
        /// <param name="search">string of artist name or ID</param>
        /// <returns>json string</returns>
        public string ArtistTwitter(string search)
        {
            string urlSuffix = "artist/twitter?api_key=" + APIKey + query.NameOrArtistId(search);
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Gets urls related to an artist
        /// </summary>
        /// <param name="search">string of artist name or ID</param>
        /// <returns>json string</returns>
        public string ArtistUrls(string search)
        {
            string urlSuffix = "artist/urls?api_key=" + APIKey + query.NameOrArtistId(search);
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Gets videos for an artist
        /// </summary>
        /// <param name="search">string of artist name or ID</param>
        /// <param name="results">number of results to get (default = 15)</param>
        /// <param name="start">where to start in results retured (default = 0)</param>
        /// <returns>json string</returns>
        public string ArtistVideos(string search, int results = 15, int start = 0)
        {
            string urlSuffix = "artist/video?api_key=" + APIKey + query.NameOrArtistId(search);
            if (results != 15) { urlSuffix += "&results=" + results; }
            if (start != 0) { urlSuffix += "&start=" + start; }
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        // Song Methods

        public string SongSearch(string search, int results = 15, int start = 0)
        {
            string urlSuffix = "song/search?api_key=" + APIKey + query.ArtistOrArtistId(search);
            if (results != 15) { urlSuffix += "&results=" + results; }
            if (start != 0) { urlSuffix += "&start=" + start; }
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        public string SongSearch(string search, Parameters parameters)
        {
            if (search != parameters.songSearchParameters.artist) { parameters.songSearchParameters.artist = null; }
            string urlSuffix = "song/search?api_key=" + APIKey + query.ArtistOrArtistId(search) + parameters.SongSearchString() + parameters.SongBucketString();
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        public string SongSearch(Parameters parameters)
        {
            string urlSuffix = "song/search?api_key=" + APIKey + parameters.SongSearchString() + parameters.SongBucketString();
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        public string SongProfile(string id, Parameters parameters)
        {
            string urlSuffix = "song/profile?api_key=" + APIKey + query.SongOrTrackId(id)
                + parameters.ArtistBucketString();
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        // Genre methods

        /// <summary>
        /// Gets the top artists for a genre
        /// </summary>
        /// <param name="name">Genre name</param>
        /// <param name="limit">limit to Rosetta ID</param>
        /// <returns></returns>
        public string GenreArtists(string name, bool limit = false)
        {
            string urlSuffix = "genre/artists?api_key=" + APIKey + "&name=" + name;
            if (limit == true) { urlSuffix = urlSuffix + "&limit=true"; }
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        /// <summary>
        /// Gets the top artists for a genre
        /// </summary>
        /// <param name="name">Genre name</param>
        /// <param name="bucket">Artist bucket parameters</param>
        /// <param name="limit">Limit to Rosetta ID.</param>
        /// <returns></returns>
        public string GenreArtists(string name, Parameters bucket, bool limit = false)
        {
            string urlSuffix = "genre/artists?api_key=" + APIKey + "&name=" + name + bucket.ArtistBucketString();
            if (limit == true) { urlSuffix = urlSuffix + "&limit=true"; }
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        public string GenreProfile(string name, bool description = false, bool urls = false)
        {
            string urlSuffix = "genre/profile?api_key=" + APIKey + "&name=" + name;
            if (description == true) { urlSuffix = urlSuffix + "&bucket=description"; }
            if (urls == true) { urlSuffix = urlSuffix + "&bucket=urls"; }
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        public string GenreSearch(string name, int start = 0, int results = 100, bool description = false, bool urls = false)
        {
            string urlSuffix = "genre/search?api_key=" + APIKey + "&name=" + name;
            if (results != 100 && results > 0 && results < 100) { urlSuffix += "&results=" + results; }
            if (start != 0) { urlSuffix += "&start=" + start; }
            if (description == true) { urlSuffix = urlSuffix + "&bucket=description"; }
            if (urls == true) { urlSuffix = urlSuffix + "&bucket=urls"; }
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        public string GenreSimilar(string name, int start = 0, int results = 100, bool description = false, bool urls = false)
        {
            string urlSuffix = "genre/similar?api_key=" + APIKey + "&name=" + name;
            if (results != 100 && results > 0 && results < 100) { urlSuffix += "&results=" + results; }
            if (start != 0) { urlSuffix += "&start=" + start; }
            if (description == true) { urlSuffix = urlSuffix + "&bucket=description"; }
            if (urls == true) { urlSuffix = urlSuffix + "&bucket=urls"; }
            string json = echo.DownloadString(urlSuffix);
            return json;
        }

        //public string TrackProfile()
        //{
        //    string json;

        //    return json;
        //}

        //public string TrackUpload()
        //{

        //    echo.UploadFile()

        //    string json;
        //    return json;
        //}
    }
}
