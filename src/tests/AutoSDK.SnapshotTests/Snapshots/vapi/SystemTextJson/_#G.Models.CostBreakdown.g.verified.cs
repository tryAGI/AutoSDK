//HintName: G.Models.CostBreakdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CostBreakdown
    {
        /// <summary>
        /// This is the cost of the transport provider, like Twilio or Vonage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        public double? Transport { get; set; }

        /// <summary>
        /// This is the cost of the speech-to-text service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt")]
        public double? Stt { get; set; }

        /// <summary>
        /// This is the cost of the language model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public double? Llm { get; set; }

        /// <summary>
        /// This is the cost of the text-to-speech service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public double? Tts { get; set; }

        /// <summary>
        /// This is the cost of Vapi.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vapi")]
        public double? Vapi { get; set; }

        /// <summary>
        /// This is the cost of chat interactions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        public double? Chat { get; set; }

        /// <summary>
        /// This is the total cost of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public double? Total { get; set; }

        /// <summary>
        /// This is the LLM prompt tokens used for the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmPromptTokens")]
        public double? LlmPromptTokens { get; set; }

        /// <summary>
        /// This is the LLM completion tokens used for the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmCompletionTokens")]
        public double? LlmCompletionTokens { get; set; }

        /// <summary>
        /// This is the LLM cached prompt tokens used for the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmCachedPromptTokens")]
        public double? LlmCachedPromptTokens { get; set; }

        /// <summary>
        /// This is the TTS characters used for the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttsCharacters")]
        public double? TtsCharacters { get; set; }

        /// <summary>
        /// This is the cost of the analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysisCostBreakdown")]
        public global::G.AnalysisCostBreakdown? AnalysisCostBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostBreakdown" /> class.
        /// </summary>
        /// <param name="transport">
        /// This is the cost of the transport provider, like Twilio or Vonage.
        /// </param>
        /// <param name="stt">
        /// This is the cost of the speech-to-text service.
        /// </param>
        /// <param name="llm">
        /// This is the cost of the language model.
        /// </param>
        /// <param name="tts">
        /// This is the cost of the text-to-speech service.
        /// </param>
        /// <param name="vapi">
        /// This is the cost of Vapi.
        /// </param>
        /// <param name="chat">
        /// This is the cost of chat interactions.
        /// </param>
        /// <param name="total">
        /// This is the total cost of the call.
        /// </param>
        /// <param name="llmPromptTokens">
        /// This is the LLM prompt tokens used for the call.
        /// </param>
        /// <param name="llmCompletionTokens">
        /// This is the LLM completion tokens used for the call.
        /// </param>
        /// <param name="llmCachedPromptTokens">
        /// This is the LLM cached prompt tokens used for the call.
        /// </param>
        /// <param name="ttsCharacters">
        /// This is the TTS characters used for the call.
        /// </param>
        /// <param name="analysisCostBreakdown">
        /// This is the cost of the analysis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostBreakdown(
            double? transport,
            double? stt,
            double? llm,
            double? tts,
            double? vapi,
            double? chat,
            double? total,
            double? llmPromptTokens,
            double? llmCompletionTokens,
            double? llmCachedPromptTokens,
            double? ttsCharacters,
            global::G.AnalysisCostBreakdown? analysisCostBreakdown)
        {
            this.Transport = transport;
            this.Stt = stt;
            this.Llm = llm;
            this.Tts = tts;
            this.Vapi = vapi;
            this.Chat = chat;
            this.Total = total;
            this.LlmPromptTokens = llmPromptTokens;
            this.LlmCompletionTokens = llmCompletionTokens;
            this.LlmCachedPromptTokens = llmCachedPromptTokens;
            this.TtsCharacters = ttsCharacters;
            this.AnalysisCostBreakdown = analysisCostBreakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostBreakdown" /> class.
        /// </summary>
        public CostBreakdown()
        {
        }
    }
}