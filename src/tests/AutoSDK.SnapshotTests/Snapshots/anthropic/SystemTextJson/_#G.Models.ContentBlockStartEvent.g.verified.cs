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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ContentBlockStartEventTypeJsonConverter))]
        public global::G.ContentBlockStartEventType Type { get; set; } = global::G.ContentBlockStartEventType.ContentBlockStart;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_block")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ContentBlock2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ContentBlock2 ContentBlock { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockStartEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: content_block_start
        /// </param>
        /// <param name="index"></param>
        /// <param name="contentBlock"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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