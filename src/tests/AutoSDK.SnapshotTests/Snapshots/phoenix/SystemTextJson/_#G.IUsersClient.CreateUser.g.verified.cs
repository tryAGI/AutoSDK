//HintName: G.IUsersClient.CreateUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create a new user<br/>
        /// Create a new user with the specified configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateUserResponseBody> CreateUserAsync(

            global::G.CreateUserRequestBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new user<br/>
        /// Create a new user with the specified configuration.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="sendWelcomeEmail">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateUserResponseBody> CreateUserAsync(
            global::G.User user,
            bool? sendWelcomeEmail = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}