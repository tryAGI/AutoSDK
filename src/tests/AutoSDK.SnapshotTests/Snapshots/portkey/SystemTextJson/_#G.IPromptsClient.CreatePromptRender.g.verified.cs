//HintName: G.IPromptsClient.CreatePromptRender.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Prompts Render<br/>
        /// Renders a prompt template with its variable values filled in
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptRenderResponse> CreatePromptRenderAsync(
            string promptId,

            global::G.CreatePromptRenderRequest2 request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prompts Render<br/>
        /// Renders a prompt template with its variable values filled in
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="variables">
        /// Variables to substitute in the prompt template
        /// </param>
        /// <param name="hyperparameters">
        /// **Note**: All hyperparameters are optional. Pass them at the root level, and not nested under `hyperparameters`. Their grouping here is for educational purposes only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptRenderResponse> CreatePromptRenderAsync(
            string promptId,
            object? variables = default,
            global::G.OneOf<global::G.CreateChatCompletionRequest, global::G.CreateCompletionRequest>? hyperparameters = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}