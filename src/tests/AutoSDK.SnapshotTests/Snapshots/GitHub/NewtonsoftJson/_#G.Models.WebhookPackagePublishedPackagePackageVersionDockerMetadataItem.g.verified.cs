//HintName: G.Models.WebhookPackagePublishedPackagePackageVersionDockerMetadataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPackagePublishedPackagePackageVersionDockerMetadataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersionDockerMetadataItem" /> class.
        /// </summary>
        /// <param name="tags"></param>
        public WebhookPackagePublishedPackagePackageVersionDockerMetadataItem(
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersionDockerMetadataItem" /> class.
        /// </summary>
        public WebhookPackagePublishedPackagePackageVersionDockerMetadataItem()
        {
        }
    }
}