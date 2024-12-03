//HintName: G.IAdminClient.SetAccountCPUPMOverrideAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// SetAccountCPUPMOverride<br/>
        /// SetAccountCPUPMOverride
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetAccountCPUPMOverrideAsAdminAsync(
            global::G.SetAccountCPUPMOverrideRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// SetAccountCPUPMOverride<br/>
        /// SetAccountCPUPMOverride
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cpupmOverride"></param>
        /// <param name="endDate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetAccountCPUPMOverrideAsAdminAsync(
            global::System.Guid accountId,
            double cpupmOverride,
            global::System.DateTime endDate,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}