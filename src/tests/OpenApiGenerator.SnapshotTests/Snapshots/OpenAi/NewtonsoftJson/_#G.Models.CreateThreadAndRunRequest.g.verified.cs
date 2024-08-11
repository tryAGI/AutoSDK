//HintName: G.Models.CreateThreadAndRunRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateThreadAndRunRequest
    {
        /// <summary>
        /// The ID of the [assistant](/docs/api-reference/assistants) to use to execute this run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssistantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread")]
        public global::G.CreateThreadRequest? Thread { get; set; }

        /// <summary>
        /// The ID of the [Model](/docs/api-reference/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.<br/>
        /// Example: gpt-4o
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::System.AnyOf<string?, global::G.CreateThreadAndRunRequestModel?>? Model { get; set; }

        /// <summary>
        /// Override the default system message of the assistant. This is useful for modifying the behavior on a per-run basis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Override the tools the assistant can use for this run. This is useful for modifying the behavior on a per-run basis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::System.OneOf<global::G.AssistantToolsCode?, global::G.AssistantToolsFileSearch?, global::G.AssistantToolsFunction?>>? Tools { get; set; }

        /// <summary>
        /// A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_resources")]
        public global::G.CreateThreadAndRunRequestToolResources? ToolResources { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.CreateThreadAndRunRequestMetadata? Metadata { get; set; }

        /// <summary>
        /// empty<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; } = 1;

        /// <summary>
        /// empty<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; } = 1;

        /// <summary>
        /// If `true`, returns a stream of events that happen during the Run as server-sent events, terminating when the Run enters a terminal state with a `data: [DONE]` message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// The maximum number of prompt tokens that may be used over the course of the run. The run will make a best effort to use only the number of prompt tokens specified, across multiple turns of the run. If the run exceeds the number of prompt tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_prompt_tokens")]
        public int? MaxPromptTokens { get; set; }

        /// <summary>
        /// The maximum number of completion tokens that may be used over the course of the run. The run will make a best effort to use only the number of completion tokens specified, across multiple turns of the run. If the run exceeds the number of completion tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Controls for how a thread will be truncated prior to the run. Use this to control the intial context window of the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncation_strategy")]
        public global::G.TruncationObject? TruncationStrategy { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tools and instead generates a message.<br/>
        /// `auto` is the default value and means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools before responding to the user.<br/>
        /// Specifying a particular tool like `{"type": "file_search"}` or `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public global::G.AssistantsApiToolChoiceOption? ToolChoice { get; set; }

        /// <summary>
        /// Whether to enable [parallel function calling](/docs/guides/function-calling/parallel-function-calling) during tool use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models/gpt-4o), [GPT-4 Turbo](/docs/models/gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which guarantees the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.AssistantsApiResponseFormatOption? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}