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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatEvalToolResponseMessageEvaluationRoleJsonConverter))]
        public global::G.ChatEvalToolResponseMessageEvaluationRole Role { get; set; } = global::G.ChatEvalToolResponseMessageEvaluationRole.Tool;

        /// <summary>
        /// This is the judge plan that instructs how to evaluate the tool response message.<br/>
        /// The tool response message can be evaluated with an LLM-as-judge by defining the evaluation criteria in a prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judgePlan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AssistantMessageJudgePlanAI JudgePlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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