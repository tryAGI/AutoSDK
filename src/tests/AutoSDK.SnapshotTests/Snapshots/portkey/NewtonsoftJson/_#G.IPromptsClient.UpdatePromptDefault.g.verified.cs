//HintName: G.IPromptsClient.UpdatePromptDefault.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Set a version as the default for a prompt
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePromptDefaultAsync(
            string promptId,

            global::G.UpdatePromptDefaultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a version as the default for a prompt
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="version">
        /// Version Number to set as default
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePromptDefaultAsync(
            string promptId,
            double version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}