//HintName: G.IAdminClient.AdminAddCreditsToAccount.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// AddCreditsToAccount.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="credits"></param>
        /// <param name="reason"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AdminAddCreditsToAccountAsync(
            string? token = default,
            global::System.Guid? accountId = default,
            double? credits = default,
            string? reason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}