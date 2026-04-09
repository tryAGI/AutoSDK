//HintName: G.IPromptsClient.CallPrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Call Prompt<br/>
        /// Call a Prompt with proxied LLM call and automatic logging.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptCallResponse> CallPromptAsync(

            global::G.PromptCallRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call Prompt<br/>
        /// Call a Prompt with proxied LLM call and automatic logging.
        /// </summary>
        /// <param name="versionId">
        /// A specific Version ID of the Prompt to call.
        /// </param>
        /// <param name="environment">
        /// Name of the Environment identifying a deployed version.
        /// </param>
        /// <param name="path">
        /// Path of the Prompt.
        /// </param>
        /// <param name="id">
        /// ID for an existing Prompt.
        /// </param>
        /// <param name="messages">
        /// The messages passed to the provider.
        /// </param>
        /// <param name="prompt">
        /// Request to create or update a Prompt.
        /// </param>
        /// <param name="inputs">
        /// The inputs passed to the prompt template.
        /// </param>
        /// <param name="source">
        /// Identifies where the model was called from.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="save">
        /// Whether the request/response payloads will be stored.
        /// </param>
        /// <param name="logId">
        /// Custom Log ID.
        /// </param>
        /// <param name="numSamples">
        /// The number of generations.
        /// </param>
        /// <param name="returnInputs">
        /// Whether to return the inputs in the response.
        /// </param>
        /// <param name="traceParentId">
        /// The ID of the parent Log to nest this Log under.
        /// </param>
        /// <param name="user">
        /// End-user ID related to the Log.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptCallResponse> CallPromptAsync(
            string? versionId = default,
            string? environment = default,
            string? path = default,
            string? id = default,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? messages = default,
            global::G.PromptRequest? prompt = default,
            object? inputs = default,
            string? source = default,
            object? metadata = default,
            bool? save = default,
            string? logId = default,
            int? numSamples = default,
            bool? returnInputs = default,
            string? traceParentId = default,
            string? user = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}