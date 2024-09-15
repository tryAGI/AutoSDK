//HintName: G.IGistsClient.GistsDeleteComment.g.cs
#nullable enable

namespace G
{
    public partial interface IGistsClient
    {
        /// <summary>
        /// Delete a gist comment
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="commentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> GistsDeleteCommentAsync(
            string gistId,
            int commentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}