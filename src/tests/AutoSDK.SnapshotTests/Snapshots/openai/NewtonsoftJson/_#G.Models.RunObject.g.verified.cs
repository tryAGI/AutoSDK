//HintName: G.Models.RunObject.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an execution run on a [thread](/docs/api-reference/threads).
    /// </summary>
    public sealed partial class RunObject
    {
        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `thread.run`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.RunObjectObject Object { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The ID of the [thread](/docs/api-reference/threads) that was executed on as a part of this run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThreadId { get; set; } = default!;

        /// <summary>
        /// The ID of the [assistant](/docs/api-reference/assistants) used for execution of this run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssistantId { get; set; } = default!;

        /// <summary>
        /// The status of the run, which can be either `queued`, `in_progress`, `requires_action`, `cancelling`, `cancelled`, `failed`, `completed`, `incomplete`, or `expired`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunObjectStatus Status { get; set; } = default!;

        /// <summary>
        /// Details on the action required to continue the run. Will be `null` if no action is required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunObjectRequiredAction? RequiredAction { get; set; } = default!;

        /// <summary>
        /// The last error associated with this run. Will be `null` if there are no errors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunObjectLastError? LastError { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run will expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? ExpiresAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? StartedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was cancelled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? CancelledAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? FailedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? CompletedAt { get; set; } = default!;

        /// <summary>
        /// Details on why the run is incomplete. Will be `null` if the run is not incomplete.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("incomplete_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunObjectIncompleteDetails? IncompleteDetails { get; set; } = default!;

        /// <summary>
        /// The model that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The instructions that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public string Instructions { get; set; } = default!;

        /// <summary>
        /// The list of tools that the [assistant](/docs/api-reference/assistants) used for this run.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearch, global::G.AssistantToolsFunction>> Tools { get; set; } = default!;

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; } = default!;

        /// <summary>
        /// Usage statistics related to the run. This value will be `null` if the run is not in a terminal state (i.e. `in_progress`, `queued`, etc.).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunCompletionUsage? Usage { get; set; } = default!;

        /// <summary>
        /// The sampling temperature used for this run. If not set, defaults to 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The nucleus sampling value used for this run. If not set, defaults to 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// The maximum number of prompt tokens specified to have been used over the course of the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int? MaxPromptTokens { get; set; } = default!;

        /// <summary>
        /// The maximum number of completion tokens specified to have been used over the course of the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int? MaxCompletionTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncation_strategy", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AllOf<global::G.TruncationObject, object> TruncationStrategy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AllOf<global::G.AssistantsApiToolChoiceOption?, object> ToolChoice { get; set; } = default!;

        /// <summary>
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.<br/>
        /// Default Value: true
        /// </summary>
        /// <default>true</default>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ParallelToolCalls { get; set; } = default!;

        /// <summary>
        /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models#gpt-4o), [GPT-4 Turbo](/docs/models#gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AssistantsApiResponseFormatOption ResponseFormat { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `thread.run`.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the run was created.
        /// </param>
        /// <param name="threadId">
        /// The ID of the [thread](/docs/api-reference/threads) that was executed on as a part of this run.
        /// </param>
        /// <param name="assistantId">
        /// The ID of the [assistant](/docs/api-reference/assistants) used for execution of this run.
        /// </param>
        /// <param name="status">
        /// The status of the run, which can be either `queued`, `in_progress`, `requires_action`, `cancelling`, `cancelled`, `failed`, `completed`, `incomplete`, or `expired`.
        /// </param>
        /// <param name="requiredAction">
        /// Details on the action required to continue the run. Will be `null` if no action is required.
        /// </param>
        /// <param name="lastError">
        /// The last error associated with this run. Will be `null` if there are no errors.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) for when the run will expire.
        /// </param>
        /// <param name="startedAt">
        /// The Unix timestamp (in seconds) for when the run was started.
        /// </param>
        /// <param name="cancelledAt">
        /// The Unix timestamp (in seconds) for when the run was cancelled.
        /// </param>
        /// <param name="failedAt">
        /// The Unix timestamp (in seconds) for when the run failed.
        /// </param>
        /// <param name="completedAt">
        /// The Unix timestamp (in seconds) for when the run was completed.
        /// </param>
        /// <param name="incompleteDetails">
        /// Details on why the run is incomplete. Will be `null` if the run is not incomplete.
        /// </param>
        /// <param name="model">
        /// The model that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </param>
        /// <param name="instructions">
        /// The instructions that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </param>
        /// <param name="tools">
        /// The list of tools that the [assistant](/docs/api-reference/assistants) used for this run.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="usage">
        /// Usage statistics related to the run. This value will be `null` if the run is not in a terminal state (i.e. `in_progress`, `queued`, etc.).
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature used for this run. If not set, defaults to 1.
        /// </param>
        /// <param name="topP">
        /// The nucleus sampling value used for this run. If not set, defaults to 1.
        /// </param>
        /// <param name="maxPromptTokens">
        /// The maximum number of prompt tokens specified to have been used over the course of the run.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of completion tokens specified to have been used over the course of the run.
        /// </param>
        /// <param name="truncationStrategy"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models#gpt-4o), [GPT-4 Turbo](/docs/models#gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </param>
        public RunObject(
            string id,
            global::System.DateTimeOffset createdAt,
            string threadId,
            string assistantId,
            global::G.RunObjectStatus status,
            global::G.RunObjectRequiredAction? requiredAction,
            global::G.RunObjectLastError? lastError,
            global::System.DateTimeOffset? expiresAt,
            global::System.DateTimeOffset? startedAt,
            global::System.DateTimeOffset? cancelledAt,
            global::System.DateTimeOffset? failedAt,
            global::System.DateTimeOffset? completedAt,
            global::G.RunObjectIncompleteDetails? incompleteDetails,
            string model,
            string instructions,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearch, global::G.AssistantToolsFunction>> tools,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.RunCompletionUsage? usage,
            int? maxPromptTokens,
            int? maxCompletionTokens,
            global::G.AllOf<global::G.TruncationObject, object> truncationStrategy,
            global::G.AllOf<global::G.AssistantsApiToolChoiceOption?, object> toolChoice,
            bool parallelToolCalls,
            global::G.AssistantsApiResponseFormatOption responseFormat,
            global::G.RunObjectObject @object,
            double? temperature,
            double? topP)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.AssistantId = assistantId ?? throw new global::System.ArgumentNullException(nameof(assistantId));
            this.Status = status;
            this.RequiredAction = requiredAction ?? throw new global::System.ArgumentNullException(nameof(requiredAction));
            this.LastError = lastError ?? throw new global::System.ArgumentNullException(nameof(lastError));
            this.ExpiresAt = expiresAt;
            this.StartedAt = startedAt;
            this.CancelledAt = cancelledAt;
            this.FailedAt = failedAt;
            this.CompletedAt = completedAt;
            this.IncompleteDetails = incompleteDetails ?? throw new global::System.ArgumentNullException(nameof(incompleteDetails));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.MaxPromptTokens = maxPromptTokens;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.TruncationStrategy = truncationStrategy;
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
            this.ResponseFormat = responseFormat;
            this.Object = @object;
            this.Temperature = temperature;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObject" /> class.
        /// </summary>
        public RunObject()
        {
        }
    }
}