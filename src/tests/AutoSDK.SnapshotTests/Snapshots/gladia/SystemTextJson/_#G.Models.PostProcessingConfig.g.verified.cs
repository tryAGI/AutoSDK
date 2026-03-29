//HintName: G.Models.PostProcessingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostProcessingConfig
    {
        /// <summary>
        /// If true, generates summarization for the whole transcription.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization")]
        public bool? Summarization { get; set; }

        /// <summary>
        /// Summarization configuration, if `summarization` is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization_config")]
        public global::G.SummarizationConfigDTO? SummarizationConfig { get; set; }

        /// <summary>
        /// If true, generates chapters for the whole transcription.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapterization")]
        public bool? Chapterization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostProcessingConfig" /> class.
        /// </summary>
        /// <param name="summarization">
        /// If true, generates summarization for the whole transcription.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="summarizationConfig">
        /// Summarization configuration, if `summarization` is enabled
        /// </param>
        /// <param name="chapterization">
        /// If true, generates chapters for the whole transcription.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostProcessingConfig(
            bool? summarization,
            global::G.SummarizationConfigDTO? summarizationConfig,
            bool? chapterization)
        {
            this.Summarization = summarization;
            this.SummarizationConfig = summarizationConfig;
            this.Chapterization = chapterization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostProcessingConfig" /> class.
        /// </summary>
        public PostProcessingConfig()
        {
        }
    }
}