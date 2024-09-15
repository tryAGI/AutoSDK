//HintName: G.IActivityClient.ActivityListNotificationsForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// List notifications for the authenticated user<br/>
        /// List all notifications for the current user, sorted by most recently updated.
        /// </summary>
        /// <param name="all">
        /// Default Value: false
        /// </param>
        /// <param name="participating">
        /// Default Value: false
        /// </param>
        /// <param name="since"></param>
        /// <param name="before"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Thread>> ActivityListNotificationsForAuthenticatedUserAsync(
            bool all = false,
            bool participating = false,
            global::System.DateTime since = default,
            global::System.DateTime before = default,
            int page = 1,
            int perPage = 50,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}