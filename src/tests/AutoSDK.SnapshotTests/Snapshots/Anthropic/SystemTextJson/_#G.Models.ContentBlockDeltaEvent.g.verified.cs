//HintName: G.Models.ContentBlockDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A delta event in a streaming content block.
    /// </summary>
    public sealed partial class ContentBlockDeltaEvent
    {
        /// <summary>
        /// A delta in a streaming message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BlockDeltaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BlockDelta Delta { get; set; }

        /// <summary>
        /// The index of the content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The type of a streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageStreamEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageStreamEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta">
        /// A delta in a streaming message.
        /// </param>
        /// <param name="index">
        /// The index of the content block.
        /// </param>
        /// <param name="type">
        /// The type of a streaming event.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ContentBlockDeltaEvent(
            global::G.BlockDelta delta,
            int index,
            global::G.MessageStreamEventType type)
        {
            this.Delta = delta;
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockDeltaEvent" /> class.
        /// </summary>
        public ContentBlockDeltaEvent()
        {
        }
    }
}