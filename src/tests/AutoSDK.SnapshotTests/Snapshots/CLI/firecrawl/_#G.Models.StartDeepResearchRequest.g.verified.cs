//HintName: G.Models.StartDeepResearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartDeepResearchRequest
    {
        /// <summary>
        /// The query to research
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Maximum depth of research iterations<br/>
        /// Default Value: 7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDepth")]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// Time limit in seconds<br/>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeLimit")]
        public int? TimeLimit { get; set; }

        /// <summary>
        /// Maximum number of URLs to analyze<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxUrls")]
        public int? MaxUrls { get; set; }

        /// <summary>
        /// The prompt to use for the final analysis. Useful to format the final analysis markdown in a specific way.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysisPrompt")]
        public string? AnalysisPrompt { get; set; }

        /// <summary>
        /// The system prompt to use for the research agent. Useful to steer the research agent to a specific direction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formats")]
        public global::System.Collections.Generic.IList<global::G.StartDeepResearchRequestFormat>? Formats { get; set; }

        /// <summary>
        /// Options for JSON output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jsonOptions")]
        public global::G.StartDeepResearchRequestJsonOptions? JsonOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeepResearchRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The query to research
        /// </param>
        /// <param name="maxDepth">
        /// Maximum depth of research iterations<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="timeLimit">
        /// Time limit in seconds<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="maxUrls">
        /// Maximum number of URLs to analyze<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="analysisPrompt">
        /// The prompt to use for the final analysis. Useful to format the final analysis markdown in a specific way.
        /// </param>
        /// <param name="systemPrompt">
        /// The system prompt to use for the research agent. Useful to steer the research agent to a specific direction.
        /// </param>
        /// <param name="formats"></param>
        /// <param name="jsonOptions">
        /// Options for JSON output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartDeepResearchRequest(
            string query,
            int? maxDepth,
            int? timeLimit,
            int? maxUrls,
            string? analysisPrompt,
            string? systemPrompt,
            global::System.Collections.Generic.IList<global::G.StartDeepResearchRequestFormat>? formats,
            global::G.StartDeepResearchRequestJsonOptions? jsonOptions)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.MaxDepth = maxDepth;
            this.TimeLimit = timeLimit;
            this.MaxUrls = maxUrls;
            this.AnalysisPrompt = analysisPrompt;
            this.SystemPrompt = systemPrompt;
            this.Formats = formats;
            this.JsonOptions = jsonOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeepResearchRequest" /> class.
        /// </summary>
        public StartDeepResearchRequest()
        {
        }
    }
}