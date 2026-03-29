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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PromptVersionLinkPublic>> GetPromptsByCommitsAsync(

            global::G.PromptVersionCommitsRequestPublic request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get prompts by commits<br/>
        /// Get prompts by prompt version commits
        /// </summary>
        /// <param name="commits"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PromptVersionLinkPublic>> GetPromptsByCommitsAsync(
            global::System.Collections.Generic.IList<string> commits,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}