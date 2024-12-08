//HintName: G.Models.BetaContentBlockDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContentBlockDeltaEvent
    {
        /// <summary>
        /// Default Value: content_block_delta
        /// </summary>
        /// <default>global::G.BetaContentBlockDeltaEventType.ContentBlockDelta</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaContentBlockDeltaEventType Type { get; set; } = global::G.BetaContentBlockDeltaEventType.ContentBlockDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Delta Delta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: content_block_delta
        /// </param>
        /// <param name="index"></param>
        /// <param name="delta"></param>
        public BetaContentBlockDeltaEvent(
            int index,
            global::G.Delta delta,
            global::G.BetaContentBlockDeltaEventType type = global::G.BetaContentBlockDeltaEventType.ContentBlockDelta)
        {
            this.Index = index;
            this.Delta = delta;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockDeltaEvent" /> class.
        /// </summary>
        public BetaContentBlockDeltaEvent()
        {
        }
    }
}