//HintName: G.IUsersClient.UsersListEmailsForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List email addresses for the authenticated user<br/>
        /// Lists all of your email addresses, and specifies which one is visible<br/>
        /// to the public.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user:email` scope to use this endpoint.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Email>> UsersListEmailsForAuthenticatedUserAsync(
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}