//HintName: G.Models.CopilotUsageMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary of Copilot usage.
    /// </summary>
    public sealed partial class CopilotUsageMetrics
    {
        /// <summary>
        /// The date for which the usage metrics are reported, in `YYYY-MM-DD` format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("day", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Day { get; set; } = default!;

        /// <summary>
        /// The total number of Copilot code completion suggestions shown to users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_suggestions_count")]
        public int TotalSuggestionsCount { get; set; }

        /// <summary>
        /// The total number of Copilot code completion suggestions accepted by users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_acceptances_count")]
        public int TotalAcceptancesCount { get; set; }

        /// <summary>
        /// The total number of lines of code completions suggested by Copilot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_lines_suggested")]
        public int TotalLinesSuggested { get; set; }

        /// <summary>
        /// The total number of lines of code completions accepted by users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_lines_accepted")]
        public int TotalLinesAccepted { get; set; }

        /// <summary>
        /// The total number of users who were shown Copilot code completion suggestions during the day specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_active_users")]
        public int TotalActiveUsers { get; set; }

        /// <summary>
        /// The total instances of users who accepted code suggested by Copilot Chat in the IDE (panel and inline).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_chat_acceptances")]
        public int TotalChatAcceptances { get; set; }

        /// <summary>
        /// The total number of chat turns (prompt and response pairs) sent between users and Copilot Chat in the IDE.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_chat_turns")]
        public int TotalChatTurns { get; set; }

        /// <summary>
        /// The total number of users who interacted with Copilot Chat in the IDE during the day specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_active_chat_users")]
        public int TotalActiveChatUsers { get; set; }

        /// <summary>
        /// Breakdown of Copilot code completions usage by language and editor
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("breakdown", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CopilotUsageMetricsBreakdown>? Breakdown { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}