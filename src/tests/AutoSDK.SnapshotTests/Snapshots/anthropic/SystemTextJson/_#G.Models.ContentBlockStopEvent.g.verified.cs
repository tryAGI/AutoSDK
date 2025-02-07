//HintName: G.Models.ContentBlockStopEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentBlockStopEvent
    {
        /// <summary>
        /// Default Value: content_block_stop
        /// </summary>
        /// <default>global::G.ContentBlockStopEventType.ContentBlockStop</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ContentBlockStopEventTypeJsonConverter))]
        public global::G.ContentBlockStopEventType Type { get; set; } = global::G.ContentBlockStopEventType.ContentBlockStop;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockStopEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: content_block_stop
        /// </param>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentBlockStopEvent(
            int index,
            global::G.ContentBlockStopEventType type = global::G.ContentBlockStopEventType.ContentBlockStop)
        {
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockStopEvent" /> class.
        /// </summary>
        public ContentBlockStopEvent()
        {
        }
    }
}