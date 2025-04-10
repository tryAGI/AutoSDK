//HintName: G.IDashboardClient.GetTotalNetworkVolumeForDashboard.g.cs
#nullable enable

namespace G
{
    public partial interface IDashboardClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTotalNetworkVolumeResponseDto> GetTotalNetworkVolumeForDashboardAsync(
            long? userId = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}