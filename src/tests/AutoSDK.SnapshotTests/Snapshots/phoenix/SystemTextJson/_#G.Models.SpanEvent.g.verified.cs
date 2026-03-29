//HintName: G.Models.SpanEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanEvent
    {
        /// <summary>
        /// Name of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// When the event occurred (must be timezone-aware)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Event attributes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanEvent" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the event
        /// </param>
        /// <param name="timestamp">
        /// When the event occurred (must be timezone-aware)
        /// </param>
        /// <param name="attributes">
        /// Event attributes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpanEvent(
            string name,
            global::System.DateTime timestamp,
            object? attributes)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Timestamp = timestamp;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanEvent" /> class.
        /// </summary>
        public SpanEvent()
        {
        }
    }
}