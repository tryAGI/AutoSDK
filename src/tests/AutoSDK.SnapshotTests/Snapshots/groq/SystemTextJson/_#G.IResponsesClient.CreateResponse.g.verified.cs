//HintName: G.IResponsesClient.CreateResponse.g.cs
#nullable enable

namespace G
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Creates a model response for the given input.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateResponseResponse> CreateResponseAsync(

            global::G.CreateResponseRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a model response for the given input.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use. For details on which models are compatible with the Responses API, see available [models](https://console.groq.com/docs/models)<br/>
        /// Example: llama-3.3-70b-versatile
        /// </param>
        /// <param name="input">
        /// Text input to the model, used to generate a response.
        /// </param>
        /// <param name="instructions">
        /// Inserts a system (or developer) message as the first item in the model's context.
        /// </param>
        /// <param name="maxOutputTokens">
        /// An upper bound for the number of tokens that can be generated for a response, including visible output tokens and reasoning tokens.
        /// </param>
        /// <param name="temperature">
        /// Controls randomness in the response generation. Range: 0 to 2. Lower values produce more deterministic outputs, higher values increase variety and creativity.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter that controls the cumulative probability cutoff. Range: 0 to 1. A value of 0.1 restricts sampling to tokens within the top 10% probability mass.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="tools">
        /// List of tools available to the model. Currently supports function definitions only. Maximum of 128 functions.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools.<br/>
        /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// `none` is the default when no tools are present. `auto` is the default if tools are present.
        /// </param>
        /// <param name="text">
        /// Response format configuration. Supports plain text or structured JSON output.
        /// </param>
        /// <param name="reasoning">
        /// Configuration for reasoning capabilities when using [models that support reasoning](https://console.groq.com/docs/reasoning).
        /// </param>
        /// <param name="metadata">
        /// Custom key-value pairs for storing additional information. Maximum of 16 pairs.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Enable parallel execution of multiple tool calls.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="store">
        /// Response storage flag. Note: Currently only supports false or null values.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stream">
        /// Enable streaming mode to receive response data as server-sent events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="user">
        /// Optional identifier for tracking end-user requests. Useful for usage monitoring and compliance.<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="serviceTier">
        /// Specifies the latency tier to use for processing the request.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="truncation">
        /// Context truncation strategy. Supported values: `auto` or `disabled`.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateResponseResponse> CreateResponseAsync(
            global::G.AnyOf<string, global::G.CreateResponseRequestModel?> model,
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ResponseInputItem>> input,
            string? instructions = default,
            int? maxOutputTokens = default,
            double? temperature = default,
            double? topP = default,
            global::System.Collections.Generic.IList<global::G.ResponseTool>? tools = default,
            global::G.ResponseToolChoiceOption? toolChoice = default,
            global::G.CreateResponseRequestText? text = default,
            global::G.CreateResponseRequestReasoning? reasoning = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            bool? parallelToolCalls = default,
            bool? store = default,
            bool? stream = default,
            string? user = default,
            global::G.CreateResponseRequestServiceTier? serviceTier = default,
            global::G.CreateResponseRequestTruncation? truncation = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}