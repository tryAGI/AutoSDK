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
        [global::Newtonsoft.Json.JsonProperty("about_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AboutUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vendor", Required = global::Newtonsoft.Json.Required.Always)]
        public string Vendor { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackageUpdatedPackageRegistry" /> class.
        /// </summary>
        /// <param name="aboutUrl"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="url"></param>
        /// <param name="vendor"></param>
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