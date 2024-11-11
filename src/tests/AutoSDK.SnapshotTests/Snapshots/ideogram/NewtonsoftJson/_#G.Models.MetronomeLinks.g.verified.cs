//HintName: G.Models.MetronomeLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetronomeLinks
    {
        /// <summary>
        /// The URL to display the customer invoice and API usage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invoices_iframe_url")]
        public string? InvoicesIframeUrl { get; set; }

        /// <summary>
        /// The URL to display the customer invoice and API usage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invoices_iframe_dark_mode_url")]
        public string? InvoicesIframeDarkModeUrl { get; set; }

        /// <summary>
        /// The URL to display the customer invoice and API usage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits_iframe_url")]
        public string? CreditsIframeUrl { get; set; }

        /// <summary>
        /// The URL to display the customer invoice and API usage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits_iframe_dark_mode_url")]
        public string? CreditsIframeDarkModeUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetronomeLinks" /> class.
        /// </summary>
        /// <param name="invoicesIframeUrl">
        /// The URL to display the customer invoice and API usage.
        /// </param>
        /// <param name="invoicesIframeDarkModeUrl">
        /// The URL to display the customer invoice and API usage.
        /// </param>
        /// <param name="creditsIframeUrl">
        /// The URL to display the customer invoice and API usage.
        /// </param>
        /// <param name="creditsIframeDarkModeUrl">
        /// The URL to display the customer invoice and API usage.
        /// </param>
        public MetronomeLinks(
            string? invoicesIframeUrl,
            string? invoicesIframeDarkModeUrl,
            string? creditsIframeUrl,
            string? creditsIframeDarkModeUrl)
        {
            this.InvoicesIframeUrl = invoicesIframeUrl;
            this.InvoicesIframeDarkModeUrl = invoicesIframeDarkModeUrl;
            this.CreditsIframeUrl = creditsIframeUrl;
            this.CreditsIframeDarkModeUrl = creditsIframeDarkModeUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetronomeLinks" /> class.
        /// </summary>
        public MetronomeLinks()
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
        public static global::G.MetronomeLinks? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MetronomeLinks>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.MetronomeLinks?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.MetronomeLinks?>(serializer.Deserialize<global::G.MetronomeLinks>(jsonReader));
        }

    }
}