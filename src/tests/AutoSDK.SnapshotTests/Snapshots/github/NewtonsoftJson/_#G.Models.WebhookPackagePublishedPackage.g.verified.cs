//HintName: G.Models.WebhookPackagePublishedPackage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the package.
    /// </summary>
    public sealed partial class WebhookPackagePublishedPackage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ecosystem", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ecosystem { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("namespace", Required = global::Newtonsoft.Json.Required.Always)]
        public string Namespace { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public global::G.WebhookPackagePublishedPackageOwner? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string PackageType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package_version")]
        public global::G.WebhookPackagePublishedPackagePackageVersion? PackageVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("registry")]
        public global::G.WebhookPackagePublishedPackageRegistry? Registry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackage" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="ecosystem"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="namespace"></param>
        /// <param name="owner"></param>
        /// <param name="packageType"></param>
        /// <param name="packageVersion"></param>
        /// <param name="registry"></param>
        /// <param name="updatedAt"></param>
        public WebhookPackagePublishedPackage(
            string ecosystem,
            string htmlUrl,
            int id,
            string name,
            string @namespace,
            string packageType,
            string? createdAt,
            string? description,
            global::G.WebhookPackagePublishedPackageOwner? owner,
            global::G.WebhookPackagePublishedPackagePackageVersion? packageVersion,
            global::G.WebhookPackagePublishedPackageRegistry? registry,
            string? updatedAt)
        {
            this.Ecosystem = ecosystem ?? throw new global::System.ArgumentNullException(nameof(ecosystem));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.PackageType = packageType ?? throw new global::System.ArgumentNullException(nameof(packageType));
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Owner = owner;
            this.PackageVersion = packageVersion;
            this.Registry = registry;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackage" /> class.
        /// </summary>
        public WebhookPackagePublishedPackage()
        {
        }
    }
}