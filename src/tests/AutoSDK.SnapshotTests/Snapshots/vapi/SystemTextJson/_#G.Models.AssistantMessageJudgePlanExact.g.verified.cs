//HintName: G.Models.AssistantMessageJudgePlanExact.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessageJudgePlanExact
    {
        /// <summary>
        /// This is the type of the judge plan.<br/>
        /// Use 'exact' for an exact match on the content and tool calls - without using LLM-as-a-judge.<br/>
        /// @default 'exact'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantMessageJudgePlanExactTypeJsonConverter))]
        public global::G.AssistantMessageJudgePlanExactType Type { get; set; }

        /// <summary>
        /// This is what that will be used to evaluate the model's message content.<br/>
        /// If you provide a string, the assistant message content will be evaluated against it as an exact match, case-insensitive.<br/>
        /// Example: The weather in San Francisco is sunny.
        /// </summary>
        /// <example>The weather in San Francisco is sunny.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// This is the tool calls that will be used to evaluate the model's message content.<br/>
        /// The tool name must be a valid tool that the assistant is allowed to call.<br/>
        /// For the Query tool, the arguments for the tool call are in the format - {knowledgeBaseNames: ['kb_name', 'kb_name_2']}<br/>
        /// For the DTMF tool, the arguments for the tool call are in the format - {dtmf: "1234*"}<br/>
        /// For the Handoff tool, the arguments for the tool call are in the format - {destination: "assistant_id"}<br/>
        /// For the Transfer Call tool, the arguments for the tool call are in the format - {destination: "phone_number_or_assistant_id"}<br/>
        /// For all other tools, they are called without arguments or with user-defined arguments<br/>
        /// Example: [{ name: "get_weather", arguments: { city: "San Francisco" } }]
        /// </summary>
        /// <example>[{ name: "get_weather", arguments: { city: "San Francisco" } }]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCalls")]
        public global::System.Collections.Generic.IList<global::G.ChatEvalAssistantMessageMockToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageJudgePlanExact" /> class.
        /// </summary>
        /// <param name="content">
        /// This is what that will be used to evaluate the model's message content.<br/>
        /// If you provide a string, the assistant message content will be evaluated against it as an exact match, case-insensitive.<br/>
        /// Example: The weather in San Francisco is sunny.
        /// </param>
        /// <param name="type">
        /// This is the type of the judge plan.<br/>
        /// Use 'exact' for an exact match on the content and tool calls - without using LLM-as-a-judge.<br/>
        /// @default 'exact'
        /// </param>
        /// <param name="toolCalls">
        /// This is the tool calls that will be used to evaluate the model's message content.<br/>
        /// The tool name must be a valid tool that the assistant is allowed to call.<br/>
        /// For the Query tool, the arguments for the tool call are in the format - {knowledgeBaseNames: ['kb_name', 'kb_name_2']}<br/>
        /// For the DTMF tool, the arguments for the tool call are in the format - {dtmf: "1234*"}<br/>
        /// For the Handoff tool, the arguments for the tool call are in the format - {destination: "assistant_id"}<br/>
        /// For the Transfer Call tool, the arguments for the tool call are in the format - {destination: "phone_number_or_assistant_id"}<br/>
        /// For all other tools, they are called without arguments or with user-defined arguments<br/>
        /// Example: [{ name: "get_weather", arguments: { city: "San Francisco" } }]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantMessageJudgePlanExact(
            string content,
            global::G.AssistantMessageJudgePlanExactType type,
            global::System.Collections.Generic.IList<global::G.ChatEvalAssistantMessageMockToolCall>? toolCalls)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageJudgePlanExact" /> class.
        /// </summary>
        public AssistantMessageJudgePlanExact()
        {
        }
    }
}