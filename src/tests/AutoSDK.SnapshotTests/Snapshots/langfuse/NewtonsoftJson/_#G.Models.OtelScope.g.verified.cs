//HintName: G.Models.OtelScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Instrumentation scope information
    /// </summary>
    public sealed partial class OtelScope
    {
        /// <summary>
        /// Instrumentation scope name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Instrumentation scope version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional scope attributes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public global::System.Collections.Generic.IList<global::G.OtelAttribute>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelScope" /> class.
        /// </summary>
        /// <param name="name">
        /// Instrumentation scope name
        /// </param>
        /// <param name="version">
        /// Instrumentation scope version
        /// </param>
        /// <param name="attributes">
        /// Additional scope attributes
        /// </param>
        public OtelScope(
            string? name,
            string? version,
            global::System.Collections.Generic.IList<global::G.OtelAttribute>? attributes)
        {
            this.Name = name;
            this.Version = version;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelScope" /> class.
        /// </summary>
        public OtelScope()
        {
        }
    }
}