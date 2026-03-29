//HintName: G.Models.OtelAttribute.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Key-value attribute pair for resources, scopes, or spans
    /// </summary>
    public sealed partial class OtelAttribute
    {
        /// <summary>
        /// Attribute key (e.g., "service.name", "langfuse.observation.type")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Attribute value wrapper supporting different value types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::G.OtelAttributeValue? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelAttribute" /> class.
        /// </summary>
        /// <param name="key">
        /// Attribute key (e.g., "service.name", "langfuse.observation.type")
        /// </param>
        /// <param name="value">
        /// Attribute value wrapper supporting different value types
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OtelAttribute(
            string? key,
            global::G.OtelAttributeValue? value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelAttribute" /> class.
        /// </summary>
        public OtelAttribute()
        {
        }
    }
}