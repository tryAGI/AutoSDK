//HintName: G.IPromptsClient.GetPromptVersionById.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompt version by id<br/>
        /// Get prompt version by id
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptVersionDetail> GetPromptVersionByIdAsync(
            global::System.Guid versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}