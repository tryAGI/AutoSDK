//HintName: G.IPromptsClient.CreatePromptCompletion.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Prompts Completions<br/>
        /// Execute your saved prompt templates on Portkey
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptCompletionResponse> CreatePromptCompletionAsync(
            string promptId,

            global::G.CreatePromptCompletionRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prompts Completions<br/>
        /// Execute your saved prompt templates on Portkey
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptCompletionResponse> CreatePromptCompletionAsync(
            string promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}