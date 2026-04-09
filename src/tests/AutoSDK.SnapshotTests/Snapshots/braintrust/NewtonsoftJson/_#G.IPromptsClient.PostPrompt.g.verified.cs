//HintName: G.IPromptsClient.PostPrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Create prompt<br/>
        /// Create a new prompt. If there is an existing prompt in the project with the same slug as the one specified in the request, will return the existing prompt unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Prompt> PostPromptAsync(

            global::G.CreatePrompt request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create prompt<br/>
        /// Create a new prompt. If there is an existing prompt in the project with the same slug as the one specified in the request, will return the existing prompt unmodified
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the prompt belongs under
        /// </param>
        /// <param name="name">
        /// Name of the prompt
        /// </param>
        /// <param name="slug">
        /// Unique identifier for the prompt
        /// </param>
        /// <param name="description">
        /// Textual description of the prompt
        /// </param>
        /// <param name="promptData">
        /// The prompt, model, and its parameters
        /// </param>
        /// <param name="tags">
        /// A list of tags for the prompt
        /// </param>
        /// <param name="functionType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Prompt> PostPromptAsync(
            global::System.Guid projectId,
            string name,
            string slug,
            string? description = default,
            global::G.PromptDataNullish? promptData = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::G.FunctionTypeEnumNullish? functionType = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}