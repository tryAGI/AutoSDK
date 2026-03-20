//HintName: G.IUsersClient.UsersDeleteGpgKeyForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete a GPG key for the authenticated user<br/>
        /// Removes a GPG key from the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:gpg_key` scope to use this endpoint.
        /// </summary>
        /// <param name="gpgKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UsersDeleteGpgKeyForAuthenticatedUserAsync(
            int gpgKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}