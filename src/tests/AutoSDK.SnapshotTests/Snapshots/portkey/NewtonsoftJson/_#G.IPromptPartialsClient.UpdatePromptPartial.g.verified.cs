//HintName: G.IPromptPartialsClient.UpdatePromptPartial.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptPartialsClient
    {
        /// <summary>
        /// Update a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdatePromptPartialResponse> UpdatePromptPartialAsync(
            string promptPartialId,

            global::G.UpdatePromptPartialRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a prompt partial
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="name"></param>
        /// <param name="string"></param>
        /// <param name="description"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdatePromptPartialResponse> UpdatePromptPartialAsync(
            string promptPartialId,
            string? name = default,
            string? @string = default,
            string? description = default,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}