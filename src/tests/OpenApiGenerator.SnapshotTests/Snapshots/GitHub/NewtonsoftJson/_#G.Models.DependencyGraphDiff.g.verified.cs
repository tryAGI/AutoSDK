//HintName: G.Models.DependencyGraphDiff.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphDiff
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("change_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependencyGraphDiffChangeType ChangeType { get; set; } = default!;

        /// <summary>
        /// Example: path/to/package-lock.json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Manifest { get; set; } = default!;

        /// <summary>
        /// Example: npm
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ecosystem", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ecosystem { get; set; } = default!;

        /// <summary>
        /// Example: @actions/core
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: 1.0.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Example: pkg:/npm/%40actions/core@1.1.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? PackageUrl { get; set; } = default!;

        /// <summary>
        /// Example: MIT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license", Required = global::Newtonsoft.Json.Required.Always)]
        public string? License { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/github/actions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? SourceRepositoryUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DependencyGraphDiffVulnerabilities> Vulnerabilities { get; set; } = default!;

        /// <summary>
        /// Where the dependency is utilized. `development` means that the dependency is only utilized in the development environment. `runtime` means that the dependency is utilized at runtime and in the development environment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependencyGraphDiffScope Scope { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}