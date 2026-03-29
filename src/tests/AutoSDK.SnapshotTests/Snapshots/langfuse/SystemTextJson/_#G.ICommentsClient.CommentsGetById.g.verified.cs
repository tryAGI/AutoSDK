//HintName: G.ICommentsClient.CommentsGetById.g.cs
#nullable enable

namespace G
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Get a comment by id
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Comment> CommentsGetByIdAsync(
            string commentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}