//HintName: G.IUsersClient.UnpublishUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Unpublish a User's Articles and Comments<br/>
        /// This endpoint allows the client to unpublish all of the articles and<br/>
        /// comments created by a user.<br/>
        /// The user associated with the API key must have any 'admin' or 'moderator' role.<br/>
        /// This specified user's articles and comments will be unpublished and will no longer be<br/>
        /// visible to the public. They will remain in the database and will set back to draft status<br/>
        /// on the specified user's  dashboard. Any notifications associated with the specified user's<br/>
        /// articles and comments will be deleted.<br/>
        /// Note this endpoint unpublishes articles and comments asychronously: it will return a 204 NO CONTENT<br/>
        /// status code immediately, but the articles and comments will not be unpublished until the<br/>
        /// request is completed on the server.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UnpublishUserAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}