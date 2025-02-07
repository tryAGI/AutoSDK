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
        public required global::G.ExtensionViewsMobile Mobile { get; set; }

        /// <summary>
        /// Describes how the extension is rendered if the extension may be activated as a panel extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtensionViewsPanel Panel { get; set; }

        /// <summary>
        /// Describes how the extension is rendered if the extension may be activated as a video-overlay extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_overlay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtensionViewsVideoOverlay VideoOverlay { get; set; }

        /// <summary>
        /// Describes how the extension is rendered if the extension may be activated as a video-component extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtensionViewsComponent Component { get; set; }

        /// <summary>
        /// Describes the view that is shown to broadcasters while they are configuring your extension within the Extension Manager.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtensionViewsConfig Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
    }
}