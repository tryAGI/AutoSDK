//HintName: G.IPromptsClient.RestorePromptVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Restore prompt version<br/>
        /// Restore a prompt version by creating a new version with the content from the specified version
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptVersionDetail> RestorePromptVersionAsync(
            global::System.Guid promptId,
            global::System.Guid versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}