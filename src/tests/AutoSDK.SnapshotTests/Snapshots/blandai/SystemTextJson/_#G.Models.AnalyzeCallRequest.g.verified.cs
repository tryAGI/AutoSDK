//HintName: G.Models.AnalyzeCallRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyzeCallRequest
    {
        /// <summary>
        /// Overall purpose of the call, providing context for AI analysis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Goal { get; set; }

        /// <summary>
        /// Array of question-answer pairs. Each entry is [question_text, expected_type].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Questions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeCallRequest" /> class.
        /// </summary>
        /// <param name="goal">
        /// Overall purpose of the call, providing context for AI analysis
        /// </param>
        /// <param name="questions">
        /// Array of question-answer pairs. Each entry is [question_text, expected_type].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeCallRequest(
            string goal,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> questions)
        {
            this.Goal = goal ?? throw new global::System.ArgumentNullException(nameof(goal));
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeCallRequest" /> class.
        /// </summary>
        public AnalyzeCallRequest()
        {
        }
    }
}