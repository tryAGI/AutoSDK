//HintName: G.IPromptPartialsClient.GetPromptPartialVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptPartialsClient
    {
        /// <summary>
        /// Get all versions of a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PromptPartialVersion>> GetPromptPartialVersionsAsync(
            string promptPartialId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}