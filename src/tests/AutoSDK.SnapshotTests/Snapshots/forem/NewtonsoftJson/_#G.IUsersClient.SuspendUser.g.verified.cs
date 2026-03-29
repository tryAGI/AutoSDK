//HintName: G.IUsersClient.SuspendUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Suspend a User<br/>
        /// This endpoint allows the client to suspend a user.<br/>
        /// The user associated with the API key must have any 'admin' or 'moderator' role.<br/>
        /// This specified user will be assigned the 'suspended' role. Suspending a user will stop the<br/>
        /// user from posting new posts and comments. It doesn't delete any of the user's content, just<br/>
        /// prevents them from creating new content while suspended. Users are not notified of their suspension<br/>
        /// in the UI, so if you want them to know about this, you must notify them.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task SuspendUserAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}