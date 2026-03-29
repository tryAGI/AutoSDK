//HintName: G.Models.VoicemailDetectionCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicemailDetectionCost
    {
        /// <summary>
        /// This is the type of cost, always 'voicemail-detection' for this class.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoicemailDetectionCostTypeJsonConverter))]
        public global::G.VoicemailDetectionCostType Type { get; set; }

        /// <summary>
        /// This is the model that was used to perform the analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Model { get; set; }

        /// <summary>
        /// This is the provider that was used to detect the voicemail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoicemailDetectionCostProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoicemailDetectionCostProvider Provider { get; set; }

        /// <summary>
        /// This is the number of prompt text tokens used in the voicemail detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTextTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTextTokens { get; set; }

        /// <summary>
        /// This is the number of prompt audio tokens used in the voicemail detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptAudioTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptAudioTokens { get; set; }

        /// <summary>
        /// This is the number of completion text tokens used in the voicemail detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionTextTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTextTokens { get; set; }

        /// <summary>
        /// This is the number of completion audio tokens used in the voicemail detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionAudioTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionAudioTokens { get; set; }

        /// <summary>
        /// This is the cost of the component in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailDetectionCost" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the model that was used to perform the analysis.
        /// </param>
        /// <param name="provider">
        /// This is the provider that was used to detect the voicemail.
        /// </param>
        /// <param name="promptTextTokens">
        /// This is the number of prompt text tokens used in the voicemail detection.
        /// </param>
        /// <param name="promptAudioTokens">
        /// This is the number of prompt audio tokens used in the voicemail detection.
        /// </param>
        /// <param name="completionTextTokens">
        /// This is the number of completion text tokens used in the voicemail detection.
        /// </param>
        /// <param name="completionAudioTokens">
        /// This is the number of completion audio tokens used in the voicemail detection.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the component in USD.
        /// </param>
        /// <param name="type">
        /// This is the type of cost, always 'voicemail-detection' for this class.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicemailDetectionCost(
            object model,
            global::G.VoicemailDetectionCostProvider provider,
            double promptTextTokens,
            double promptAudioTokens,
            double completionTextTokens,
            double completionAudioTokens,
            double cost,
            global::G.VoicemailDetectionCostType type)
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.PromptTextTokens = promptTextTokens;
            this.PromptAudioTokens = promptAudioTokens;
            this.CompletionTextTokens = completionTextTokens;
            this.CompletionAudioTokens = completionAudioTokens;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailDetectionCost" /> class.
        /// </summary>
        public VoicemailDetectionCost()
        {
        }
    }
}