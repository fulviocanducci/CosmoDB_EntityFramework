using Newtonsoft.Json;
namespace Models
{    
    public class People
    {   
        [JsonProperty(PropertyName = "id")]        
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "created")]
        public System.DateTime Created { get; set; }
    }
}