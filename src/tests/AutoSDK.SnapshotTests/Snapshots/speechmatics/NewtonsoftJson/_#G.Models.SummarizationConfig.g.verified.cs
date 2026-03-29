//HintName: G.Models.SummarizationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for summarization.
    /// </summary>
    public sealed partial class SummarizationConfig
    {
        /// <summary>
        /// Choose from three options:<br/>
        /// - `conversational` - Best suited for dialogues involving multiple participants, such as calls, meetings or discussions. It focuses on summarizing key points of the conversation.<br/>
        /// - `informative` - Recommended for more structured information delivered by one or more people, making it ideal for videos, podcasts, lectures, and presentations.<br/>
        /// - `auto` - Automatically selects the most appropriate content type based on an analysis of the transcript.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public global::G.SummarizationConfigContentType? ContentType { get; set; }

        /// <summary>
        /// Determines the depth of the summary:<br/>
        /// - `brief` - Provides a succinct summary, condensing the content into just a few sentences.<br/>
        /// - `detailed` - Provide a longer, structured summary. For _conversational_ content, it includes key topics and a summary of the entire conversation. For _informative_ content, it logically divides the audio into sections and provides a summary for each.<br/>
        /// Default Value: brief
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_length")]
        public global::G.SummarizationConfigSummaryLength? SummaryLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_type")]
        public global::G.SummarizationConfigSummaryType? SummaryType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationConfig" /> class.
        /// </summary>
        /// <param name="contentType">
        /// Choose from three options:<br/>
        /// - `conversational` - Best suited for dialogues involving multiple participants, such as calls, meetings or discussions. It focuses on summarizing key points of the conversation.<br/>
        /// - `informative` - Recommended for more structured information delivered by one or more people, making it ideal for videos, podcasts, lectures, and presentations.<br/>
        /// - `auto` - Automatically selects the most appropriate content type based on an analysis of the transcript.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="summaryLength">
        /// Determines the depth of the summary:<br/>
        /// - `brief` - Provides a succinct summary, condensing the content into just a few sentences.<br/>
        /// - `detailed` - Provide a longer, structured summary. For _conversational_ content, it includes key topics and a summary of the entire conversation. For _informative_ content, it logically divides the audio into sections and provides a summary for each.<br/>
        /// Default Value: brief
        /// </param>
        /// <param name="summaryType"></param>
        public SummarizationConfig(
            global::G.SummarizationConfigContentType? contentType,
            global::G.SummarizationConfigSummaryLength? summaryLength,
            global::G.SummarizationConfigSummaryType? summaryType)
        {
            this.ContentType = contentType;
            this.SummaryLength = summaryLength;
            this.SummaryType = summaryType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationConfig" /> class.
        /// </summary>
        public SummarizationConfig()
        {
        }
    }
}