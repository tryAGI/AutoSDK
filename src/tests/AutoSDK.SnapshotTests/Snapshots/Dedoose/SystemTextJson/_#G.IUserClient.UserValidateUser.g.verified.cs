//HintName: G.IUserClient.UserValidateUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// ValidateUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="username"></param>
        /// <param name="passSalt"></param>
        /// <param name="connectionKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UserValidateUserAsync(
            string? token = default,
            string? username = default,
            string? passSalt = default,
            global::System.Guid? connectionKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}