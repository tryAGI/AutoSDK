//HintName: G.Models.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItemValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItemValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItemValue" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="branch"></param>
        /// <param name="commit"></param>
        /// <param name="type"></param>
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItemValue(
            string? url,
            string? branch,
            string? commit,
            string? type)
        {
            this.Url = url;
            this.Branch = branch;
            this.Commit = commit;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItemValue" /> class.
        /// </summary>
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItemValue()
        {
        }
    }
}