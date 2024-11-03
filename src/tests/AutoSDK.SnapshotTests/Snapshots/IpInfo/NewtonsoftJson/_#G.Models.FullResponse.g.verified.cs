//HintName: G.Models.FullResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FullResponse
    {
        /// <summary>
        /// Example: 66.87.125.72
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ip", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ip { get; set; } = default!;

        /// <summary>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bogon")]
        public bool? Bogon { get; set; }

        /// <summary>
        /// Example: ip-66-87-125-72.spfdma.spcsdns.net
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// Example: Springfield
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// Example: Massachusetts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Example: US
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Example: 42.0999,-72.5783
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loc")]
        public string? Loc { get; set; }

        /// <summary>
        /// Example: 01105
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("postal")]
        public string? Postal { get; set; }

        /// <summary>
        /// Example: America/New_York
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Example: AS51501 Khabarovsk home networks Ltd
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org")]
        public string? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asn")]
        public global::G.AsnResponse? Asn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("company")]
        public global::G.Company? Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("carrier")]
        public global::G.Carrier? Carrier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public global::G.PrivacyResponse? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domains")]
        public global::G.DomainsResponse? Domains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.FullResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.FullResponse>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.FullResponse?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.FullResponse?>(serializer.Deserialize<global::G.FullResponse>(jsonReader));
        }

    }
}