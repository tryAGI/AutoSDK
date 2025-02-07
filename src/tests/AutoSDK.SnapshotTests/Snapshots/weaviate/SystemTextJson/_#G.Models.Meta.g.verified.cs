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
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// The Weaviate server version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Module-specific meta information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modules")]
        public object? Modules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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