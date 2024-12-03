//HintName: G.IUserClient.UpdateUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// UpdateUser<br/>
        /// UpdateUser
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUserAsync(
            global::G.UpdateUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateUser<br/>
        /// UpdateUser
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUserAsync(
            global::System.Guid userId,
            string firstName,
            string lastName,
            string phone,
            string email,
            string password,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}