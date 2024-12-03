//HintName: G.IUsersClient.UsersListSocialAccountsForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List social accounts for the authenticated user<br/>
        /// Lists all of your social accounts.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SocialAccount>> UsersListSocialAccountsForAuthenticatedUserAsync(
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}