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
        [global::Newtonsoft.Json.JsonProperty("viewer_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ViewerUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionViewsMobile" /> class.
        /// </summary>
        /// <param name="viewerUrl">
        /// The HTML file that is shown to viewers on mobile devices. This page is presented to viewers as a panel behind the chat area of the mobile app.
        /// </param>
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