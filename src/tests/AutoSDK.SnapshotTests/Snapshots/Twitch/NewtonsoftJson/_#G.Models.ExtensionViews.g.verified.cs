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
    }
}