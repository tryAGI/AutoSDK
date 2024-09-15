//HintName: G.IAccountClient.AccountStartExportAccountProjectSummaryJob.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// StartExportAccountProjectSummaryJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AccountStartExportAccountProjectSummaryJobAsync(
            string? token = default,
            global::System.Guid accountId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}