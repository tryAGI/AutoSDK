//HintName: G.IFunctionsClient.PostFunctionIdInvoke.g.cs
#nullable enable

namespace G
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Invoke function<br/>
        /// Invoke a function.
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PostFunctionIdInvokeAsync(
            global::System.Guid functionId,

            global::G.InvokeApi request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invoke function<br/>
        /// Invoke a function.
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="input">
        /// Argument to the function, which can be any JSON serializable value
        /// </param>
        /// <param name="expected">
        /// The expected output of the function
        /// </param>
        /// <param name="metadata">
        /// Any relevant metadata. This will be logged and available as the `metadata` argument.
        /// </param>
        /// <param name="tags">
        /// Any relevant tags to log on the span.
        /// </param>
        /// <param name="messages">
        /// If the function is an LLM, additional messages to pass along to it
        /// </param>
        /// <param name="parent">
        /// Options for tracing the function call
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response. If true, results will be returned in the Braintrust SSE format.
        /// </param>
        /// <param name="mode">
        /// The mode format of the returned value (defaults to 'auto')
        /// </param>
        /// <param name="strict">
        /// If true, throw an error if one of the variables in the prompt is not present in the input
        /// </param>
        /// <param name="mcpAuth">
        /// Map of MCP server URL to auth credentials
        /// </param>
        /// <param name="overrides">
        /// Partial function definition to merge with the function being invoked. Fields are validated against the function type's schema at runtime. For facets: { preprocessor?, prompt?, model? }. For prompts: { model?, ... }.
        /// </param>
        /// <param name="version">
        /// The version of the function
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PostFunctionIdInvokeAsync(
            global::System.Guid functionId,
            object? input = default,
            object? expected = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessageParam>? messages = default,
            global::G.InvokeParent? parent = default,
            bool? stream = default,
            global::G.StreamingMode? mode = default,
            bool? strict = default,
            global::System.Collections.Generic.Dictionary<string, global::G.InvokeApiMcpAuth2>? mcpAuth = default,
            global::System.Collections.Generic.Dictionary<string, object?>? overrides = default,
            string? version = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}