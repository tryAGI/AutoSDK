//HintName: G.IPrompt2025Client.RemoveEnvironmentFromVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> RemoveEnvironmentFromVersionAsync(

            global::G.RemoveEnvironmentFromVersionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> RemoveEnvironmentFromVersionAsync(
            string environment,
            string promptVersionId,
            string promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}