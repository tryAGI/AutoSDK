//HintName: G.Models.ChatEvalToolResponseMessageEvaluation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEvalToolResponseMessageEvaluation
    {
        /// <summary>
        /// This is the role of the message author.<br/>
        /// For a tool response message evaluation, the role is always 'tool'<br/>
        /// @default 'tool'<br/>
        /// Default Value: tool
        /// </summary>
        /// <default>global::G.ChatEvalToolResponseMessageEvaluationRole.Tool</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatEvalToolResponseMessageEvaluationRoleJsonConverter))]
        public global::G.ChatEvalToolResponseMessageEvaluationRole Role { get; set; } = global::G.ChatEvalToolResponseMessageEvaluationRole.Tool;

        /// <summary>
        /// This is the judge plan that instructs how to evaluate the tool response message.<br/>
        /// The tool response message can be evaluated with an LLM-as-judge by defining the evaluation criteria in a prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("judgePlan", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AssistantMessageJudgePlanAI JudgePlan { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalToolResponseMessageEvaluation" /> class.
        /// </summary>
        /// <param name="judgePlan">
        /// This is the judge plan that instructs how to evaluate the tool response message.<br/>
        /// The tool response message can be evaluated with an LLM-as-judge by defining the evaluation criteria in a prompt.
        /// </param>
        /// <param name="role">
        /// This is the role of the message author.<br/>
        /// For a tool response message evaluation, the role is always 'tool'<br/>
        /// @default 'tool'<br/>
        /// Default Value: tool
        /// </param>
        public ChatEvalToolResponseMessageEvaluation(
            global::G.AssistantMessageJudgePlanAI judgePlan,
            global::G.ChatEvalToolResponseMessageEvaluationRole role = global::G.ChatEvalToolResponseMessageEvaluationRole.Tool)
        {
            this.Role = role;
            this.JudgePlan = judgePlan ?? throw new global::System.ArgumentNullException(nameof(judgePlan));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalToolResponseMessageEvaluation" /> class.
        /// </summary>
        public ChatEvalToolResponseMessageEvaluation()
        {
        }
    }
}