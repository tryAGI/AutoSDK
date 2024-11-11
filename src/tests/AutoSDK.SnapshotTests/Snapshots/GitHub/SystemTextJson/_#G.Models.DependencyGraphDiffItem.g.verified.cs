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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependencyGraphDiffItemChangeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependencyGraphDiffItemChangeType ChangeType { get; set; }

        /// <summary>
        /// Example: path/to/package-lock.json
        /// </summary>
        /// <example>path/to/package-lock.json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Manifest { get; set; }

        /// <summary>
        /// Example: npm
        /// </summary>
        /// <example>npm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ecosystem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ecosystem { get; set; }

        /// <summary>
        /// Example: @actions/core
        /// </summary>
        /// <example>@actions/core</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: 1.0.0
        /// </summary>
        /// <example>1.0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Example: pkg:/npm/%40actions/core@1.1.0
        /// </summary>
        /// <example>pkg:/npm/%40actions/core@1.1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? PackageUrl { get; set; }

        /// <summary>
        /// Example: MIT
        /// </summary>
        /// <example>MIT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? License { get; set; }

        /// <summary>
        /// Example: https://github.com/github/actions
        /// </summary>
        /// <example>https://github.com/github/actions</example>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependencyGraphDiffItemScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependencyGraphDiffItemScope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphDiffItem" /> class.
        /// </summary>
        /// <param name="changeType"></param>
        /// <param name="manifest">
        /// Example: path/to/package-lock.json
        /// </param>
        /// <param name="ecosystem">
        /// Example: npm
        /// </param>
        /// <param name="name">
        /// Example: @actions/core
        /// </param>
        /// <param name="version">
        /// Example: 1.0.0
        /// </param>
        /// <param name="packageUrl">
        /// Example: pkg:/npm/%40actions/core@1.1.0
        /// </param>
        /// <param name="license">
        /// Example: MIT
        /// </param>
        /// <param name="sourceRepositoryUrl">
        /// Example: https://github.com/github/actions
        /// </param>
        /// <param name="vulnerabilities"></param>
        /// <param name="scope">
        /// Where the dependency is utilized. `development` means that the dependency is only utilized in the development environment. `runtime` means that the dependency is utilized at runtime and in the development environment.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DependencyGraphDiffItem(
            global::G.DependencyGraphDiffItemChangeType changeType,
            string manifest,
            string ecosystem,
            string name,
            string version,
            string? packageUrl,
            string? license,
            string? sourceRepositoryUrl,
            global::System.Collections.Generic.IList<global::G.DependencyGraphDiffItemVulnerabilitie> vulnerabilities,
            global::G.DependencyGraphDiffItemScope scope)
        {
            this.ChangeType = changeType;
            this.Manifest = manifest ?? throw new global::System.ArgumentNullException(nameof(manifest));
            this.Ecosystem = ecosystem ?? throw new global::System.ArgumentNullException(nameof(ecosystem));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.PackageUrl = packageUrl ?? throw new global::System.ArgumentNullException(nameof(packageUrl));
            this.License = license ?? throw new global::System.ArgumentNullException(nameof(license));
            this.SourceRepositoryUrl = sourceRepositoryUrl ?? throw new global::System.ArgumentNullException(nameof(sourceRepositoryUrl));
            this.Vulnerabilities = vulnerabilities ?? throw new global::System.ArgumentNullException(nameof(vulnerabilities));
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphDiffItem" /> class.
        /// </summary>
        public DependencyGraphDiffItem()
        {
        }
    }
}