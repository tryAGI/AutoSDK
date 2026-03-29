//HintName: G.Models.LogRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Input Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Output Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RequestStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RequestEndTime { get; set; }

        /// <summary>
        /// Model parameters including temperature, max_tokens, etc. Can also include structured output configuration via response_format.json_schema. See documentation for structured output examples.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Custom key-value pairs for tracking additional request information. Keys are limited to 1024 characters.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        public string? PromptName { get; set; }

        /// <summary>
        /// The ID of the prompt template used for this request. This is useful for tracking which prompt was used in the request.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        public int? PromptId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_number")]
        public int? PromptVersionNumber { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_input_variables")]
        public object? PromptInputVariables { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_name")]
        public string? FunctionName { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_type")]
        public string? ApiType { get; set; }

        /// <summary>
        /// Request status.<br/>
        /// | Value | Description |<br/>
        /// |-------|-------------|<br/>
        /// | `SUCCESS` | Request completed successfully (default) |<br/>
        /// | `WARNING` | Request succeeded but had issues (e.g., retries, degraded response) |<br/>
        /// | `ERROR` | Request failed |<br/>
        /// Default Value: SUCCESS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LogRequestStatusJsonConverter))]
        public global::G.LogRequestStatus? Status { get; set; }

        /// <summary>
        /// Categorized error type.<br/>
        /// | Value | Description | Allowed Statuses |<br/>
        /// |-------|-------------|------------------|<br/>
        /// | `PROVIDER_RATE_LIMIT` | Rate limit hit on provider API | WARNING, ERROR |<br/>
        /// | `PROVIDER_QUOTA_LIMIT` | Account quota or spending limit exceeded | WARNING, ERROR |<br/>
        /// | `VARIABLE_MISSING_OR_EMPTY` | Required template variable was missing or empty | WARNING |<br/>
        /// | `PROVIDER_TIMEOUT` | Request timed out | ERROR |<br/>
        /// | `PROVIDER_AUTH_ERROR` | Authentication failed with provider | ERROR |<br/>
        /// | `PROVIDER_ERROR` | General provider-side error | ERROR |<br/>
        /// | `TEMPLATE_RENDER_ERROR` | Failed to render prompt template | ERROR |<br/>
        /// | `UNKNOWN_ERROR` | Uncategorized error | WARNING, ERROR |<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        public global::G.LogRequestErrorType2? ErrorType { get; set; }

        /// <summary>
        /// Detailed error message describing what went wrong. Maximum 1024 characters.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRequest" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="requestStartTime"></param>
        /// <param name="requestEndTime"></param>
        /// <param name="parameters">
        /// Model parameters including temperature, max_tokens, etc. Can also include structured output configuration via response_format.json_schema. See documentation for structured output examples.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="tags">
        /// Default Value: []
        /// </param>
        /// <param name="metadata">
        /// Custom key-value pairs for tracking additional request information. Keys are limited to 1024 characters.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="promptName">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="promptId">
        /// The ID of the prompt template used for this request. This is useful for tracking which prompt was used in the request.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="promptVersionNumber">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="promptInputVariables">
        /// Default Value: {}
        /// </param>
        /// <param name="inputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="outputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="price">
        /// Default Value: 0F
        /// </param>
        /// <param name="functionName"></param>
        /// <param name="score">
        /// Default Value: 0
        /// </param>
        /// <param name="apiType">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="status">
        /// Request status.<br/>
        /// | Value | Description |<br/>
        /// |-------|-------------|<br/>
        /// | `SUCCESS` | Request completed successfully (default) |<br/>
        /// | `WARNING` | Request succeeded but had issues (e.g., retries, degraded response) |<br/>
        /// | `ERROR` | Request failed |<br/>
        /// Default Value: SUCCESS
        /// </param>
        /// <param name="errorType">
        /// Categorized error type.<br/>
        /// | Value | Description | Allowed Statuses |<br/>
        /// |-------|-------------|------------------|<br/>
        /// | `PROVIDER_RATE_LIMIT` | Rate limit hit on provider API | WARNING, ERROR |<br/>
        /// | `PROVIDER_QUOTA_LIMIT` | Account quota or spending limit exceeded | WARNING, ERROR |<br/>
        /// | `VARIABLE_MISSING_OR_EMPTY` | Required template variable was missing or empty | WARNING |<br/>
        /// | `PROVIDER_TIMEOUT` | Request timed out | ERROR |<br/>
        /// | `PROVIDER_AUTH_ERROR` | Authentication failed with provider | ERROR |<br/>
        /// | `PROVIDER_ERROR` | General provider-side error | ERROR |<br/>
        /// | `TEMPLATE_RENDER_ERROR` | Failed to render prompt template | ERROR |<br/>
        /// | `UNKNOWN_ERROR` | Uncategorized error | WARNING, ERROR |<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="errorMessage">
        /// Detailed error message describing what went wrong. Maximum 1024 characters.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogRequest(
            string provider,
            string model,
            global::G.Input input,
            global::G.Output output,
            global::System.DateTime requestStartTime,
            global::System.DateTime requestEndTime,
            object? parameters,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? promptName,
            int? promptId,
            int? promptVersionNumber,
            object? promptInputVariables,
            int? inputTokens,
            int? outputTokens,
            double? price,
            string? functionName,
            int? score,
            string? apiType,
            global::G.LogRequestStatus? status,
            global::G.LogRequestErrorType2? errorType,
            string? errorMessage)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.Output = output;
            this.RequestStartTime = requestStartTime;
            this.RequestEndTime = requestEndTime;
            this.Parameters = parameters;
            this.Tags = tags;
            this.Metadata = metadata;
            this.PromptName = promptName;
            this.PromptId = promptId;
            this.PromptVersionNumber = promptVersionNumber;
            this.PromptInputVariables = promptInputVariables;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.Price = price;
            this.FunctionName = functionName;
            this.Score = score;
            this.ApiType = apiType;
            this.Status = status;
            this.ErrorType = errorType;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRequest" /> class.
        /// </summary>
        public LogRequest()
        {
        }
    }
}