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
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BlockDelta Delta { get; set; } = default!;

        /// <summary>
        /// The index of the content block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The type of a streaming event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageStreamEventType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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