//HintName: G.IPromptPartialsClient.UpdatePromptPartialDefault.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptPartialsClient
    {
        /// <summary>
        /// Set a version as the default for a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePromptPartialDefaultAsync(
            string promptPartialId,

            global::G.UpdatePromptPartialDefaultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a version as the default for a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="version">
        /// Version Number to set as default
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePromptPartialDefaultAsync(
            string promptPartialId,
            double version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}