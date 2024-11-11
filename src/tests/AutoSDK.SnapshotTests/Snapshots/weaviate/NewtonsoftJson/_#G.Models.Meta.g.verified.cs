//HintName: G.Models.Meta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains meta information of the current Weaviate instance.
    /// </summary>
    public sealed partial class Meta
    {
        /// <summary>
        /// The url of the host.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// The Weaviate server version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Module-specific meta information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modules")]
        public object? Modules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Meta" /> class.
        /// </summary>
        /// <param name="hostname">
        /// The url of the host.
        /// </param>
        /// <param name="version">
        /// The Weaviate server version.
        /// </param>
        /// <param name="modules">
        /// Module-specific meta information.
        /// </param>
        public Meta(
            string? hostname,
            string? version,
            object? modules)
        {
            this.Hostname = hostname;
            this.Version = version;
            this.Modules = modules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Meta" /> class.
        /// </summary>
        public Meta()
        {
        }
    }
}