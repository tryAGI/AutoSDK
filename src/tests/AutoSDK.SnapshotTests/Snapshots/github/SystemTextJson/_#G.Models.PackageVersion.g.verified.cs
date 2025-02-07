//HintName: G.Models.PackageVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A version of a software package
    /// </summary>
    public sealed partial class PackageVersion
    {
        /// <summary>
        /// Unique identifier of the package version.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the package version.<br/>
        /// Example: latest
        /// </summary>
        /// <example>latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/packages/container/super-linter/versions/786068
        /// </summary>
        /// <example>https://api.github.com/orgs/github/packages/container/super-linter/versions/786068</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/orgs/github/packages/container/package/super-linter
        /// </summary>
        /// <example>https://github.com/orgs/github/packages/container/package/super-linter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageHtmlUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/orgs/github/packages/container/super-linter/786068
        /// </summary>
        /// <example>https://github.com/orgs/github/packages/container/super-linter/786068</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Example: MIT
        /// </summary>
        /// <example>MIT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.PackageVersionMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersion" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the package version.<br/>
        /// Example: 1
        /// </param>
        /// <param name="name">
        /// The name of the package version.<br/>
        /// Example: latest
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/orgs/github/packages/container/super-linter/versions/786068
        /// </param>
        /// <param name="packageHtmlUrl">
        /// Example: https://github.com/orgs/github/packages/container/package/super-linter
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/orgs/github/packages/container/super-linter/786068
        /// </param>
        /// <param name="license">
        /// Example: MIT
        /// </param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="deletedAt"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PackageVersion(
            int id,
            string name,
            string url,
            string packageHtmlUrl,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? htmlUrl,
            string? license,
            string? description,
            global::System.DateTime? deletedAt,
            global::G.PackageVersionMetadata? metadata)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PackageHtmlUrl = packageHtmlUrl ?? throw new global::System.ArgumentNullException(nameof(packageHtmlUrl));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.HtmlUrl = htmlUrl;
            this.License = license;
            this.Description = description;
            this.DeletedAt = deletedAt;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersion" /> class.
        /// </summary>
        public PackageVersion()
        {
        }
    }
}