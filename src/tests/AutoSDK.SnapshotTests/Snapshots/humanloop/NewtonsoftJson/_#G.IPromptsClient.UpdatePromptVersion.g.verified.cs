//HintName: G.IPromptsClient.UpdatePromptVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Update Prompt Version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptResponse> UpdatePromptVersionAsync(
            string id,
            string versionId,

            global::G.UpdateVersionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Prompt Version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptResponse> UpdatePromptVersionAsync(
            string id,
            string versionId,
            string? versionName = default,
            string? versionDescription = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}