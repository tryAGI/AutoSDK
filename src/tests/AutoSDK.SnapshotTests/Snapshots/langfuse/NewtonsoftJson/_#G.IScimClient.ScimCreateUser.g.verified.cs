//HintName: G.IScimClient.ScimCreateUser.g.cs
#nullable enable

namespace G
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Create a new user in the organization (requires organization-scoped API key)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScimUser> ScimCreateUserAsync(

            global::G.ScimCreateUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new user in the organization (requires organization-scoped API key)
        /// </summary>
        /// <param name="userName">
        /// User's email address (required)
        /// </param>
        /// <param name="name"></param>
        /// <param name="emails">
        /// User's email addresses
        /// </param>
        /// <param name="active">
        /// Whether the user is active
        /// </param>
        /// <param name="password">
        /// Initial password for the user
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScimUser> ScimCreateUserAsync(
            string userName,
            global::G.ScimName name,
            global::System.Collections.Generic.IList<global::G.ScimEmail>? emails = default,
            bool? active = default,
            string? password = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}