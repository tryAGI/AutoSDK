//HintName: G.IUserClient.DoesUserExist.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// DoesUserExist<br/>
        /// DoesUserExist
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> DoesUserExistAsync(
            global::G.DoesUserExistRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DoesUserExist<br/>
        /// DoesUserExist
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> DoesUserExistAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}