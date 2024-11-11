//HintName: G.Models.CopilotUsageMetricsBreakdownItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Breakdown of Copilot usage by editor for this language
    /// </summary>
    public sealed partial class CopilotUsageMetricsBreakdownItem
    {
        /// <summary>
        /// The language in which Copilot suggestions were shown to users in the specified editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The editor in which Copilot suggestions were shown to users for the specified language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editor")]
        public string? Editor { get; set; }

        /// <summary>
        /// The number of Copilot suggestions shown to users in the editor specified during the day specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestions_count")]
        public int? SuggestionsCount { get; set; }

        /// <summary>
        /// The number of Copilot suggestions accepted by users in the editor specified during the day specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acceptances_count")]
        public int? AcceptancesCount { get; set; }

        /// <summary>
        /// The number of lines of code suggested by Copilot in the editor specified during the day specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines_suggested")]
        public int? LinesSuggested { get; set; }

        /// <summary>
        /// The number of lines of code accepted by users in the editor specified during the day specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines_accepted")]
        public int? LinesAccepted { get; set; }

        /// <summary>
        /// The number of users who were shown Copilot completion suggestions in the editor specified during the day specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_users")]
        public int? ActiveUsers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotUsageMetricsBreakdownItem" /> class.
        /// </summary>
        /// <param name="language">
        /// The language in which Copilot suggestions were shown to users in the specified editor.
        /// </param>
        /// <param name="editor">
        /// The editor in which Copilot suggestions were shown to users for the specified language.
        /// </param>
        /// <param name="suggestionsCount">
        /// The number of Copilot suggestions shown to users in the editor specified during the day specified.
        /// </param>
        /// <param name="acceptancesCount">
        /// The number of Copilot suggestions accepted by users in the editor specified during the day specified.
        /// </param>
        /// <param name="linesSuggested">
        /// The number of lines of code suggested by Copilot in the editor specified during the day specified.
        /// </param>
        /// <param name="linesAccepted">
        /// The number of lines of code accepted by users in the editor specified during the day specified.
        /// </param>
        /// <param name="activeUsers">
        /// The number of users who were shown Copilot completion suggestions in the editor specified during the day specified.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotUsageMetricsBreakdownItem(
            string? language,
            string? editor,
            int? suggestionsCount,
            int? acceptancesCount,
            int? linesSuggested,
            int? linesAccepted,
            int? activeUsers)
        {
            this.Language = language;
            this.Editor = editor;
            this.SuggestionsCount = suggestionsCount;
            this.AcceptancesCount = acceptancesCount;
            this.LinesSuggested = linesSuggested;
            this.LinesAccepted = linesAccepted;
            this.ActiveUsers = activeUsers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotUsageMetricsBreakdownItem" /> class.
        /// </summary>
        public CopilotUsageMetricsBreakdownItem()
        {
        }
    }
}