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
    }
}