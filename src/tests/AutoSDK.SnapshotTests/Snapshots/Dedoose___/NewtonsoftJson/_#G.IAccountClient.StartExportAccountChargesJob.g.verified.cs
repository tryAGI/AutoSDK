//HintName: G.IAccountClient.StartExportAccountChargesJob.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// StartExportAccountChargesJob<br/>
        /// StartExportAccountChargesJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportAccountChargesJobAsync(
            global::G.StartExportAccountChargesJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartExportAccountChargesJob<br/>
        /// StartExportAccountChargesJob
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportAccountChargesJobAsync(
            global::System.Guid accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}