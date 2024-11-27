//HintName: G.IAdminClient.AddCreditsToAccountAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// AddCreditsToAccount<br/>
        /// AddCreditsToAccount
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddCreditsToAccountAsAdminAsync(
            global::G.AddCreditsToAccountRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddCreditsToAccount<br/>
        /// AddCreditsToAccount
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="credits"></param>
        /// <param name="reason"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddCreditsToAccountAsAdminAsync(
            global::System.Guid accountId,
            double credits,
            string reason,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}