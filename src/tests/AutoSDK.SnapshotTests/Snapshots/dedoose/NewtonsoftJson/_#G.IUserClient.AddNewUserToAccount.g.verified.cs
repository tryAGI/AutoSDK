//HintName: G.IUserClient.AddNewUserToAccount.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// AddNewUserToAccount<br/>
        /// AddNewUserToAccount
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddNewUserToAccountResponse> AddNewUserToAccountAsync(

            global::G.AddNewUserToAccountRequest2 request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AddNewUserToAccount<br/>
        /// AddNewUserToAccount
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="encryptedPass"></param>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddNewUserToAccountResponse> AddNewUserToAccountAsync(
            global::System.Guid projectId,
            string username,
            string firstName,
            string lastName,
            string email,
            string phone,
            string encryptedPass,
            global::System.Guid? groupId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}