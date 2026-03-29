//HintName: G.Models.LanguageModelConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageModelConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LanguageModelConfigGranularityJsonConverter))]
        public global::G.LanguageModelConfigGranularity? Granularity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        public object? Sentiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toxicity")]
        public object? Toxicity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identify_speakers")]
        public bool? IdentifySpeakers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageModelConfig" /> class.
        /// </summary>
        /// <param name="granularity"></param>
        /// <param name="sentiment"></param>
        /// <param name="toxicity"></param>
        /// <param name="identifySpeakers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageModelConfig(
            global::G.LanguageModelConfigGranularity? granularity,
            object? sentiment,
            object? toxicity,
            bool? identifySpeakers)
        {
            this.Granularity = granularity;
            this.Sentiment = sentiment;
            this.Toxicity = toxicity;
            this.IdentifySpeakers = identifySpeakers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageModelConfig" /> class.
        /// </summary>
        public LanguageModelConfig()
        {
        }
    }
}