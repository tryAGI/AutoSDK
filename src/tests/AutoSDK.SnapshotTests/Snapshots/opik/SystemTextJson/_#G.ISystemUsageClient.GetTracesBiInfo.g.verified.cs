//HintName: G.ISystemUsageClient.GetTracesBiInfo.g.cs
#nullable enable

namespace G
{
    public partial interface ISystemUsageClient
    {
        /// <summary>
        /// Get traces information for BI events<br/>
        /// Get traces information for BI events per user per workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BiInformationResponse> GetTracesBiInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}