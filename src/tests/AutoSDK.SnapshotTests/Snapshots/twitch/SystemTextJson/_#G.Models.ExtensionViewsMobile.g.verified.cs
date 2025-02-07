//HintName: G.Models.ExtensionViewsMobile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes how the extension is displayed on mobile devices.
    /// </summary>
    public sealed partial class ExtensionViewsMobile
    {
        /// <summary>
        /// The HTML file that is shown to viewers on mobile devices. This page is presented to viewers as a panel behind the chat area of the mobile app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewer_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ViewerUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionViewsMobile" /> class.
        /// </summary>
        /// <param name="viewerUrl">
        /// The HTML file that is shown to viewers on mobile devices. This page is presented to viewers as a panel behind the chat area of the mobile app.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtensionViewsMobile(
            string viewerUrl)
        {
            this.ViewerUrl = viewerUrl ?? throw new global::System.ArgumentNullException(nameof(viewerUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionViewsMobile" /> class.
        /// </summary>
        public ExtensionViewsMobile()
        {
        }
    }
}