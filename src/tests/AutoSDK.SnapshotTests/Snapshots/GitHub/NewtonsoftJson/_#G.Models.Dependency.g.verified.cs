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
        [global::Newtonsoft.Json.JsonProperty("package_url")]
        public string? PackageUrl { get; set; }

        /// <summary>
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// A notation of whether a dependency is requested directly by this manifest or is a dependency of another dependency.<br/>
        /// Example: direct
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relationship")]
        public global::G.DependencyRelationship? Relationship { get; set; }

        /// <summary>
        /// A notation of whether the dependency is required for the primary build artifact (runtime) or is only used for development. Future versions of this specification may allow for more granular scopes.<br/>
        /// Example: runtime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope")]
        public global::G.DependencyScope? Scope { get; set; }

        /// <summary>
        /// Array of package-url (PURLs) of direct child dependencies.<br/>
        /// Example: @actions/http-client
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependencies")]
        public global::System.Collections.Generic.IList<string>? Dependencies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}