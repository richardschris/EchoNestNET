using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EchoNestNET
{
    public class Parser
    {
        // this is the basic JSON parser (relies on Newtonsoft JSON)

        public IList<Artist> MultiArtistParse(string json)
        {
            IList<Artist> artistList = new List<Artist>();
            JObject o = JObject.Parse(json);
            IList<JToken> results = o["response"]["artists"].Children().ToList();

            foreach (var i in results)
            {
                Artist artist = JsonConvert.DeserializeObject<Artist>(i.ToString());
                artistList.Add(artist);
            }

            return artistList;
        }

        public IList<Artist> SingleArtistParse(string json)
        {
            List<Artist> artistList = new List<Artist>();
            JObject o = JObject.Parse(json);
            string results = o["response"]["artist"].ToString();

            Artist artist = JsonConvert.DeserializeObject<Artist>(results);
            artistList.Add(artist);

            return artistList;
        }

        public IList<Song> ArtistSongParse(string json)
        {
            IList<Song> songList = new List<Song>();
            JObject o = JObject.Parse(json);
            IList<JToken> results = o["response"]["songs"].Children().ToList();

            foreach (var i in results)
            {
                Song song = JsonConvert.DeserializeObject<Song>(i.ToString());
                songList.Add(song);
            }

            return songList;
        }
        public IList<Biography> ArtistBiographyParse(string json)
        {
            List<Biography> biographyList = new List<Biography>();
            JObject o = JObject.Parse(json);
            IList<JToken> results = o["response"]["biographies"].Children().ToList();

            foreach (var i in results)
            {
                Biography biography = JsonConvert.DeserializeObject<Biography>(i.ToString());
                biographyList.Add(biography);
            }

            return biographyList;
        }

        public IList<Blog> ArtistBlogParse(string json)
        {
            List<Blog> blogList = new List<Blog>();
            JObject o = JObject.Parse(json);
            IList<JToken> results = o["response"]["blogs"].Children().ToList();

            foreach (var i in results)
            {
                Blog blog = JsonConvert.DeserializeObject<Blog>(i.ToString());
                blogList.Add(blog);
            }

            return blogList;
        }

        public IList<Image> ArtistImages(string json)
        {
            List<Image> imageList = new List<Image>();
            JObject o = JObject.Parse(json);
            IList<JToken> results = o["response"]["images"].Children().ToList();

            foreach (var i in results)
            {
                Image image = JsonConvert.DeserializeObject<Image>(i.ToString());
                imageList.Add(image);
            }

            return imageList;
        }

        public ListTerms ListTerms(string json)
        {
            // the implementation here differs, but its JSON return format is slightly different than the others, and
            // is unlikely to be used frequently.
            ListTerms listTerms = new ListTerms();
            JObject o = JObject.Parse(json);
            var names = o["response"]["terms"];
            listTerms.type = o["response"]["type"].ToString();

            foreach (var i in names)
            {
                listTerms.terms.Add(i["name"].ToString());
            }
            return listTerms;
        }

        public IList<News> ArtistNews(string json)
        {
            List<News> newsList = new List<News>();
            JObject o = JObject.Parse(json);
            IList<JToken> results = o["response"]["news"].Children().ToList();

            foreach (var i in results)
            {
                News news = JsonConvert.DeserializeObject<News>(i.ToString());
                newsList.Add(news);
            }

            return newsList;
        }

        public IList<Review> ArtistReviews(string json)
        {
            IList<Review> reviewList = new List<Review>();
            JObject o = JObject.Parse(json);
            IList<JToken> results = o["response"]["reviews"].Children().ToList();

            foreach (var i in results)
            {
                Review review = JsonConvert.DeserializeObject<Review>(i.ToString());
                reviewList.Add(review);
            }

            return reviewList;
        }

        public IList<Term> TermParse(string json)
        {
            IList<Term> termsList = new List<Term>();
            JObject o = JObject.Parse(json);
            IList<JToken> results = o["response"]["terms"].Children().ToList();

            foreach (var i in results)
            {
                Term term = JsonConvert.DeserializeObject<Term>(i.ToString());
                termsList.Add(term);
            }

            return termsList;
        }

        public IList<Urls> ArtistUrls(string json)
        {
            IList<Urls> urlsList = new List<Urls>();
            JObject o = JObject.Parse(json);
            string results = o["response"]["urls"].ToString();

            Urls url = JsonConvert.DeserializeObject<Urls>(results);
            urlsList.Add(url);

            return urlsList;
        }

        public IList<Video> VideoParse(string json)
        {
            IList<Video> videosList = new List<Video>();
            JObject o = JObject.Parse(json);
            IList<JToken> results = o["response"]["video"].Children().ToList();

            foreach (var i in results)
            {
                Video video = JsonConvert.DeserializeObject<Video>(i.ToString());
                videosList.Add(video);
            }

            return videosList;
        }

        public IList<Song> SongParse(string json)
        {
            IList<Song> songList = new List<Song>();
            JObject o = JObject.Parse(json);
            IList<JToken> results = o["response"]["songs"].Children().ToList();

            foreach (var i in results)
            {
                Song song = JsonConvert.DeserializeObject<Song>(i.ToString());
                songList.Add(song);
            }

            return songList;
        }

        public IList<Genre> SingleGenreParse(string json)
        {
            List<Genre> genreList = new List<Genre>();
            JObject o = JObject.Parse(json);
            string results = o["response"]["genres"].ToString();

            Genre genre = JsonConvert.DeserializeObject<Genre>(results);
            genreList.Add(genre);

            return genreList;
        }

        public IList<Genre> MultiGenreParse(string json)
        {
            IList<Genre> genreList = new List<Genre>();
            JObject o = JObject.Parse(json);
            IList<JToken> results = o["response"]["artists"].Children().ToList();

            foreach (var i in results)
            {
                Genre genre = JsonConvert.DeserializeObject<Genre>(i.ToString());
                genreList.Add(genre);
            }

            return genreList;
        }
    }
}
