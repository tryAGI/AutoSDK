//HintName: G.Models.MessageDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageDeltaStopReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageDeltaStopReason? StopReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? StopSequence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDelta" /> class.
        /// </summary>
        /// <param name="stopReason"></param>
        /// <param name="stopSequence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDelta(
            global::G.MessageDeltaStopReason? stopReason,
            string? stopSequence)
        {
            this.StopReason = stopReason;
            this.StopSequence = stopSequence ?? throw new global::System.ArgumentNullException(nameof(stopSequence));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDelta" /> class.
        /// </summary>
        public MessageDelta()
        {
        }
    }
}