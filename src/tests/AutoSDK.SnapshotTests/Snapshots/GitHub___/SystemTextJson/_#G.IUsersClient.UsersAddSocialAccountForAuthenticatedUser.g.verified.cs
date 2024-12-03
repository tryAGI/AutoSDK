//HintName: G.IUsersClient.UsersAddSocialAccountForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Add social accounts for the authenticated user<br/>
        /// Add one or more social accounts to the authenticated user's profile.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SocialAccount>> UsersAddSocialAccountForAuthenticatedUserAsync(
            global::G.UsersAddSocialAccountForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add social accounts for the authenticated user<br/>
        /// Add one or more social accounts to the authenticated user's profile.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="accountUrls">
        /// Full URLs for the social media profiles to add.<br/>
        /// Example: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SocialAccount>> UsersAddSocialAccountForAuthenticatedUserAsync(
            global::System.Collections.Generic.IList<string> accountUrls,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}