//HintName: G.IPromptsClient.GetPromptsByCommits.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompts by commits<br/>
        /// Get prompts by prompt version commits
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PromptVersionLinkPublic>> GetPromptsByCommitsAsync(

            global::G.PromptVersionCommitsRequestPublic request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get prompts by commits<br/>
        /// Get prompts by prompt version commits
        /// </summary>
        /// <param name="commits"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PromptVersionLinkPublic>> GetPromptsByCommitsAsync(
            global::System.Collections.Generic.IList<string> commits,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}