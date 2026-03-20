//HintName: G.IUsers2Client.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IUsers2Client
    {
        /// <summary>
        /// Create a user in the current customer account<br/>
        /// Create a user for the current customer account. For example, a company wants to onboard new team members efficiently and this endpoint lets you streamline the process by adding new users programmatically, assigning appropriate roles, and setting up access permissions.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.User, global::G.CreateUserResponse2>> CreateAsync(

            global::G.CreateUserRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a user in the current customer account<br/>
        /// Create a user for the current customer account. For example, a company wants to onboard new team members efficiently and this endpoint lets you streamline the process by adding new users programmatically, assigning appropriate roles, and setting up access permissions.
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
        /// The customer-level role names assigned to the user.
        /// </param>
        /// <param name="corpusRoles">
        /// Corpus-specific role assignments for the user.
        /// </param>
        /// <param name="agentRoles">
        /// Agent-specific role assignments for the user.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.User, global::G.CreateUserResponse2>> CreateAsync(
            string email,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? username = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles = default,
            global::System.Collections.Generic.IList<global::G.CorpusRole>? corpusRoles = default,
            global::System.Collections.Generic.IList<global::G.AgentRole>? agentRoles = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}