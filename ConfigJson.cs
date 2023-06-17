using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace JsonConfig
{
    public readonly struct ConfigJson
    {
        [JsonPropertyName("token")]
        public string Token { get; init; }
    }
}