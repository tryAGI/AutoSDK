//HintName: G.Models.ExtensionAnalytics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtensionAnalytics
    {
        /// <summary>
        /// An ID that identifies the extension that the report was generated for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extension_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExtensionId { get; set; } = default!;

        /// <summary>
        /// The URL that you use to download the report. The URL is valid for 5 minutes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("URL", Required = global::Newtonsoft.Json.Required.Always)]
        public string URL { get; set; } = default!;

        /// <summary>
        /// The type of report.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The reporting window’s start and end dates, in RFC3339 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date_range", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionAnalyticsDateRange DateRange { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionAnalytics" /> class.
        /// </summary>
        /// <param name="extensionId">
        /// An ID that identifies the extension that the report was generated for.
        /// </param>
        /// <param name="uRL">
        /// The URL that you use to download the report. The URL is valid for 5 minutes.
        /// </param>
        /// <param name="type">
        /// The type of report.
        /// </param>
        /// <param name="dateRange">
        /// The reporting window’s start and end dates, in RFC3339 format.
        /// </param>
        public ExtensionAnalytics(
            string extensionId,
            string uRL,
            string type,
            global::G.ExtensionAnalyticsDateRange dateRange)
        {
            this.ExtensionId = extensionId ?? throw new global::System.ArgumentNullException(nameof(extensionId));
            this.URL = uRL ?? throw new global::System.ArgumentNullException(nameof(uRL));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DateRange = dateRange ?? throw new global::System.ArgumentNullException(nameof(dateRange));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionAnalytics" /> class.
        /// </summary>
        public ExtensionAnalytics()
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
        public static global::G.ExtensionAnalytics? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ExtensionAnalytics>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ExtensionAnalytics?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ExtensionAnalytics?>(serializer.Deserialize<global::G.ExtensionAnalytics>(jsonReader));
        }

    }
}