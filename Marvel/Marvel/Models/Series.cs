using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Models
{
    public class Series
    {


        [JsonProperty("data")]
        public Data DataProp { get; set; }

        public class Thumbnail
        {
           
            [JsonProperty("path")]
            public string Path { get; set; }

            [JsonProperty("extension")]
            public string Extension { get; set; }

          
        }

      
        public class Creators
        {

            [JsonProperty("available")]
            public int Available { get; set; }

            [JsonProperty("collectionURI")]
            public string CollectionURI { get; set; }

            [JsonProperty("returned")]
            public int Returned { get; set; }
        }

      
     

        public class Stories
        {

            [JsonProperty("available")]
            public int Available { get; set; }

            [JsonProperty("collectionURI")]
            public string CollectionURI { get; set; }


            [JsonProperty("returned")]
            public int Returned { get; set; }
        }

        public class Result
        {

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("description")]
            public object Description { get; set; }

            [JsonProperty("resourceURI")]
            public string ResourceURI { get; set; }

          
            [JsonProperty("startYear")]
            public int StartYear { get; set; }

            [JsonProperty("endYear")]
            public int EndYear { get; set; }

            [JsonProperty("rating")]
            public string Rating { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("modified")]
            public string Modified { get; set; }

            [JsonProperty("thumbnail")]
            public Thumbnail Thumbnail { get; set; }

            [JsonProperty("creators")]
            public Creators Creators { get; set; }

          
            [JsonProperty("stories")]
            public Stories Stories { get; set; }

            public string Photo { get => $"{Thumbnail.Path}.{Thumbnail.Extension}"; }

            [JsonProperty("next")]
            public object Next { get; set; }

            [JsonProperty("[revious")]
            public object Previous { get; set; }
        }

        public class Data
        {

            [JsonProperty("results")]
            public IList<Result> Results { get; set; }
        }

     


    }
}
