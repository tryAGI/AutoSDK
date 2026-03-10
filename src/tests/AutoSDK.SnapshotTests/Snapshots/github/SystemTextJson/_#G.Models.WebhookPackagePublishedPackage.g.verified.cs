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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ecosystem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ecosystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::G.WebhookPackagePublishedPackageOwner? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_version")]
        public global::G.WebhookPackagePublishedPackagePackageVersion? PackageVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry")]
        public global::G.WebhookPackagePublishedPackageRegistry? Registry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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