//HintName: G.ISystemUsageClient.GetDatasetBiInfo.g.cs
#nullable enable

namespace G
{
    public partial interface ISystemUsageClient
    {
        /// <summary>
        /// Get datasets information for BI events<br/>
        /// Get datasets information for BI events per user per workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BiInformationResponse> GetDatasetBiInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}