//HintName: G.ICommentsClient.GetCommentsByArticleId.g.cs
#nullable enable

namespace G
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Comments<br/>
        /// This endpoint allows the client to retrieve all comments belonging to an article or podcast episode as threaded conversations.<br/>
        /// It will return the all top level comments with their nested comments as threads. See the format specification for further details.
        /// </summary>
        /// <param name="aId"></param>
        /// <param name="pId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Comment>> GetCommentsByArticleIdAsync(
            string? aId = default,
            string? pId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}