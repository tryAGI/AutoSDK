//HintName: G.IUserClient.UserUpdateUserInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// UpdateUserInfo.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="country"></param>
        /// <param name="zip"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UserUpdateUserInfoAsync(
            string? token = default,
            global::System.Guid? userId = default,
            string? firstName = default,
            string? lastName = default,
            string? email = default,
            string? phone = default,
            string? address = default,
            string? city = default,
            string? state = default,
            string? country = default,
            string? zip = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}