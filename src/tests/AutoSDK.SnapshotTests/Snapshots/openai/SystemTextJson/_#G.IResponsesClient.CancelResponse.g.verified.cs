//HintName: G.IResponsesClient.CancelResponse.g.cs
#nullable enable

namespace G
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Cancels a model response with the given ID. Only responses created with<br/>
        /// the `background` parameter set to `true` can be cancelled. <br/>
        /// [Learn more](/docs/guides/background).
        /// </summary>
        /// <param name="responseId">
        /// Example: resp_677efb5139a88190b512bc3fef8e535d
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response> CancelResponseAsync(
            string responseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}