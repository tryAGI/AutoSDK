//HintName: G.IUserClient.ValidateUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// ValidateUser<br/>
        /// ValidateUser
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ValidateUserAsync(
            global::G.ValidateUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// ValidateUser<br/>
        /// ValidateUser
        /// </summary>
        /// <param name="username"></param>
        /// <param name="passSalt"></param>
        /// <param name="connectionKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ValidateUserAsync(
            string username,
            string passSalt,
            global::System.Guid connectionKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}