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
        [global::Newtonsoft.Json.JsonProperty("goal", Required = global::Newtonsoft.Json.Required.Always)]
        public string Goal { get; set; } = default!;

        /// <summary>
        /// Array of question-answer pairs. Each entry is [question_text, expected_type].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("questions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Questions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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