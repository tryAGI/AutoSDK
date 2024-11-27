//HintName: G.IAccountClient.UpdateAccountUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// UpdateAccountUser<br/>
        /// UpdateAccountUser
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> UpdateAccountUserAsync(
            global::G.UpdateAccountUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateAccountUser<br/>
        /// UpdateAccountUser
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="active"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> UpdateAccountUserAsync(
            global::System.Guid userId,
            string firstName,
            string lastName,
            string phone,
            string email,
            bool active,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}