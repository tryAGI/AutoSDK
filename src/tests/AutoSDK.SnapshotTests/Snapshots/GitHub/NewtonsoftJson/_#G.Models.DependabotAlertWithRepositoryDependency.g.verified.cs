//HintName: G.Models.DependabotAlertWithRepositoryDependency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for the vulnerable dependency.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class DependabotAlertWithRepositoryDependency
    {
        /// <summary>
        /// Details for the vulnerable package.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package")]
        public global::G.DependabotAlertPackage? Package { get; set; }

        /// <summary>
        /// The full path to the dependency manifest file, relative to the root of the repository.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest_path")]
        public string? ManifestPath { get; set; }

        /// <summary>
        /// The execution scope of the vulnerable dependency.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope")]
        public global::G.DependabotAlertWithRepositoryDependencyScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertWithRepositoryDependency" /> class.
        /// </summary>
        /// <param name="package">
        /// Details for the vulnerable package.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="manifestPath">
        /// The full path to the dependency manifest file, relative to the root of the repository.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="scope">
        /// The execution scope of the vulnerable dependency.<br/>
        /// Included only in responses
        /// </param>
        public DependabotAlertWithRepositoryDependency(
            global::G.DependabotAlertPackage? package,
            string? manifestPath,
            global::G.DependabotAlertWithRepositoryDependencyScope? scope)
        {
            this.Package = package;
            this.ManifestPath = manifestPath;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertWithRepositoryDependency" /> class.
        /// </summary>
        public DependabotAlertWithRepositoryDependency()
        {
        }
    }
}