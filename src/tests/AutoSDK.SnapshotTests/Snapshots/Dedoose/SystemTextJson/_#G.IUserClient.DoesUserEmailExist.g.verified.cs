//HintName: G.IUserClient.DoesUserEmailExist.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// DoesUserEmailExist<br/>
        /// DoesUserEmailExist
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> DoesUserEmailExistAsync(
            global::G.DoesUserEmailExistRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DoesUserEmailExist<br/>
        /// DoesUserEmailExist
        /// </summary>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> DoesUserEmailExistAsync(
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}