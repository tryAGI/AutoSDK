//HintName: G.IFeedsClient.FeedsListMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// List Feed Messages<br/>
        /// List messages from a feed (for debugging/inspection)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="afterSequence"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsListMessagesResponse> FeedsListMessagesAsync(
            string feedId,
            string? afterSequence = default,
            string? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}