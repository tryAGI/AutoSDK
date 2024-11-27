//HintName: G.IUserClient.UpdateUserInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// UpdateUserInfo<br/>
        /// UpdateUserInfo
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUserInfoAsync(
            global::G.UpdateUserInfoRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateUserInfo<br/>
        /// UpdateUserInfo
        /// </summary>
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUserInfoAsync(
            global::System.Guid userId,
            string firstName,
            string lastName,
            string email,
            string phone,
            string address,
            string city,
            string state,
            string country,
            string zip,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}