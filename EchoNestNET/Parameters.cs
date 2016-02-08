using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNestNET
{
    public class Parameters
    {
        public ArtistBucket artistBucketParameters = new ArtistBucket();
        public ArtistSearch artistSearchParameters = new ArtistSearch();
        public SongSearch songSearchParameters = new SongSearch();
        public SongBucket songBucketParameters = new SongBucket();

        public class ArtistBucket
        {
            public bool biographies { get; set; } = false;
            public bool blogs { get; set; } = false;
            public bool discovery { get; set; } = false;
            public bool discoveryRank { get; set; } = false;
            public bool docCounts { get; set; } = false;
            public bool familiarity { get; set; } = false;
            public bool familiarityRank { get; set; } = false;
            public bool genre { get; set; } = false;
            public bool hotttnesss { get; set; } = false;
            public bool hotttnesssRank { get; set; } = false;
            public bool images { get; set; } = false;
            public bool artistLocation { get; set; } = false;
            public bool news { get; set; } = false;
            public bool reviews { get; set; } = false;
            public bool songs { get; set; } = false;
            public bool urls { get; set; } = false;
            public bool videos { get; set; } = false;
            public bool yearsActive { get; set; } = false;
            // need to add Rosetta Stone IDs and personal taste profile IDs.
        }

        public class ArtistSearch
        {
            public bool limit { get; set; } = false;
            public string artistLocation { get; set; } = null;
            public string name { get; set; } = null;
            public string id { get; set; } = null;
            public string description { get; set; } = null;
            public string genre { get; set; } = null;
            public string style { get; set; } = null;
            public string mood { get; set; } = null;
            public string rankType { get; set; } = "relevance";
            public bool fuzzyMatch { get; set; } = false;
            public double maxFamiliarity { get; set; } = 1.0;
            public double minFamiliarity { get; set; } = 0.0;
            public double maxHotttnesss { get; set; } = 1.0;
            public double minHotttnesss { get; set; } = 0.0;
            public string artistStartYearBefore { get; set; } = null;
            public string artistStartYearAfter { get; set; } = null;
            public string artistEndYearBefore { get; set; } = null;
            public string artistEndYearAfter { get; set; } = null;
            public string sort { get; set; } = null;
            public string text { get; set; } = null;
        }

        public string ArtistSearchString()
        {
            StringBuilder searchBuilder = new StringBuilder("");

            if (artistSearchParameters.artistEndYearAfter != null) { searchBuilder.Append("&artist_end_year_after=" + artistSearchParameters.artistEndYearAfter); }
            if (artistSearchParameters.artistEndYearBefore != null) { searchBuilder.Append("&artist_end_year_before=" + artistSearchParameters.artistEndYearBefore); }
            if (artistSearchParameters.artistLocation != null) { searchBuilder.Append("&artist_location=" + artistSearchParameters.artistLocation); }
            if (artistSearchParameters.artistStartYearAfter != null) { searchBuilder.Append("&artist_start_year_after=" + artistSearchParameters.artistStartYearAfter); }
            if (artistSearchParameters.artistStartYearBefore != null) { searchBuilder.Append("&artist_start_year_before=" + artistSearchParameters.artistStartYearBefore); }
            if (artistSearchParameters.description != null) { searchBuilder.Append("&description=" + artistSearchParameters.description); }
            if (artistSearchParameters.fuzzyMatch != false) { searchBuilder.Append("&fuzzy_match=true"); }
            if (artistSearchParameters.genre != null) { searchBuilder.Append("&genre=" + artistSearchParameters.genre); }
            if (artistSearchParameters.limit != false) { searchBuilder.Append("&limit=true"); }
            if (artistSearchParameters.maxFamiliarity != 1.0) { searchBuilder.Append("&max_familiarity=" + artistSearchParameters.maxFamiliarity); }
            if (artistSearchParameters.maxHotttnesss != 1.0) { searchBuilder.Append("&max_hotttnesss=" + artistSearchParameters.maxHotttnesss); }
            if (artistSearchParameters.minFamiliarity != 0.0) { searchBuilder.Append("&min_familiarity=" + artistSearchParameters.minFamiliarity); }
            if (artistSearchParameters.minHotttnesss != 0.0) { searchBuilder.Append("&min_hotttnesss=" + artistSearchParameters.minHotttnesss); }
            if (artistSearchParameters.mood != null) { searchBuilder.Append("&mood=" + artistSearchParameters.mood); }

            if (artistSearchParameters.id != null && artistSearchParameters.name != null)
            {
                throw new System.Exception("Both name and id are defined; set one to null.");
            }
            
            if (artistSearchParameters.id != null) { searchBuilder.Append("&id=" + artistSearchParameters.id); }
            if (artistSearchParameters.name != null) { searchBuilder.Append("&name=" + artistSearchParameters.name); }
            
            if (artistSearchParameters.rankType != "relevance") { searchBuilder.Append("&rank_type=" + artistSearchParameters.rankType); }
            if (artistSearchParameters.sort != null) { searchBuilder.Append("&sort=" + artistSearchParameters.sort); }
            if (artistSearchParameters.style != null) { searchBuilder.Append("&style=" + artistSearchParameters.style); }

            return searchBuilder.ToString();
        }

        public string ArtistSimilar()
        {
            StringBuilder similarBuilder = new StringBuilder("");

            if (artistSearchParameters.limit != false) { similarBuilder.Append("&limit=true"); }

            return similarBuilder.ToString();
        }

        public string ArtistExtract()
        {
            StringBuilder extractBuilder = new StringBuilder("");
            if (artistSearchParameters.limit != false) { extractBuilder.Append("&limit=true"); }
            if (artistSearchParameters.text != null) { extractBuilder.Append("&text=" + artistSearchParameters.text); }
            if (artistSearchParameters.maxFamiliarity != 1.0) { extractBuilder.Append("&max_familiarity=" + artistSearchParameters.maxFamiliarity); }
            if (artistSearchParameters.maxHotttnesss != 1.0) { extractBuilder.Append("&max_hotttnesss=" + artistSearchParameters.maxHotttnesss); }
            if (artistSearchParameters.minFamiliarity != 0.0) { extractBuilder.Append("&min_familiarity=" + artistSearchParameters.minFamiliarity); }
            if (artistSearchParameters.minHotttnesss != 0.0) { extractBuilder.Append("&min_hotttnesss=" + artistSearchParameters.minHotttnesss); }
            if (artistSearchParameters.sort != null) { extractBuilder.Append("&sort=" + artistSearchParameters.sort); }

            return extractBuilder.ToString();
        }

        public string ArtistBucketString()
        {
            StringBuilder bucketBuilder = new StringBuilder("");
            if (artistBucketParameters.artistLocation == true) { bucketBuilder.Append("&bucket=artist_location"); }
            if (artistBucketParameters.biographies == true)
            {
                bucketBuilder.Append("&bucket=biographies");
            }
            if (artistBucketParameters.blogs == true)
            {
                bucketBuilder.Append("&bucket=blogs");
            }
            if (artistBucketParameters.discovery == true)
            {
                bucketBuilder.Append("&bucket=discovery");
            }
            if (artistBucketParameters.discoveryRank == true)
            {
                bucketBuilder.Append("&bucket=discovery_rank");
            }
            if (artistBucketParameters.docCounts == true)
            {
                bucketBuilder.Append("&bucket=doc_counts");
            }
            if (artistBucketParameters.familiarity == true)
            {
                bucketBuilder.Append("&bucket=familiarity");
            }
            if (artistBucketParameters.familiarityRank == true)
            {
                bucketBuilder.Append("&bucket=familiarity_rank");
            }
            if (artistBucketParameters.genre == true)
            {
                bucketBuilder.Append("&bucket=genre");
            }
            if (artistBucketParameters.hotttnesss == true)
            {
                bucketBuilder.Append("&bucket=hotttnesss");
            }
            if (artistBucketParameters.hotttnesssRank == true)
            {
                bucketBuilder.Append("&bucket=hotttnesss_rank");
            }
            if (artistBucketParameters.images == true)
            {
                bucketBuilder.Append("&bucket=images");
            }
            if (artistBucketParameters.news == true)
            {
                bucketBuilder.Append("&bucket=news");
            }
            if (artistBucketParameters.reviews == true)
            {
                bucketBuilder.Append("&bucket=reviews");
            }
            if (artistBucketParameters.songs == true)
            {
                bucketBuilder.Append("&bucket=songs");
            }
            if (artistBucketParameters.urls == true)
            {
                bucketBuilder.Append("&bucket=urls");
            }
            if (artistBucketParameters.videos == true)
            {
                bucketBuilder.Append("&bucket=video");
            }
            if (artistBucketParameters.yearsActive == true)
            {
                bucketBuilder.Append("&bucket=years_active");
            }

            string bucketString = bucketBuilder.ToString();
            return bucketString;
        }

        public class SongSearch
        {
            public string title { get; set; } = null;
            public string artist { get; set; } = null;
            public string combined { get; set; } = null;
            public string description { get; set; } = null;
            public string style { get; set; } = null;
            public string mood { get; set; } = null;
            public string rankType { get; set; } = "relevance";
            public string artistId { get; set; } = null ;
            public int results { get; set; } = 15;
            public int start { get; set; } = 0;
            public string songType { get; set; } = null;
            public float maxTempo { get; set; } = 500f;
            public float minTempo { get; set; } = 0f;
            public float maxDuration { get; set; } = 3600f;
            public float minDuration { get; set; } = 0f;
            public float maxLoudness { get; set; } = 100f;
            public float minLoudness { get; set; } = -100f;
            public float artistMaxFamiliarity { get; set; } = 1f;
            public float artistMinFamiliarity { get; set; } = 0f;
            public string artistStartYearBefore { get; set; } = null;
            public string artistStartYearAfter { get; set; } = null;
            public string artistEndYearBefore { get; set; } = null;
            public string artistEndYearAfter { get; set; } = null;
            public float songMaxHotttnesss { get; set; } = 1f;
            public float songMinHotttnesss { get; set; } = 0f;
            public float artistMaxHotttnesss { get; set; } = 1f;
            public float artistMinHotttnesss { get; set; } = 0f;
            public float minLatitude { get; set; } = -180f;
            public float maxLatitude { get; set; } = 180f;
            public float minLongitude { get; set; } = -90f;
            public float maxLongitude { get; set; } = 90f;
            public float maxDanceability { get; set; } = 1f;
            public float minDanceability { get; set; } = 0f;
            public float maxEnergy { get; set; } = 1f;
            public float minEnergy { get; set; } = 0f;
            public float maxLiveness { get; set; } = 1f;
            public float minLiveness { get; set; } = 0f;
            public float maxSpeechiness { get; set; } = 1f;
            public float minSpeechiness { get; set; } = 0f;
            public float maxAcousticness { get; set; } = 1f;
            public float minAcousticness { get; set; } = 0f;
            public string mode { get; set; } = null;
            public string key { get; set; } = null;
            public string sort { get; set; } = null;
            public bool limit { get; set; } = false;
        }

        public string SongSearchString()
        {
            StringBuilder songSearchBuilder = new StringBuilder();

            if (songSearchParameters.title != null) { songSearchBuilder.Append("&title=" + songSearchParameters.title); }
            if (songSearchParameters.artist != null) { songSearchBuilder.Append("&artist=" + songSearchParameters.artist); }
            if (songSearchParameters.combined != null) { songSearchBuilder.Append("&combined=" + songSearchParameters.combined); }
            if (songSearchParameters.description != null) { songSearchBuilder.Append("&description=" + songSearchParameters.description); }
            if (songSearchParameters.style != null) { songSearchBuilder.Append("&style=" + songSearchParameters.style); }
            if (songSearchParameters.mood != null) { songSearchBuilder.Append("&mood=" + songSearchParameters.mood); }
            if (songSearchParameters.rankType != "relevance") { songSearchBuilder.Append("&rank_type=familiarity"); }
            if (songSearchParameters.artistId != null) { songSearchBuilder.Append("&artist_id=" + songSearchParameters.artistId); }
            if (songSearchParameters.results != 15) { songSearchBuilder.Append("&results=" + songSearchParameters.results); }
            if (songSearchParameters.start != 0) { songSearchBuilder.Append("&start=" + songSearchParameters.start); }
            if (songSearchParameters.songType != null) { songSearchBuilder.Append("&song_type=" + songSearchParameters.songType); }
            if (songSearchParameters.maxTempo != 500f) { songSearchBuilder.Append("&max_tempo=" + songSearchParameters.maxTempo); }
            if (songSearchParameters.minTempo != 0f) { songSearchBuilder.Append("&min_tempo=" + songSearchParameters.minTempo); }
            if (songSearchParameters.maxDuration != 3600f) { songSearchBuilder.Append("&max_duration=" + songSearchParameters.maxDuration); }
            if (songSearchParameters.minDuration != 0f) { songSearchBuilder.Append("&min_duration=" + songSearchParameters.minDuration); }
            if (songSearchParameters.maxLoudness != 100f) { songSearchBuilder.Append("&max_loudness=" + songSearchParameters.maxLoudness); }
            if (songSearchParameters.minLoudness != -100f) { songSearchBuilder.Append("&min_loudness=" + songSearchParameters.minLoudness); }
            if (songSearchParameters.artistMaxFamiliarity != 1f) { songSearchBuilder.Append("&artist_max_familiarity=" + songSearchParameters.artistMaxFamiliarity); }
            if (songSearchParameters.artistMinFamiliarity != 0f) { songSearchBuilder.Append("&artist_min_familiarity=" + songSearchParameters.artistMinFamiliarity); }
            if (songSearchParameters.artistStartYearBefore != null) { songSearchBuilder.Append("&artist_start_year_before=" + songSearchParameters.artistStartYearBefore); }
            if (songSearchParameters.artistStartYearAfter != null) { songSearchBuilder.Append("&artist_start_year_after=" + songSearchParameters.artistStartYearAfter); }
            if (songSearchParameters.artistEndYearBefore != null) { songSearchBuilder.Append("&artist_end_year_before=" + songSearchParameters.artistEndYearBefore); }
            if (songSearchParameters.artistEndYearAfter != null) { songSearchBuilder.Append("&artist_end_year_after=" + songSearchParameters.artistEndYearAfter); }
            if (songSearchParameters.songMaxHotttnesss != 1f) { songSearchBuilder.Append("&song_max_hotttnesss=" + songSearchParameters.songMaxHotttnesss); }
            if (songSearchParameters.songMinHotttnesss != 0f) { songSearchBuilder.Append("&song_min_hotttnesss=" + songSearchParameters.songMinHotttnesss); }
            if (songSearchParameters.artistMaxHotttnesss != 1f) { songSearchBuilder.Append("&artist_max_hotttnesss=" + songSearchParameters.artistMaxHotttnesss); }
            if (songSearchParameters.minLongitude != -90f) { songSearchBuilder.Append("&min_longitude=" + songSearchParameters.minLongitude); }
            if (songSearchParameters.maxLongitude != 90f) { songSearchBuilder.Append("&max_longitude=" + songSearchParameters.maxLongitude); }
            if (songSearchParameters.minLatitude != -180f) { songSearchBuilder.Append("&min_latitude=" + songSearchParameters.minLatitude); }
            if (songSearchParameters.maxLatitude != 180f) { songSearchBuilder.Append("&max_latitude=" + songSearchParameters.maxLatitude); }
            if (songSearchParameters.minDanceability != 0f) { songSearchBuilder.Append("&min_danceability=" + songSearchParameters.minDanceability); }
            if (songSearchParameters.maxDanceability != 1f) { songSearchBuilder.Append("&max_danceability=" + songSearchParameters.maxDanceability); }
            if (songSearchParameters.maxEnergy != 1f) { songSearchBuilder.Append("&max_energy=" + songSearchParameters.maxEnergy); }
            if (songSearchParameters.minEnergy != 0f) { songSearchBuilder.Append("&min_energy=" + songSearchParameters.minEnergy); }
            if (songSearchParameters.maxLiveness != 1f) { songSearchBuilder.Append("&max_liveness=" + songSearchParameters.maxLiveness); }
            if (songSearchParameters.minLiveness != 0f) { songSearchBuilder.Append("&min_liveness=" + songSearchParameters.minLiveness); }
            if (songSearchParameters.maxSpeechiness != 1f) { songSearchBuilder.Append("&max_speechiness=" + songSearchParameters.maxSpeechiness); }
            if (songSearchParameters.minSpeechiness != 0f) { songSearchBuilder.Append("&min_speechiness=" + songSearchParameters.minSpeechiness); }
            if (songSearchParameters.maxAcousticness != 1f) { songSearchBuilder.Append("&max_acousticness=" + songSearchParameters.maxAcousticness); }
            if (songSearchParameters.minAcousticness != 0f) { songSearchBuilder.Append("&min_acousticness=" + songSearchParameters.minAcousticness); }
            if (songSearchParameters.mode != null) { songSearchBuilder.Append("&mode=" + songSearchParameters.mode); }
            if (songSearchParameters.key != null) { songSearchBuilder.Append("&key=" + songSearchParameters.key); }
            if (songSearchParameters.sort != null) { songSearchBuilder.Append("&sort=" + songSearchParameters.sort); }
            if (songSearchParameters.limit != false) { songSearchBuilder.Append("&limit=true"); }
 
            string songSearch = songSearchBuilder.ToString();
            return songSearch;
        }

        public class SongBucket
        {
            public bool audioSummary { get; set; } = false;
            public bool artistDiscovery { get; set; } = false;
            public bool artistDiscoveryRank { get; set; } = false;
            public bool artistFamiliarity { get; set; } = false;
            public bool artistFamiliarityRank { get; set; } = false;
            public bool artistHotttnesss { get; set; } = false;
            public bool artistHotttnesssRank { get; set; } = false;
            public bool artistLocation { get; set; } = false;
            public bool songCurrency { get; set; } = false;
            public bool songCurrencyRank { get; set; } = false;
            public bool songDiscovery { get; set; } = false;
            public bool songDiscoveryRank { get; set; } = false;
            public bool songHotttnesss { get; set; } = false;
            public bool songHotttnesssRank { get; set; } = false;
            public bool songType { get; set; } = false;
            public bool tracks { get; set; } = false;
        }

        public string SongBucketString()
        {
            StringBuilder songBucket = new StringBuilder("");
            if (songBucketParameters.audioSummary != false) { songBucket.Append("&bucket=audio_summary"); }
            if (songBucketParameters.artistDiscovery != false) { songBucket.Append("&bucket=artist_discovery"); }
            if (songBucketParameters.artistDiscoveryRank != false) { songBucket.Append("&bucket=artist_discovery_rank"); }
            if (songBucketParameters.artistFamiliarity != false) { songBucket.Append("&bucket=artist_familiarity"); }
            if (songBucketParameters.artistFamiliarityRank != false) { songBucket.Append("&bucket=artist_familiarity_rank"); }
            if (songBucketParameters.artistHotttnesss != false) { songBucket.Append("&bucket=artist_hotttnesss"); }
            if (songBucketParameters.artistHotttnesssRank != false) { songBucket.Append("&bucket=artist_hotttnesss_rank"); }
            if (songBucketParameters.artistLocation != false) { songBucket.Append("&bucket=artist_location"); }
            if (songBucketParameters.songCurrency != false) { songBucket.Append("&bucket=song_currency"); }
            if (songBucketParameters.songCurrencyRank != false) { songBucket.Append("&bucket=song_currency_rank"); }
            if (songBucketParameters.songDiscovery != false) { songBucket.Append("&bucket=song_discovery"); }
            if (songBucketParameters.songDiscoveryRank != false) { songBucket.Append("&bucket=song_discovery_rank"); }
            if (songBucketParameters.songHotttnesss != false) { songBucket.Append("&bucket=song_hotttnesss"); }
            if (songBucketParameters.songHotttnesssRank != false) { songBucket.Append("&bucket=song_hotttnesss_rank"); }
            if (songBucketParameters.songType != false) { songBucket.Append("&bucket=song_type"); }
            if (songBucketParameters.tracks != false) { songBucket.Append("&bucket=tracks"); }

            return songBucket.ToString();
        }

    }
}
