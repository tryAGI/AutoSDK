//HintName: G.IUsers2Client.List.g.cs
#nullable enable

namespace G
{
    public partial interface IUsers2Client
    {
        /// <summary>
        /// List users in the account<br/>
        /// The List Users API lets you list all users on your team and also their corpus access and customer-level authorizations.<br/>
        /// Other activities such as adding, deleting, enabling, disabling, resetting passwords, and editing user roles are performed by the [Update User](/docs/rest-api/update-user) endpoint.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListUsersResponse> ListAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? pageKey = default,
            string? corpusKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}