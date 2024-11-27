//HintName: G.IAdminClient.CreateAccountAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// CreateAccount<br/>
        /// CreateAccount
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAccountAsAdminAsync(
            global::G.CreateAccountRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// CreateAccount<br/>
        /// CreateAccount
        /// </summary>
        /// <param name="adminId"></param>
        /// <param name="credits"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAccountAsAdminAsync(
            global::System.Guid adminId,
            double credits,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}