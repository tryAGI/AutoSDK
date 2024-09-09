//HintName: G.Models.ExtensionViewsComponent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes how the extension is rendered if the extension may be activated as a video-component extension.
    /// </summary>
    public sealed partial class ExtensionViewsComponent
    {
        /// <summary>
        /// The HTML file that is shown to viewers on the channel page when the extension is activated in a Video - Component slot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("viewer_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ViewerUrl { get; set; } = default!;

        /// <summary>
        /// The width value of the ratio (width : height) which determines the extension’s width, and how the extension’s iframe will resize in different video player environments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio_x", Required = global::Newtonsoft.Json.Required.Always)]
        public int AspectRatioX { get; set; } = default!;

        /// <summary>
        /// The height value of the ratio (width : height) which determines the extension’s height, and how the extension’s iframe will resize in different video player environments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio_y", Required = global::Newtonsoft.Json.Required.Always)]
        public int AspectRatioY { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether to apply CSS zoom. If **true**, a CSS zoom is applied such that the size of the extension is variable but the inner dimensions are fixed based on Scale Pixels. This allows your extension to render as if it is of fixed width and height. If **false**, the inner dimensions of the extension iframe are variable, meaning your extension must implement responsiveness.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoscale", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Autoscale { get; set; } = default!;

        /// <summary>
        /// The base width, in pixels, of the extension to use when scaling (see `autoscale`). This value is ignored if `autoscale` is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale_pixels", Required = global::Newtonsoft.Json.Required.Always)]
        public int ScalePixels { get; set; } = default!;

        /// <summary>
        /// The height as a percent of the maximum height of a video component extension. Values are between 1% - 100%.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_height", Required = global::Newtonsoft.Json.Required.Always)]
        public int TargetHeight { get; set; } = default!;

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
    }
}