//HintName: G.Models.ContentBlockStartEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentBlockStartEvent
    {
        /// <summary>
        /// Default Value: content_block_start
        /// </summary>
        /// <default>global::G.ContentBlockStartEventType.ContentBlockStart</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ContentBlockStartEventType Type { get; set; } = global::G.ContentBlockStartEventType.ContentBlockStart;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_block", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ContentBlock2 ContentBlock { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockStartEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: content_block_start
        /// </param>
        /// <param name="index"></param>
        /// <param name="contentBlock"></param>
        public ContentBlockStartEvent(
            int index,
            global::G.ContentBlock2 contentBlock,
            global::G.ContentBlockStartEventType type = global::G.ContentBlockStartEventType.ContentBlockStart)
        {
            this.Index = index;
            this.ContentBlock = contentBlock;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockStartEvent" /> class.
        /// </summary>
        public ContentBlockStartEvent()
        {
        }
    }
}