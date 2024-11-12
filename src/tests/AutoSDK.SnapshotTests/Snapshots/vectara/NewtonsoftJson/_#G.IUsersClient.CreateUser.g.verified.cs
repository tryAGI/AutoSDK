//HintName: G.IUsersClient.CreateUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create a user in the current customer account<br/>
        /// Create a user for the current customer account.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> CreateUserAsync(
            global::G.CreateUserRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a user in the current customer account<br/>
        /// Create a user for the current customer account.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="email">
        /// The email address for the user.
        /// </param>
        /// <param name="username">
        /// The username for the user. The value defaults to the email.
        /// </param>
        /// <param name="description">
        /// The description of the user.
        /// </param>
        /// <param name="apiRoles">
        /// The role names assigned to the user.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> CreateUserAsync(
            string email,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? username = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}