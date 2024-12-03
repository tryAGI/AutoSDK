//HintName: G.IUserClient.ValidateUser2.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// ValidateUser2<br/>
        /// ValidateUser2
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidateUserResult> ValidateUser2Async(
            global::G.ValidateUser2Request request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// ValidateUser2<br/>
        /// ValidateUser2
        /// </summary>
        /// <param name="username"></param>
        /// <param name="rsaEncryptedPass"></param>
        /// <param name="connectionKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidateUserResult> ValidateUser2Async(
            string username,
            string rsaEncryptedPass,
            global::System.Guid connectionKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}