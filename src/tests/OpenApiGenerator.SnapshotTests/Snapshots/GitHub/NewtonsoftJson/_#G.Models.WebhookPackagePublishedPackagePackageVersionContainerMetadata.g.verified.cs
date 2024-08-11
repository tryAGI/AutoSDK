//HintName: G.Models.WebhookPackagePublishedPackagePackageVersionContainerMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPackagePublishedPackagePackageVersionContainerMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::G.WebhookPackagePublishedPackagePackageVersionContainerMetadataLabels? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest")]
        public global::G.WebhookPackagePublishedPackagePackageVersionContainerMetadataManifest? Manifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        public global::G.WebhookPackagePublishedPackagePackageVersionContainerMetadataTag? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}