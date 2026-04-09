//HintName: G.IRequestClient.LogRequest.g.cs
#nullable enable

namespace G
{
    public partial interface IRequestClient
    {
        /// <summary>
        /// Log Request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LogRequestResponse> LogRequestAsync(

            global::G.LogRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Log Request
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LogRequestResponse> LogRequestAsync(
            string provider,
            string model,
            global::G.Input input,
            global::G.Output output,
            global::System.DateTime requestStartTime,
            global::System.DateTime requestEndTime,
            object? parameters = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? promptName = default,
            int? promptId = default,
            int? promptVersionNumber = default,
            object? promptInputVariables = default,
            int? inputTokens = default,
            int? outputTokens = default,
            double? price = default,
            string? functionName = default,
            int? score = default,
            string? apiType = default,
            global::G.LogRequestStatus? status = default,
            global::G.LogRequestErrorType2? errorType = default,
            string? errorMessage = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}