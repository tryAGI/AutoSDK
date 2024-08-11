//HintName: G.Models.DependencyGraphDiffItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphDiffItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("change_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.DependencyGraphDiffItemChangeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependencyGraphDiffItemChangeType ChangeType { get; set; }

        /// <summary>
        /// Example: path/to/package-lock.json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Manifest { get; set; }

        /// <summary>
        /// Example: npm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ecosystem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ecosystem { get; set; }

        /// <summary>
        /// Example: @actions/core
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: 1.0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Example: pkg:/npm/%40actions/core@1.1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? PackageUrl { get; set; }

        /// <summary>
        /// Example: MIT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? License { get; set; }

        /// <summary>
        /// Example: https://github.com/github/actions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_repository_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? SourceRepositoryUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DependencyGraphDiffItemVulnerabilitie> Vulnerabilities { get; set; }

        /// <summary>
        /// Where the dependency is utilized. `development` means that the dependency is only utilized in the development environment. `runtime` means that the dependency is utilized at runtime and in the development environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.DependencyGraphDiffItemScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependencyGraphDiffItemScope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}