//HintName: G.ICommentsClient.CommentsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Create a comment. Comments may be attached to different object types (trace, observation, session, prompt).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateCommentResponse> CommentsCreateAsync(

            global::G.CreateCommentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a comment. Comments may be attached to different object types (trace, observation, session, prompt).
        /// </summary>
        /// <param name="projectId">
        /// The id of the project to attach the comment to.
        /// </param>
        /// <param name="objectType">
        /// The type of the object to attach the comment to (trace, observation, session, prompt).
        /// </param>
        /// <param name="objectId">
        /// The id of the object to attach the comment to. If this does not reference a valid existing object, an error will be thrown.
        /// </param>
        /// <param name="content">
        /// The content of the comment. May include markdown. Currently limited to 5000 characters.
        /// </param>
        /// <param name="authorUserId">
        /// The id of the user who created the comment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateCommentResponse> CommentsCreateAsync(
            string projectId,
            string objectType,
            string objectId,
            string content,
            string? authorUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}