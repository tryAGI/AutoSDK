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
        /// Unique identifier of the package.
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of the package.
        /// <br/>Example: super-linter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// <br/>Example: docker
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package_type", Required = global::Newtonsoft.Json.Required.Always)]
        public PackagePackageType PackageType { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/github/packages/container/super-linter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://github.com/orgs/github/packages/container/package/super-linter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The number of versions of the package.
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionCount { get; set; } = default!;

        /// <summary>
        /// <br/>Example: private
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        public PackageVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public NullableSimpleUser? Owner { get; set; }

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public NullableMinimalRepository? Repository { get; set; }

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
    }
}