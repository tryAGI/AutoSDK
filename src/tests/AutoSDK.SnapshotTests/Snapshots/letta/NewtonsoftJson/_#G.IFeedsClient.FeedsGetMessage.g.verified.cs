//HintName: G.IFeedsClient.FeedsGetMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Get Feed Message<br/>
        /// Get full content of a feed message
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsGetMessageResponse> FeedsGetMessageAsync(
            string feedId,
            string messageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}