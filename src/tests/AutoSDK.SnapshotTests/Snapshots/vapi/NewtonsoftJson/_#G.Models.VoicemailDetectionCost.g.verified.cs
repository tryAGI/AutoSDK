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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.VoicemailDetectionCostType Type { get; set; }

        /// <summary>
        /// This is the model that was used to perform the analysis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public object Model { get; set; } = default!;

        /// <summary>
        /// This is the provider that was used to detect the voicemail.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VoicemailDetectionCostProvider Provider { get; set; } = default!;

        /// <summary>
        /// This is the number of prompt text tokens used in the voicemail detection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptTextTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTextTokens { get; set; } = default!;

        /// <summary>
        /// This is the number of prompt audio tokens used in the voicemail detection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptAudioTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptAudioTokens { get; set; } = default!;

        /// <summary>
        /// This is the number of completion text tokens used in the voicemail detection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completionTextTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTextTokens { get; set; } = default!;

        /// <summary>
        /// This is the number of completion audio tokens used in the voicemail detection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completionAudioTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionAudioTokens { get; set; } = default!;

        /// <summary>
        /// This is the cost of the component in USD.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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