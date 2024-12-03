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
        [global::System.Text.Json.Serialization.JsonPropertyName("about_url")]
        public string? AboutUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendor")]
        public string? Vendor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackageRegistry" /> class.
        /// </summary>
        /// <param name="aboutUrl"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="url"></param>
        /// <param name="vendor"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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