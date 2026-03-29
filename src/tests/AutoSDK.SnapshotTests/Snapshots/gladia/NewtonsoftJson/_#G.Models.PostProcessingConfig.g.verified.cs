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
        [global::Newtonsoft.Json.JsonProperty("summarization")]
        public bool? Summarization { get; set; }

        /// <summary>
        /// Summarization configuration, if `summarization` is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summarization_config")]
        public global::G.SummarizationConfigDTO? SummarizationConfig { get; set; }

        /// <summary>
        /// If true, generates chapters for the whole transcription.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapterization")]
        public bool? Chapterization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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