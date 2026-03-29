//HintName: G.Models.SpanAttributes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Human-identifying attributes of the span, such as name, type, etc.
    /// </summary>
    public sealed partial class SpanAttributes
    {
        /// <summary>
        /// Name of the span, for display purposes only
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Type of the span, for display purposes only
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SpanType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanAttributes" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the span, for display purposes only
        /// </param>
        /// <param name="type">
        /// Type of the span, for display purposes only
        /// </param>
        public SpanAttributes(
            string? name,
            global::G.SpanType? type)
        {
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanAttributes" /> class.
        /// </summary>
        public SpanAttributes()
        {
        }
    }
}