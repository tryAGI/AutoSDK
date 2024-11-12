//HintName: G.IUserClient.UserUpdateUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// UpdateUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UserUpdateUserAsync(
            string? token = default,
            global::System.Guid? userId = default,
            string? firstName = default,
            string? lastName = default,
            string? phone = default,
            string? email = default,
            string? password = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}