//HintName: G.Models.WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public object? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        public object? Manifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadataTag? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata" /> class.
        /// </summary>
        /// <param name="labels"></param>
        /// <param name="manifest"></param>
        /// <param name="tag"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata(
            object? labels,
            object? manifest,
            global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadataTag? tag)
        {
            this.Labels = labels;
            this.Manifest = manifest;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata" /> class.
        /// </summary>
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersionContainerMetadata()
        {
        }
    }
}