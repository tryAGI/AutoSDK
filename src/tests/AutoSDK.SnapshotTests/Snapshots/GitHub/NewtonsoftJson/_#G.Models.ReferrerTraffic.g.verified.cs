//HintName: G.Models.ReferrerTraffic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Referrer Traffic
    /// </summary>
    public sealed partial class ReferrerTraffic
    {
        /// <summary>
        /// Example: Google
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referrer", Required = global::Newtonsoft.Json.Required.Always)]
        public string Referrer { get; set; } = default!;

        /// <summary>
        /// Example: 4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Example: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uniques", Required = global::Newtonsoft.Json.Required.Always)]
        public int Uniques { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferrerTraffic" /> class.
        /// </summary>
        /// <param name="referrer">
        /// Example: Google
        /// </param>
        /// <param name="count">
        /// Example: 4
        /// </param>
        /// <param name="uniques">
        /// Example: 3
        /// </param>
        public ReferrerTraffic(
            string referrer,
            int count,
            int uniques)
        {
            this.Referrer = referrer ?? throw new global::System.ArgumentNullException(nameof(referrer));
            this.Count = count;
            this.Uniques = uniques;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferrerTraffic" /> class.
        /// </summary>
        public ReferrerTraffic()
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
        public static global::G.ReferrerTraffic? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ReferrerTraffic>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ReferrerTraffic?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ReferrerTraffic?>(serializer.Deserialize<global::G.ReferrerTraffic>(jsonReader));
        }

    }
}