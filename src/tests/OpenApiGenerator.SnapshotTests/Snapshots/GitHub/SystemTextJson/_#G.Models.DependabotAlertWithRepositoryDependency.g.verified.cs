//HintName: G.Models.DependabotAlertWithRepositoryDependency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for the vulnerable dependency.
    /// </summary>
    public sealed partial class DependabotAlertWithRepositoryDependency
    {
        /// <summary>
        /// Details for the vulnerable package.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package")]
        public DependabotAlertPackage? Package { get; set; }

        /// <summary>
        /// The full path to the dependency manifest file, relative to the root of the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_path")]
        public string? ManifestPath { get; set; }

        /// <summary>
        /// The execution scope of the vulnerable dependency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}