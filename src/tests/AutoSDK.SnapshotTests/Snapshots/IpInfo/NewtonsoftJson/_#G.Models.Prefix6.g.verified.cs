//HintName: G.Models.Prefix6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prefix6
    {
        /// <summary>
        /// Example: 2601::/20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("netblock", Required = global::Newtonsoft.Json.Required.Always)]
        public string Netblock { get; set; } = default!;

        /// <summary>
        /// Example: COMCAST6NET
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Example: Comcast Cable Communications, LLC
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: US
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country", Required = global::Newtonsoft.Json.Required.Always)]
        public string Country { get; set; } = default!;

        /// <summary>
        /// Example: 20282409603651670423947251286016
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Example: ASSIGNMENT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: comcast.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prefix6" /> class.
        /// </summary>
        /// <param name="netblock">
        /// Example: 2601::/20
        /// </param>
        /// <param name="id">
        /// Example: COMCAST6NET
        /// </param>
        /// <param name="name">
        /// Example: Comcast Cable Communications, LLC
        /// </param>
        /// <param name="country">
        /// Example: US
        /// </param>
        /// <param name="size">
        /// Example: 20282409603651670423947251286016
        /// </param>
        /// <param name="status">
        /// Example: ASSIGNMENT
        /// </param>
        /// <param name="domain">
        /// Example: comcast.com
        /// </param>
        public Prefix6(
            string netblock,
            string id,
            string name,
            string country,
            string? size,
            string? status,
            string? domain)
        {
            this.Netblock = netblock ?? throw new global::System.ArgumentNullException(nameof(netblock));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.Size = size;
            this.Status = status;
            this.Domain = domain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prefix6" /> class.
        /// </summary>
        public Prefix6()
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
        public static global::G.Prefix6? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Prefix6>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Prefix6?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Prefix6?>(serializer.Deserialize<global::G.Prefix6>(jsonReader));
        }

    }
}