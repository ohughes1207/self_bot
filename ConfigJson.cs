using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace JsonConfig
{
    public readonly struct ConfigJson
    {
        //Rename JsonPropertyName to JsonProperty if Newtonsoft.json is prefered
        [JsonPropertyName("token")]
        public string Token { get; init; }
    }
}