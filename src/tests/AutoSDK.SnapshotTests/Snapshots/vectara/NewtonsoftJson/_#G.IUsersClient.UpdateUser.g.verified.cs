//HintName: G.IUsersClient.UpdateUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update a user<br/>
        /// Update details about a user such as role names.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> UpdateUserAsync(
            string username,
            global::G.UpdateUserRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a user<br/>
        /// Update details about a user such as role names.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="username"></param>
        /// <param name="enabled">
        /// Indicates whether to enable or disable the user.
        /// </param>
        /// <param name="apiRoles">
        /// The new role names of the user.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> UpdateUserAsync(
            string username,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            bool? enabled = default,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}