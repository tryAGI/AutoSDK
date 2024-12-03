//HintName: G.Models.Dependency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Dependency
    {
        /// <summary>
        /// Package-url (PURL) of dependency. See https://github.com/package-url/purl-spec for more details.<br/>
        /// Example: pkg:/npm/%40actions/http-client@1.0.11
        /// </summary>
        /// <example>pkg:/npm/%40actions/http-client@1.0.11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_url")]
        public string? PackageUrl { get; set; }

        /// <summary>
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// A notation of whether a dependency is requested directly by this manifest or is a dependency of another dependency.<br/>
        /// Example: direct
        /// </summary>
        /// <example>direct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationship")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependencyRelationshipJsonConverter))]
        public global::G.DependencyRelationship? Relationship { get; set; }

        /// <summary>
        /// A notation of whether the dependency is required for the primary build artifact (runtime) or is only used for development. Future versions of this specification may allow for more granular scopes.<br/>
        /// Example: runtime
        /// </summary>
        /// <example>runtime</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependencyScopeJsonConverter))]
        public global::G.DependencyScope? Scope { get; set; }

        /// <summary>
        /// Array of package-url (PURLs) of direct child dependencies.<br/>
        /// Example: @actions/http-client
        /// </summary>
        /// <example>@actions/http-client</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<string>? Dependencies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dependency" /> class.
        /// </summary>
        /// <param name="packageUrl">
        /// Package-url (PURL) of dependency. See https://github.com/package-url/purl-spec for more details.<br/>
        /// Example: pkg:/npm/%40actions/http-client@1.0.11
        /// </param>
        /// <param name="metadata">
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </param>
        /// <param name="relationship">
        /// A notation of whether a dependency is requested directly by this manifest or is a dependency of another dependency.<br/>
        /// Example: direct
        /// </param>
        /// <param name="scope">
        /// A notation of whether the dependency is required for the primary build artifact (runtime) or is only used for development. Future versions of this specification may allow for more granular scopes.<br/>
        /// Example: runtime
        /// </param>
        /// <param name="dependencies">
        /// Array of package-url (PURLs) of direct child dependencies.<br/>
        /// Example: @actions/http-client
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Dependency(
            string? packageUrl,
            object? metadata,
            global::G.DependencyRelationship? relationship,
            global::G.DependencyScope? scope,
            global::System.Collections.Generic.IList<string>? dependencies)
        {
            this.PackageUrl = packageUrl;
            this.Metadata = metadata;
            this.Relationship = relationship;
            this.Scope = scope;
            this.Dependencies = dependencies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dependency" /> class.
        /// </summary>
        public Dependency()
        {
        }
    }
}