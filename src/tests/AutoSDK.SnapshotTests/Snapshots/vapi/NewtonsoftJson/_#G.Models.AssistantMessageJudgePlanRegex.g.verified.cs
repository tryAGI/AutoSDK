//HintName: G.Models.AssistantMessageJudgePlanRegex.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessageJudgePlanRegex
    {
        /// <summary>
        /// This is the type of the judge plan.<br/>
        /// Use 'regex' for a regex match on the content and tool calls - without using LLM-as-a-judge.<br/>
        /// @default 'regex'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AssistantMessageJudgePlanRegexTypeJsonConverter))]
        public global::G.AssistantMessageJudgePlanRegexType Type { get; set; }

        /// <summary>
        /// This is what that will be used to evaluate the model's message content.<br/>
        /// The content will be evaluated against the regex pattern provided in the Judge Plan content field.<br/>
        /// Evaluation is considered successful if the regex pattern matches any part of the assistant message content.<br/>
        /// Example: /sunny/i
        /// </summary>
        /// <example>/sunny/i</example>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// This is the tool calls that will be used to evaluate the model's message content.<br/>
        /// The tool name must be a valid tool that the assistant is allowed to call.<br/>
        /// The values to the arguments for the tool call should be a Regular Expression.<br/>
        /// Evaluation is considered successful if the regex pattern matches any part of each tool call argument.<br/>
        /// For the Query tool, the arguments for the tool call are in the format - {knowledgeBaseNames: ['kb_name', 'kb_name_2']}<br/>
        /// For the DTMF tool, the arguments for the tool call are in the format - {dtmf: "1234*"}<br/>
        /// For the Handoff tool, the arguments for the tool call are in the format - {destination: "assistant_id"}<br/>
        /// For the Transfer Call tool, the arguments for the tool call are in the format - {destination: "phone_number_or_assistant_id"}<br/>
        /// For all other tools, they are called without arguments or with user-defined arguments<br/>
        /// Example: [{ name: "get_weather", arguments: { city: "/San Francisco/i" } }]
        /// </summary>
        /// <example>[{ name: "get_weather", arguments: { city: "/San Francisco/i" } }]</example>
        [global::Newtonsoft.Json.JsonProperty("toolCalls")]
        public global::System.Collections.Generic.IList<global::G.ChatEvalAssistantMessageMockToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageJudgePlanRegex" /> class.
        /// </summary>
        /// <param name="content">
        /// This is what that will be used to evaluate the model's message content.<br/>
        /// The content will be evaluated against the regex pattern provided in the Judge Plan content field.<br/>
        /// Evaluation is considered successful if the regex pattern matches any part of the assistant message content.<br/>
        /// Example: /sunny/i
        /// </param>
        /// <param name="type">
        /// This is the type of the judge plan.<br/>
        /// Use 'regex' for a regex match on the content and tool calls - without using LLM-as-a-judge.<br/>
        /// @default 'regex'
        /// </param>
        /// <param name="toolCalls">
        /// This is the tool calls that will be used to evaluate the model's message content.<br/>
        /// The tool name must be a valid tool that the assistant is allowed to call.<br/>
        /// The values to the arguments for the tool call should be a Regular Expression.<br/>
        /// Evaluation is considered successful if the regex pattern matches any part of each tool call argument.<br/>
        /// For the Query tool, the arguments for the tool call are in the format - {knowledgeBaseNames: ['kb_name', 'kb_name_2']}<br/>
        /// For the DTMF tool, the arguments for the tool call are in the format - {dtmf: "1234*"}<br/>
        /// For the Handoff tool, the arguments for the tool call are in the format - {destination: "assistant_id"}<br/>
        /// For the Transfer Call tool, the arguments for the tool call are in the format - {destination: "phone_number_or_assistant_id"}<br/>
        /// For all other tools, they are called without arguments or with user-defined arguments<br/>
        /// Example: [{ name: "get_weather", arguments: { city: "/San Francisco/i" } }]
        /// </param>
        public AssistantMessageJudgePlanRegex(
            string content,
            global::G.AssistantMessageJudgePlanRegexType type,
            global::System.Collections.Generic.IList<global::G.ChatEvalAssistantMessageMockToolCall>? toolCalls)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageJudgePlanRegex" /> class.
        /// </summary>
        public AssistantMessageJudgePlanRegex()
        {
        }
    }
}