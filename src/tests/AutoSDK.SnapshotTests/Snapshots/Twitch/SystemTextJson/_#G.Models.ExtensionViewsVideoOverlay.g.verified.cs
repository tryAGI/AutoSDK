//HintName: G.Models.ExtensionViewsVideoOverlay.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes how the extension is rendered if the extension may be activated as a video-overlay extension.
    /// </summary>
    public sealed partial class ExtensionViewsVideoOverlay
    {
        /// <summary>
        /// The HTML file that is shown to viewers on the channel page when the extension is activated on the Video - Overlay slot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewer_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ViewerUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="ExtensionViewsVideoOverlay" /> class.
        /// </summary>
        /// <param name="viewerUrl">
        /// The HTML file that is shown to viewers on the channel page when the extension is activated on the Video - Overlay slot.
        /// </param>
        /// <param name="canLinkExternalContent">
        /// A Boolean value that determines whether the extension can link to non-Twitch domains.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ExtensionViewsVideoOverlay(
            string viewerUrl,
            bool canLinkExternalContent)
        {
            this.ViewerUrl = viewerUrl ?? throw new global::System.ArgumentNullException(nameof(viewerUrl));
            this.CanLinkExternalContent = canLinkExternalContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionViewsVideoOverlay" /> class.
        /// </summary>
        public ExtensionViewsVideoOverlay()
        {
        }
    }
}