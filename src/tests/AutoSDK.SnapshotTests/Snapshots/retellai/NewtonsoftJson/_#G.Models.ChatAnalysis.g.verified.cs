//HintName: G.Models.ChatAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatAnalysis
    {
        /// <summary>
        /// A high level summary of the chat.<br/>
        /// Example: The agent messages user to ask question about his purchase inquiry. The agent asked several questions regarding his preference and asked if user would like to book an appointment. The user happily agreed and scheduled an appointment next Monday 10am.
        /// </summary>
        /// <example>The agent messages user to ask question about his purchase inquiry. The agent asked several questions regarding his preference and asked if user would like to book an appointment. The user happily agreed and scheduled an appointment next Monday 10am.</example>
        [global::Newtonsoft.Json.JsonProperty("chat_summary")]
        public string? ChatSummary { get; set; }

        /// <summary>
        /// Sentiment of the user in the chat.<br/>
        /// Example: Positive
        /// </summary>
        /// <example>Positive</example>
        [global::Newtonsoft.Json.JsonProperty("user_sentiment")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatAnalysisUserSentimentJsonConverter))]
        public global::G.ChatAnalysisUserSentiment? UserSentiment { get; set; }

        /// <summary>
        /// Whether the agent seems to have a successful chat with the user, where the agent finishes the task, and the call was complete without being cutoff.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("chat_successful")]
        public bool? ChatSuccessful { get; set; }

        /// <summary>
        /// Custom analysis data that was extracted based on the schema defined in chat agent post chat analysis data. Can be empty if nothing is specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_analysis_data")]
        public object? CustomAnalysisData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAnalysis" /> class.
        /// </summary>
        /// <param name="chatSummary">
        /// A high level summary of the chat.<br/>
        /// Example: The agent messages user to ask question about his purchase inquiry. The agent asked several questions regarding his preference and asked if user would like to book an appointment. The user happily agreed and scheduled an appointment next Monday 10am.
        /// </param>
        /// <param name="userSentiment">
        /// Sentiment of the user in the chat.<br/>
        /// Example: Positive
        /// </param>
        /// <param name="chatSuccessful">
        /// Whether the agent seems to have a successful chat with the user, where the agent finishes the task, and the call was complete without being cutoff.<br/>
        /// Example: true
        /// </param>
        /// <param name="customAnalysisData">
        /// Custom analysis data that was extracted based on the schema defined in chat agent post chat analysis data. Can be empty if nothing is specified.
        /// </param>
        public ChatAnalysis(
            string? chatSummary,
            global::G.ChatAnalysisUserSentiment? userSentiment,
            bool? chatSuccessful,
            object? customAnalysisData)
        {
            this.ChatSummary = chatSummary;
            this.UserSentiment = userSentiment;
            this.ChatSuccessful = chatSuccessful;
            this.CustomAnalysisData = customAnalysisData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAnalysis" /> class.
        /// </summary>
        public ChatAnalysis()
        {
        }
    }
}