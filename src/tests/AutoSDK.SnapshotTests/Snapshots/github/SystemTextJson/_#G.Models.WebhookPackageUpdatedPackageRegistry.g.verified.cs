//HintName: G.Models.WebhookPackageUpdatedPackageRegistry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPackageUpdatedPackageRegistry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("about_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AboutUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Vendor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackageUpdatedPackageRegistry" /> class.
        /// </summary>
        /// <param name="aboutUrl"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="url"></param>
        /// <param name="vendor"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookPackageUpdatedPackageRegistry(
            string aboutUrl,
            string name,
            string type,
            string url,
            string vendor)
        {
            this.AboutUrl = aboutUrl ?? throw new global::System.ArgumentNullException(nameof(aboutUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Vendor = vendor ?? throw new global::System.ArgumentNullException(nameof(vendor));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackageUpdatedPackageRegistry" /> class.
        /// </summary>
        public WebhookPackageUpdatedPackageRegistry()
        {
        }
    }
}