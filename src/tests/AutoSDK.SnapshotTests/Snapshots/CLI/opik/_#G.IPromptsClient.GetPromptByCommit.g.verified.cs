//HintName: G.IPromptsClient.GetPromptByCommit.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompt by commit<br/>
        /// Get prompt by commit
        /// </summary>
        /// <param name="commit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptDetail> GetPromptByCommitAsync(
            string commit,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}