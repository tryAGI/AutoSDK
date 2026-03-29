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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Instrumentation scope version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional scope attributes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::G.OtelAttribute>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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