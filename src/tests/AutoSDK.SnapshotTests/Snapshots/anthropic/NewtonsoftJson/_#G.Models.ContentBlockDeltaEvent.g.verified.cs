//HintName: G.Models.ContentBlockDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentBlockDeltaEvent
    {
        /// <summary>
        /// Default Value: content_block_delta
        /// </summary>
        /// <default>global::G.ContentBlockDeltaEventType.ContentBlockDelta</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ContentBlockDeltaEventType Type { get; set; } = global::G.ContentBlockDeltaEventType.ContentBlockDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Delta2 Delta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: content_block_delta
        /// </param>
        /// <param name="index"></param>
        /// <param name="delta"></param>
        public ContentBlockDeltaEvent(
            int index,
            global::G.Delta2 delta,
            global::G.ContentBlockDeltaEventType type = global::G.ContentBlockDeltaEventType.ContentBlockDelta)
        {
            this.Index = index;
            this.Delta = delta;
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