//HintName: G.IPromptsClient.CreatePromptVersionTag.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Add tag to prompt version<br/>
        /// Add a new tag to a specific prompt version. Tags help identify and categorize different versions of a prompt.
        /// </summary>
        /// <param name="promptVersionId">
        /// The ID of the prompt version.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreatePromptVersionTagAsync(
            string promptVersionId,

            global::G.PromptVersionTagData request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add tag to prompt version<br/>
        /// Add a new tag to a specific prompt version. Tags help identify and categorize different versions of a prompt.
        /// </summary>
        /// <param name="promptVersionId">
        /// The ID of the prompt version.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreatePromptVersionTagAsync(
            string promptVersionId,
            string name,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}