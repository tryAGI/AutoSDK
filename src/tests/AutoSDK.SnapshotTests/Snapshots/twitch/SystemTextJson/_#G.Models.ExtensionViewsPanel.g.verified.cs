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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
    }
}