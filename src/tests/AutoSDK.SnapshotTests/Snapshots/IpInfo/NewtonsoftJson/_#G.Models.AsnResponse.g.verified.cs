//HintName: G.Models.AsnResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsnResponse
    {
        /// <summary>
        /// Example: AS10507
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asn", Required = global::Newtonsoft.Json.Required.Always)]
        public string Asn { get; set; } = default!;

        /// <summary>
        /// Example: Sprint Personal Communications Systems
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: US
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Example: 1997-02-14
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allocated")]
        public string? Allocated { get; set; }

        /// <summary>
        /// Example: arin
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("registry")]
        public string? Registry { get; set; }

        /// <summary>
        /// Example: sprint.net
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domain", Required = global::Newtonsoft.Json.Required.Always)]
        public string Domain { get; set; } = default!;

        /// <summary>
        /// Example: 71224576
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_ips")]
        public int? NumIps { get; set; }

        /// <summary>
        /// Example: 66.87.125.0/24
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("route")]
        public string? Route { get; set; }

        /// <summary>
        /// Example: isp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AsnResponseType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefixes")]
        public global::System.Collections.Generic.IList<global::G.Prefix>? Prefixes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefixes6")]
        public global::System.Collections.Generic.IList<global::G.Prefix6>? Prefixes6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peers")]
        public global::System.Collections.Generic.IList<string>? Peers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upstreams")]
        public global::System.Collections.Generic.IList<string>? Upstreams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("downstreams")]
        public global::System.Collections.Generic.IList<string>? Downstreams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsnResponse" /> class.
        /// </summary>
        /// <param name="asn">
        /// Example: AS10507
        /// </param>
        /// <param name="name">
        /// Example: Sprint Personal Communications Systems
        /// </param>
        /// <param name="country">
        /// Example: US
        /// </param>
        /// <param name="allocated">
        /// Example: 1997-02-14
        /// </param>
        /// <param name="registry">
        /// Example: arin
        /// </param>
        /// <param name="domain">
        /// Example: sprint.net
        /// </param>
        /// <param name="numIps">
        /// Example: 71224576
        /// </param>
        /// <param name="route">
        /// Example: 66.87.125.0/24
        /// </param>
        /// <param name="type">
        /// Example: isp
        /// </param>
        /// <param name="prefixes"></param>
        /// <param name="prefixes6"></param>
        /// <param name="peers"></param>
        /// <param name="upstreams"></param>
        /// <param name="downstreams"></param>
        public AsnResponse(
            string asn,
            string name,
            string domain,
            global::G.AsnResponseType type,
            string? country,
            string? allocated,
            string? registry,
            int? numIps,
            string? route,
            global::System.Collections.Generic.IList<global::G.Prefix>? prefixes,
            global::System.Collections.Generic.IList<global::G.Prefix6>? prefixes6,
            global::System.Collections.Generic.IList<string>? peers,
            global::System.Collections.Generic.IList<string>? upstreams,
            global::System.Collections.Generic.IList<string>? downstreams)
        {
            this.Asn = asn ?? throw new global::System.ArgumentNullException(nameof(asn));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Type = type;
            this.Country = country;
            this.Allocated = allocated;
            this.Registry = registry;
            this.NumIps = numIps;
            this.Route = route;
            this.Prefixes = prefixes;
            this.Prefixes6 = prefixes6;
            this.Peers = peers;
            this.Upstreams = upstreams;
            this.Downstreams = downstreams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsnResponse" /> class.
        /// </summary>
        public AsnResponse()
        {
        }


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
        public static global::G.AsnResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.AsnResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.AsnResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.AsnResponse?>(serializer.Deserialize<global::G.AsnResponse>(jsonReader));
        }

    }
}