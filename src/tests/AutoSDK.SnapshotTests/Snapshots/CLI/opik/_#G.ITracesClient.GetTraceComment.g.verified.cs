//HintName: G.ITracesClient.GetTraceComment.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Get trace comment<br/>
        /// Get trace comment
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="traceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Comment> GetTraceCommentAsync(
            global::System.Guid commentId,
            global::System.Guid traceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}