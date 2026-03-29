//HintName: G.Models.ResearchConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the Reka Research model (reka-flash-research). Controls web search and parallel thinking.
    /// </summary>
    public sealed partial class ResearchConfig
    {
        /// <summary>
        /// Web search configuration for the Research model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_search")]
        public global::G.WebSearchConfig? WebSearch { get; set; }

        /// <summary>
        /// Controls computational intensity for the Research model. Cannot be used with streaming.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_thinking")]
        public global::G.ParallelThinkingConfig? ParallelThinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchConfig" /> class.
        /// </summary>
        /// <param name="webSearch">
        /// Web search configuration for the Research model.
        /// </param>
        /// <param name="parallelThinking">
        /// Controls computational intensity for the Research model. Cannot be used with streaming.
        /// </param>
        public ResearchConfig(
            global::G.WebSearchConfig? webSearch,
            global::G.ParallelThinkingConfig? parallelThinking)
        {
            this.WebSearch = webSearch;
            this.ParallelThinking = parallelThinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchConfig" /> class.
        /// </summary>
        public ResearchConfig()
        {
        }
    }
}