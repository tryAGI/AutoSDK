//HintName: G.Models.RunObject.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `thread.run`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunObjectObjectJsonConverter))]
        public global::G.RunObjectObject Object { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The ID of the [thread](/docs/api-reference/threads) that was executed on as a part of this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThreadId { get; set; }

        /// <summary>
        /// The ID of the [assistant](/docs/api-reference/assistants) used for execution of this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssistantId { get; set; }

        /// <summary>
        /// The status of the run, which can be either `queued`, `in_progress`, `requires_action`, `cancelling`, `cancelled`, `failed`, `completed`, `incomplete`, or `expired`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunObjectStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunObjectStatus Status { get; set; }

        /// <summary>
        /// Details on the action required to continue the run. Will be `null` if no action is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunObjectRequiredAction? RequiredAction { get; set; }

        /// <summary>
        /// The last error associated with this run. Will be `null` if there are no errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunObjectLastError? LastError { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? StartedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? CancelledAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? FailedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the run was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// Details on why the run is incomplete. Will be `null` if the run is not incomplete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunObjectIncompleteDetails? IncompleteDetails { get; set; }

        /// <summary>
        /// The model that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The instructions that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// The list of tools that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ToolsItem4> Tools { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? Metadata { get; set; }

        /// <summary>
        /// Usage statistics related to the run. This value will be `null` if the run is not in a terminal state (i.e. `in_progress`, `queued`, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunCompletionUsage? Usage { get; set; }

        /// <summary>
        /// The sampling temperature used for this run. If not set, defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The nucleus sampling value used for this run. If not set, defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// The maximum number of prompt tokens specified to have been used over the course of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? MaxPromptTokens { get; set; }

        /// <summary>
        /// The maximum number of completion tokens specified to have been used over the course of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Controls for how a thread will be truncated prior to the run. Use this to control the intial context window of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation_strategy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TruncationObject TruncationStrategy { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tools and instead generates a message.<br/>
        /// `auto` is the default value and means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools before responding to the user.<br/>
        /// Specifying a particular tool like `{"type": "file_search"}` or `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AssistantsApiToolChoiceOption ToolChoice { get; set; }

        /// <summary>
        /// Whether to enable [parallel function calling](/docs/guides/function-calling/parallel-function-calling) during tool use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models/gpt-4o), [GPT-4 Turbo](/docs/models/gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which guarantees the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AssistantsApiResponseFormatOption ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// The list of tools that the [assistant](/docs/api-reference/assistants) used for this run.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
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
        /// <param name="truncationStrategy">
        /// Controls for how a thread will be truncated prior to the run. Use this to control the intial context window of the run.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tools and instead generates a message.<br/>
        /// `auto` is the default value and means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools before responding to the user.<br/>
        /// Specifying a particular tool like `{"type": "file_search"}` or `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](/docs/guides/function-calling/parallel-function-calling) during tool use.
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models/gpt-4o), [GPT-4 Turbo](/docs/models/gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which guarantees the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
            global::System.Collections.Generic.IList<global::G.ToolsItem4> tools,
            object? metadata,
            global::G.RunCompletionUsage? usage,
            int? maxPromptTokens,
            int? maxCompletionTokens,
            global::G.TruncationObject truncationStrategy,
            global::G.AssistantsApiToolChoiceOption toolChoice,
            bool? parallelToolCalls,
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
            this.TruncationStrategy = truncationStrategy ?? throw new global::System.ArgumentNullException(nameof(truncationStrategy));
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.RunObject? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.RunObject),
                jsonSerializerContext) as global::G.RunObject;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RunObject? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunObject>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.RunObject?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.RunObject),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.RunObject;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RunObject?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.RunObject?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}