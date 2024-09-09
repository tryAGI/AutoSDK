//HintName: G.Models.ExtensionViewsConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes the view that is shown to broadcasters while they are configuring your extension within the Extension Manager.
    /// </summary>
    public sealed partial class ExtensionViewsConfig
    {
        /// <summary>
        /// The HTML file shown to broadcasters while they are configuring your extension within the Extension Manager.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("viewer_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ViewerUrl { get; set; } = default!;

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