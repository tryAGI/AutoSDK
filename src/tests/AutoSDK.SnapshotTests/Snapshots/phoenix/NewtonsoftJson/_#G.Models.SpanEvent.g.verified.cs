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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// When the event occurred (must be timezone-aware)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// Event attributes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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