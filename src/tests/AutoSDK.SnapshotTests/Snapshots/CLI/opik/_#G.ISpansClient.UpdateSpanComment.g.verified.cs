//HintName: G.ISpansClient.UpdateSpanComment.g.cs
#nullable enable

namespace G
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Update span comment by id<br/>
        /// Update span comment by id
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateSpanCommentAsync(
            global::System.Guid commentId,

            global::G.Comment request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update span comment by id<br/>
        /// Update span comment by id
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateSpanCommentAsync(
            global::System.Guid commentId,
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}