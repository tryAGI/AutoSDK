//HintName: G.Models.ExtensionViewsPanel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes how the extension is rendered if the extension may be activated as a panel extension.
    /// </summary>
    public sealed partial class ExtensionViewsPanel
    {
        /// <summary>
        /// The HTML file that is shown to viewers on the channel page when the extension is activated in a Panel slot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("viewer_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ViewerUrl { get; set; } = default!;

        /// <summary>
        /// The height, in pixels, of the panel component that the extension is rendered in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public int Height { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the extension can link to non-Twitch domains.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_link_external_content", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanLinkExternalContent { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionViewsPanel" /> class.
        /// </summary>
        /// <param name="viewerUrl">
        /// The HTML file that is shown to viewers on the channel page when the extension is activated in a Panel slot.
        /// </param>
        /// <param name="height">
        /// The height, in pixels, of the panel component that the extension is rendered in.
        /// </param>
        /// <param name="canLinkExternalContent">
        /// A Boolean value that determines whether the extension can link to non-Twitch domains.
        /// </param>
        public ExtensionViewsPanel(
            string viewerUrl,
            int height,
            bool canLinkExternalContent)
        {
            this.ViewerUrl = viewerUrl ?? throw new global::System.ArgumentNullException(nameof(viewerUrl));
            this.Height = height;
            this.CanLinkExternalContent = canLinkExternalContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionViewsPanel" /> class.
        /// </summary>
        public ExtensionViewsPanel()
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
        public static global::G.ExtensionViewsPanel? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ExtensionViewsPanel>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ExtensionViewsPanel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ExtensionViewsPanel?>(serializer.Deserialize<global::G.ExtensionViewsPanel>(jsonReader));
        }

    }
}