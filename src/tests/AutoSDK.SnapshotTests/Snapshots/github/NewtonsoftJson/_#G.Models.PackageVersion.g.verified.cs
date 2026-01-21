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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of the package version.<br/>
        /// Example: latest
        /// </summary>
        /// <example>latest</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/packages/container/super-linter/versions/786068
        /// </summary>
        /// <example>https://api.github.com/orgs/github/packages/container/super-linter/versions/786068</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/orgs/github/packages/container/package/super-linter
        /// </summary>
        /// <example>https://github.com/orgs/github/packages/container/package/super-linter</example>
        [global::Newtonsoft.Json.JsonProperty("package_html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PackageHtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/orgs/github/packages/container/super-linter/786068
        /// </summary>
        /// <example>https://github.com/orgs/github/packages/container/super-linter/786068</example>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Example: MIT
        /// </summary>
        /// <example>MIT</example>
        [global::Newtonsoft.Json.JsonProperty("license")]
        public string? License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: 2011-04-10T20:09:31Z
        /// </summary>
        /// <example>2011-04-10T20:09:31Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Example: 2014-03-03T18:58:10Z
        /// </summary>
        /// <example>2014-03-03T18:58:10Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Example: 2014-03-03T18:58:10Z
        /// </summary>
        /// <example>2014-03-03T18:58:10Z</example>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.PackageVersionMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="createdAt">
        /// Example: 2011-04-10T20:09:31Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2014-03-03T18:58:10Z
        /// </param>
        /// <param name="deletedAt">
        /// Example: 2014-03-03T18:58:10Z
        /// </param>
        /// <param name="metadata"></param>
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