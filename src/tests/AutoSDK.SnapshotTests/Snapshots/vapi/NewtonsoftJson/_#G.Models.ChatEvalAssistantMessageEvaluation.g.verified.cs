//HintName: G.Models.ChatEvalAssistantMessageEvaluation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEvalAssistantMessageEvaluation
    {
        /// <summary>
        /// This is the role of the message author.<br/>
        /// For an assistant message evaluation, the role is always 'assistant'<br/>
        /// @default 'assistant'<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::G.ChatEvalAssistantMessageEvaluationRole.Assistant</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatEvalAssistantMessageEvaluationRole Role { get; set; } = global::G.ChatEvalAssistantMessageEvaluationRole.Assistant;

        /// <summary>
        /// This is the judge plan that instructs how to evaluate the assistant message.<br/>
        /// The assistant message can be evaluated against fixed content (exact match or RegEx) or with an LLM-as-judge by defining the evaluation criteria in a prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("judgePlan", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.AssistantMessageJudgePlanExact, global::G.AssistantMessageJudgePlanRegex, global::G.AssistantMessageJudgePlanAI> JudgePlan { get; set; } = default!;

        /// <summary>
        /// This is the plan for how the overall evaluation will proceed after the assistant message is evaluated.<br/>
        /// This lets you configure whether to stop the evaluation if this message fails, and whether to override any content for future turns
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("continuePlan")]
        public global::G.AssistantMessageEvaluationContinuePlan? ContinuePlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalAssistantMessageEvaluation" /> class.
        /// </summary>
        /// <param name="judgePlan">
        /// This is the judge plan that instructs how to evaluate the assistant message.<br/>
        /// The assistant message can be evaluated against fixed content (exact match or RegEx) or with an LLM-as-judge by defining the evaluation criteria in a prompt.
        /// </param>
        /// <param name="continuePlan">
        /// This is the plan for how the overall evaluation will proceed after the assistant message is evaluated.<br/>
        /// This lets you configure whether to stop the evaluation if this message fails, and whether to override any content for future turns
        /// </param>
        /// <param name="role">
        /// This is the role of the message author.<br/>
        /// For an assistant message evaluation, the role is always 'assistant'<br/>
        /// @default 'assistant'<br/>
        /// Default Value: assistant
        /// </param>
        public ChatEvalAssistantMessageEvaluation(
            global::G.OneOf<global::G.AssistantMessageJudgePlanExact, global::G.AssistantMessageJudgePlanRegex, global::G.AssistantMessageJudgePlanAI> judgePlan,
            global::G.AssistantMessageEvaluationContinuePlan? continuePlan,
            global::G.ChatEvalAssistantMessageEvaluationRole role = global::G.ChatEvalAssistantMessageEvaluationRole.Assistant)
        {
            this.Role = role;
            this.JudgePlan = judgePlan;
            this.ContinuePlan = continuePlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalAssistantMessageEvaluation" /> class.
        /// </summary>
        public ChatEvalAssistantMessageEvaluation()
        {
        }
    }
}