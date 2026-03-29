//HintName: G.Models.ChatPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatPrompt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MessagesItem> Messages { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("functions")]
        public global::System.Collections.Generic.IList<global::G.Function>? Functions { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_call")]
        public global::G.AnyOf<string, global::G.MessageFunctionCall, object>? FunctionCall { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public global::G.AnyOf<string, global::G.ChatToolChoice, object>? ToolChoice { get; set; }

        /// <summary>
        /// Default Value: chat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatPromptType? Type { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_variables")]
        public global::System.Collections.Generic.IList<string>? InputVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatPrompt" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="functions">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tools">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="functionCall">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="toolChoice">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: chat
        /// </param>
        /// <param name="inputVariables">
        /// Default Value: []
        /// </param>
        public ChatPrompt(
            global::System.Collections.Generic.IList<global::G.MessagesItem> messages,
            global::System.Collections.Generic.IList<global::G.Function>? functions,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::G.AnyOf<string, global::G.MessageFunctionCall, object>? functionCall,
            global::G.AnyOf<string, global::G.ChatToolChoice, object>? toolChoice,
            global::G.ChatPromptType? type,
            global::System.Collections.Generic.IList<string>? inputVariables)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Functions = functions;
            this.Tools = tools;
            this.FunctionCall = functionCall;
            this.ToolChoice = toolChoice;
            this.Type = type;
            this.InputVariables = inputVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatPrompt" /> class.
        /// </summary>
        public ChatPrompt()
        {
        }
    }
}