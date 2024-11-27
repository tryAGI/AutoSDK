//HintName: G.IAdminClient.AddNewUserToAccountAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// AddNewUserToAccount<br/>
        /// AddNewUserToAccount
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddNewUserToAccountAsAdminAsync(
            global::G.AddNewUserToAccountRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddNewUserToAccount<br/>
        /// AddNewUserToAccount
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="encryptedPass"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddNewUserToAccountAsAdminAsync(
            global::System.Guid accountId,
            string username,
            string firstName,
            string lastName,
            string email,
            string phone,
            string encryptedPass,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}