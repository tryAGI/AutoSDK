//HintName: G.Models.ExtensionViews.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes all views-related information such as how the extension is displayed on mobile devices.
    /// </summary>
    public sealed partial class ExtensionViews
    {
        /// <summary>
        /// Describes how the extension is displayed on mobile devices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mobile", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionViewsMobile Mobile { get; set; } = default!;

        /// <summary>
        /// Describes how the extension is rendered if the extension may be activated as a panel extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("panel", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionViewsPanel Panel { get; set; } = default!;

        /// <summary>
        /// Describes how the extension is rendered if the extension may be activated as a video-overlay extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_overlay", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionViewsVideoOverlay VideoOverlay { get; set; } = default!;

        /// <summary>
        /// Describes how the extension is rendered if the extension may be activated as a video-component extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionViewsComponent Component { get; set; } = default!;

        /// <summary>
        /// Describes the view that is shown to broadcasters while they are configuring your extension within the Extension Manager.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionViewsConfig Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionViews" /> class.
        /// </summary>
        /// <param name="mobile">
        /// Describes how the extension is displayed on mobile devices.
        /// </param>
        /// <param name="panel">
        /// Describes how the extension is rendered if the extension may be activated as a panel extension.
        /// </param>
        /// <param name="videoOverlay">
        /// Describes how the extension is rendered if the extension may be activated as a video-overlay extension.
        /// </param>
        /// <param name="component">
        /// Describes how the extension is rendered if the extension may be activated as a video-component extension.
        /// </param>
        /// <param name="config">
        /// Describes the view that is shown to broadcasters while they are configuring your extension within the Extension Manager.
        /// </param>
        public ExtensionViews(
            global::G.ExtensionViewsMobile mobile,
            global::G.ExtensionViewsPanel panel,
            global::G.ExtensionViewsVideoOverlay videoOverlay,
            global::G.ExtensionViewsComponent component,
            global::G.ExtensionViewsConfig config)
        {
            this.Mobile = mobile ?? throw new global::System.ArgumentNullException(nameof(mobile));
            this.Panel = panel ?? throw new global::System.ArgumentNullException(nameof(panel));
            this.VideoOverlay = videoOverlay ?? throw new global::System.ArgumentNullException(nameof(videoOverlay));
            this.Component = component ?? throw new global::System.ArgumentNullException(nameof(component));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionViews" /> class.
        /// </summary>
        public ExtensionViews()
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
        public static global::G.ExtensionViews? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ExtensionViews>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ExtensionViews?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ExtensionViews?>(serializer.Deserialize<global::G.ExtensionViews>(jsonReader));
        }

    }
}