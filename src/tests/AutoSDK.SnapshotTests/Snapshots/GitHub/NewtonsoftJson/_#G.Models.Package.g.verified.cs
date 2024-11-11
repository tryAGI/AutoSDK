//HintName: G.Models.Package.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A software package
    /// </summary>
    public sealed partial class Package
    {
        /// <summary>
        /// Unique identifier of the package.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of the package.<br/>
        /// Example: super-linter
        /// </summary>
        /// <example>super-linter</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: docker
        /// </summary>
        /// <example>docker</example>
        [global::Newtonsoft.Json.JsonProperty("package_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PackagePackageType PackageType { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/packages/container/super-linter
        /// </summary>
        /// <example>https://api.github.com/orgs/github/packages/container/super-linter</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/orgs/github/packages/container/package/super-linter
        /// </summary>
        /// <example>https://github.com/orgs/github/packages/container/package/super-linter</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The number of versions of the package.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("version_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionCount { get; set; } = default!;

        /// <summary>
        /// Example: private
        /// </summary>
        /// <example>private</example>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PackageVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public global::G.NullableSimpleUser? Owner { get; set; }

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::G.NullableMinimalRepository? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the package.<br/>
        /// Example: 1
        /// </param>
        /// <param name="name">
        /// The name of the package.<br/>
        /// Example: super-linter
        /// </param>
        /// <param name="packageType">
        /// Example: docker
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/orgs/github/packages/container/super-linter
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/orgs/github/packages/container/package/super-linter
        /// </param>
        /// <param name="versionCount">
        /// The number of versions of the package.<br/>
        /// Example: 1
        /// </param>
        /// <param name="visibility">
        /// Example: private
        /// </param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public Package(
            int id,
            string name,
            global::G.PackagePackageType packageType,
            string url,
            string htmlUrl,
            int versionCount,
            global::G.PackageVisibility visibility,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.NullableSimpleUser? owner,
            global::G.NullableMinimalRepository? repository)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PackageType = packageType;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.VersionCount = versionCount;
            this.Visibility = visibility;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Owner = owner;
            this.Repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        public Package()
        {
        }
    }
}