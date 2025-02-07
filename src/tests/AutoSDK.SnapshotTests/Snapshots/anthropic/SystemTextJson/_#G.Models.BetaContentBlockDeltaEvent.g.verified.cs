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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaContentBlockDeltaEventTypeJsonConverter))]
        public global::G.BetaContentBlockDeltaEventType Type { get; set; } = global::G.BetaContentBlockDeltaEventType.ContentBlockDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeltaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Delta Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: content_block_delta
        /// </param>
        /// <param name="index"></param>
        /// <param name="delta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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