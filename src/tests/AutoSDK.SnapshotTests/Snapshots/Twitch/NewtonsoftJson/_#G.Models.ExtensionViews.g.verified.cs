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


    #if NET6_0_OR_GREATER
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

#if NET6_0_OR_GREATER
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

    }
}