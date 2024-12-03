//HintName: G.IUsersClient.UsersListSshSigningKeysForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List SSH signing keys for the authenticated user<br/>
        /// Lists the SSH signing keys for the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:ssh_signing_key` scope to use this endpoint.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SshSigningKey>> UsersListSshSigningKeysForAuthenticatedUserAsync(
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}