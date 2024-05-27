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
        [global::System.Text.Json.Serialization.JsonPropertyName("viewer_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ViewerUrl { get; set; }

        /// <summary>
        /// The width value of the ratio (width : height) which determines the extension’s width, and how the extension’s iframe will resize in different video player environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio_x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AspectRatioX { get; set; }

        /// <summary>
        /// The height value of the ratio (width : height) which determines the extension’s height, and how the extension’s iframe will resize in different video player environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio_y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AspectRatioY { get; set; }

        /// <summary>
        /// A Boolean value that determines whether to apply CSS zoom. If **true**, a CSS zoom is applied such that the size of the extension is variable but the inner dimensions are fixed based on Scale Pixels. This allows your extension to render as if it is of fixed width and height. If **false**, the inner dimensions of the extension iframe are variable, meaning your extension must implement responsiveness.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Autoscale { get; set; }

        /// <summary>
        /// The base width, in pixels, of the extension to use when scaling (see `autoscale`). This value is ignored if `autoscale` is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_pixels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScalePixels { get; set; }

        /// <summary>
        /// The height as a percent of the maximum height of a video component extension. Values are between 1% - 100%.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetHeight { get; set; }

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
    }
}