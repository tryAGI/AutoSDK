//HintName: G.Models.AssistantMessageEvaluationContinuePlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessageEvaluationContinuePlan
    {
        /// <summary>
        /// This is whether the evaluation should exit if the assistant message evaluates to false.<br/>
        /// By default, it is false and the evaluation will continue.<br/>
        /// @default false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exitOnFailureEnabled")]
        public bool? ExitOnFailureEnabled { get; set; }

        /// <summary>
        /// This is the content that will be used in the conversation for this assistant turn moving forward if provided.<br/>
        /// It will override the content received from the model.<br/>
        /// Example: The weather in San Francisco is sunny.
        /// </summary>
        /// <example>The weather in San Francisco is sunny.</example>
        [global::Newtonsoft.Json.JsonProperty("contentOverride")]
        public string? ContentOverride { get; set; }

        /// <summary>
        /// This is the tool calls that will be used in the conversation for this assistant turn moving forward if provided.<br/>
        /// It will override the tool calls received from the model.<br/>
        /// Example: [{ name: "get_weather", arguments: { city: "San Francisco" } }]
        /// </summary>
        /// <example>[{ name: "get_weather", arguments: { city: "San Francisco" } }]</example>
        [global::Newtonsoft.Json.JsonProperty("toolCallsOverride")]
        public global::System.Collections.Generic.IList<global::G.ChatEvalAssistantMessageMockToolCall>? ToolCallsOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageEvaluationContinuePlan" /> class.
        /// </summary>
        /// <param name="exitOnFailureEnabled">
        /// This is whether the evaluation should exit if the assistant message evaluates to false.<br/>
        /// By default, it is false and the evaluation will continue.<br/>
        /// @default false
        /// </param>
        /// <param name="contentOverride">
        /// This is the content that will be used in the conversation for this assistant turn moving forward if provided.<br/>
        /// It will override the content received from the model.<br/>
        /// Example: The weather in San Francisco is sunny.
        /// </param>
        /// <param name="toolCallsOverride">
        /// This is the tool calls that will be used in the conversation for this assistant turn moving forward if provided.<br/>
        /// It will override the tool calls received from the model.<br/>
        /// Example: [{ name: "get_weather", arguments: { city: "San Francisco" } }]
        /// </param>
        public AssistantMessageEvaluationContinuePlan(
            bool? exitOnFailureEnabled,
            string? contentOverride,
            global::System.Collections.Generic.IList<global::G.ChatEvalAssistantMessageMockToolCall>? toolCallsOverride)
        {
            this.ExitOnFailureEnabled = exitOnFailureEnabled;
            this.ContentOverride = contentOverride;
            this.ToolCallsOverride = toolCallsOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageEvaluationContinuePlan" /> class.
        /// </summary>
        public AssistantMessageEvaluationContinuePlan()
        {
        }
    }
}