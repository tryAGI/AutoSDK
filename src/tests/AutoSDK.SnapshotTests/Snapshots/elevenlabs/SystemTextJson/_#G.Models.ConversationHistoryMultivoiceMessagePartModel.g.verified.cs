//HintName: G.Models.ConversationHistoryMultivoiceMessagePartModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a single voice part of a multi-voice message.
    /// </summary>
    public sealed partial class ConversationHistoryMultivoiceMessagePartModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_label")]
        public string? VoiceLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_in_call_secs")]
        public int? TimeInCallSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMultivoiceMessagePartModel" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="voiceLabel"></param>
        /// <param name="timeInCallSecs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryMultivoiceMessagePartModel(
            string text,
            string? voiceLabel,
            int? timeInCallSecs)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.VoiceLabel = voiceLabel;
            this.TimeInCallSecs = timeInCallSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMultivoiceMessagePartModel" /> class.
        /// </summary>
        public ConversationHistoryMultivoiceMessagePartModel()
        {
        }
    }
}