//HintName: G.ICommentsClient.GetCommentById.g.cs
#nullable enable

namespace G
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Comment by id<br/>
        /// This endpoint allows the client to retrieve a comment as well as his descendants comments.<br/>
        ///   It will return the required comment (the root) with its nested descendants as a thread.<br/>
        ///   See the format specification for further details.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetCommentByIdAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}