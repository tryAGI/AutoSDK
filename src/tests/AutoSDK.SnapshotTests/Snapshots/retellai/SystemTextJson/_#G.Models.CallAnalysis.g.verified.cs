//HintName: G.Models.CallAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallAnalysis
    {
        /// <summary>
        /// A high level summary of the call.<br/>
        /// Example: The agent called the user to ask question about his purchase inquiry. The agent asked several questions regarding his preference and asked if user would like to book an appointment. The user happily agreed and scheduled an appointment next Monday 10am.
        /// </summary>
        /// <example>The agent called the user to ask question about his purchase inquiry. The agent asked several questions regarding his preference and asked if user would like to book an appointment. The user happily agreed and scheduled an appointment next Monday 10am.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_summary")]
        public string? CallSummary { get; set; }

        /// <summary>
        /// Whether the call is entered voicemail.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_voicemail")]
        public bool? InVoicemail { get; set; }

        /// <summary>
        /// Sentiment of the user in the call.<br/>
        /// Example: Positive
        /// </summary>
        /// <example>Positive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CallAnalysisUserSentimentJsonConverter))]
        public global::G.CallAnalysisUserSentiment? UserSentiment { get; set; }

        /// <summary>
        /// Whether the agent seems to have a successful call with the user, where the agent finishes the task, and the call was complete without being cutoff.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_successful")]
        public bool? CallSuccessful { get; set; }

        /// <summary>
        /// Custom analysis data that was extracted based on the schema defined in agent post call analysis data. Can be empty if nothing is specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_analysis_data")]
        public object? CustomAnalysisData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallAnalysis" /> class.
        /// </summary>
        /// <param name="callSummary">
        /// A high level summary of the call.<br/>
        /// Example: The agent called the user to ask question about his purchase inquiry. The agent asked several questions regarding his preference and asked if user would like to book an appointment. The user happily agreed and scheduled an appointment next Monday 10am.
        /// </param>
        /// <param name="inVoicemail">
        /// Whether the call is entered voicemail.<br/>
        /// Example: false
        /// </param>
        /// <param name="userSentiment">
        /// Sentiment of the user in the call.<br/>
        /// Example: Positive
        /// </param>
        /// <param name="callSuccessful">
        /// Whether the agent seems to have a successful call with the user, where the agent finishes the task, and the call was complete without being cutoff.<br/>
        /// Example: true
        /// </param>
        /// <param name="customAnalysisData">
        /// Custom analysis data that was extracted based on the schema defined in agent post call analysis data. Can be empty if nothing is specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallAnalysis(
            string? callSummary,
            bool? inVoicemail,
            global::G.CallAnalysisUserSentiment? userSentiment,
            bool? callSuccessful,
            object? customAnalysisData)
        {
            this.CallSummary = callSummary;
            this.InVoicemail = inVoicemail;
            this.UserSentiment = userSentiment;
            this.CallSuccessful = callSuccessful;
            this.CustomAnalysisData = customAnalysisData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallAnalysis" /> class.
        /// </summary>
        public CallAnalysis()
        {
        }
    }
}