//HintName: G.Models.BetaContentBlockStartEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContentBlockStartEvent
    {
        /// <summary>
        /// Default Value: content_block_start
        /// </summary>
        /// <default>global::G.BetaContentBlockStartEventType.ContentBlockStart</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaContentBlockStartEventType Type { get; set; } = global::G.BetaContentBlockStartEventType.ContentBlockStart;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_block", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ContentBlock ContentBlock { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockStartEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: content_block_start
        /// </param>
        /// <param name="index"></param>
        /// <param name="contentBlock"></param>
        public BetaContentBlockStartEvent(
            int index,
            global::G.ContentBlock contentBlock,
            global::G.BetaContentBlockStartEventType type = global::G.BetaContentBlockStartEventType.ContentBlockStart)
        {
            this.Index = index;
            this.ContentBlock = contentBlock;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockStartEvent" /> class.
        /// </summary>
        public BetaContentBlockStartEvent()
        {
        }
    }
}