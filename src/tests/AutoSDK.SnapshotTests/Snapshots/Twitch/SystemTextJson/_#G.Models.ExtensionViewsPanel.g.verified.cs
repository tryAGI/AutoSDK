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
        [global::System.Text.Json.Serialization.JsonPropertyName("viewer_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ViewerUrl { get; set; }

        /// <summary>
        /// The height, in pixels, of the panel component that the extension is rendered in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the extension can link to non-Twitch domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_link_external_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanLinkExternalContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.ExtensionViewsPanel? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ExtensionViewsPanel),
                jsonSerializerContext) as global::G.ExtensionViewsPanel;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExtensionViewsPanel>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ExtensionViewsPanel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ExtensionViewsPanel),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ExtensionViewsPanel;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ExtensionViewsPanel?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}