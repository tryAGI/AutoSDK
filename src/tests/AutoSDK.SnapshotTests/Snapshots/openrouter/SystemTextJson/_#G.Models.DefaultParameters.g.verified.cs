//HintName: G.Models.DefaultParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default parameters for this model
    /// </summary>
    public sealed partial class DefaultParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_penalty")]
        public double? RepetitionPenalty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultParameters" /> class.
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="topK"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="repetitionPenalty"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DefaultParameters(
            double? temperature,
            double? topP,
            int? topK,
            double? frequencyPenalty,
            double? presencePenalty,
            double? repetitionPenalty)
        {
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.RepetitionPenalty = repetitionPenalty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultParameters" /> class.
        /// </summary>
        public DefaultParameters()
        {
        }
    }
}