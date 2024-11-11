//HintName: G.Models.WebhookPackageUpdatedPackagePackageVersionDockerMetadataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPackageUpdatedPackagePackageVersionDockerMetadataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackageUpdatedPackagePackageVersionDockerMetadataItem" /> class.
        /// </summary>
        /// <param name="tags"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookPackageUpdatedPackagePackageVersionDockerMetadataItem(
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackageUpdatedPackagePackageVersionDockerMetadataItem" /> class.
        /// </summary>
        public WebhookPackageUpdatedPackagePackageVersionDockerMetadataItem()
        {
        }
    }
}