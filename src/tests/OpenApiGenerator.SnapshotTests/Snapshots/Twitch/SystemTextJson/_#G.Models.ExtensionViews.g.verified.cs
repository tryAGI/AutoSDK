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
        [global::System.Text.Json.Serialization.JsonPropertyName("mobile")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required ExtensionViewsMobile Mobile { get; set; }

        /// <summary>
        /// Describes how the extension is rendered if the extension may be activated as a panel extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required ExtensionViewsPanel Panel { get; set; }

        /// <summary>
        /// Describes how the extension is rendered if the extension may be activated as a video-overlay extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_overlay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required ExtensionViewsVideoOverlay VideoOverlay { get; set; }

        /// <summary>
        /// Describes how the extension is rendered if the extension may be activated as a video-component extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required ExtensionViewsComponent Component { get; set; }

        /// <summary>
        /// Describes the view that is shown to broadcasters while they are configuring your extension within the Extension Manager.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required ExtensionViewsConfig Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}