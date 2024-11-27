//HintName: G.IAccountClient.StartExportAccountPaymentsJob.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// StartExportAccountPaymentsJob<br/>
        /// StartExportAccountPaymentsJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportAccountPaymentsJobAsync(
            global::G.StartExportAccountPaymentsJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartExportAccountPaymentsJob<br/>
        /// StartExportAccountPaymentsJob
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportAccountPaymentsJobAsync(
            global::System.Guid accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}