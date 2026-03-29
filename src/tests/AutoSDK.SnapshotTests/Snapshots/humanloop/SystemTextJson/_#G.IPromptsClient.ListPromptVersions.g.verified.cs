//HintName: G.IPromptsClient.ListPromptVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// List Prompt Versions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PromptResponse>> ListPromptVersionsAsync(
            string id,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}