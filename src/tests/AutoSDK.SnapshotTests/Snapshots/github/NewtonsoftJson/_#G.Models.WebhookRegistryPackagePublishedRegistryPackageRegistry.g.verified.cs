//HintName: G.Models.WebhookRegistryPackagePublishedRegistryPackageRegistry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRegistryPackagePublishedRegistryPackageRegistry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("about_url")]
        public string? AboutUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vendor")]
        public string? Vendor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackageRegistry" /> class.
        /// </summary>
        /// <param name="aboutUrl"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="url"></param>
        /// <param name="vendor"></param>
        public WebhookRegistryPackagePublishedRegistryPackageRegistry(
            string? aboutUrl,
            string? name,
            string? type,
            string? url,
            string? vendor)
        {
            this.AboutUrl = aboutUrl;
            this.Name = name;
            this.Type = type;
            this.Url = url;
            this.Vendor = vendor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackageRegistry" /> class.
        /// </summary>
        public WebhookRegistryPackagePublishedRegistryPackageRegistry()
        {
        }
    }
}