﻿//HintName: G.IAdminClient.AdminAddNewUserToAccount.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// AddNewUserToAccount.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="encryptedPass"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AdminAddNewUserToAccountAsync(
            string? token = default,
            global::System.Guid? accountId = default,
            string? username = default,
            string? firstName = default,
            string? lastName = default,
            string? email = default,
            string? phone = default,
            string? encryptedPass = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}