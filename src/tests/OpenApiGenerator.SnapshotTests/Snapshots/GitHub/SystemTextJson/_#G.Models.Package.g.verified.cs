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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the package.
        /// <br/>Example: super-linter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// <br/>Example: docker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageType { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/github/packages/container/super-linter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/orgs/github/packages/container/package/super-linter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The number of versions of the package.
        /// <br/>Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionCount { get; set; }

        /// <summary>
        /// <br/>Example: private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Visibility { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public NullableSimpleUser? Owner { get; set; }

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public NullableMinimalRepository? Repository { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}