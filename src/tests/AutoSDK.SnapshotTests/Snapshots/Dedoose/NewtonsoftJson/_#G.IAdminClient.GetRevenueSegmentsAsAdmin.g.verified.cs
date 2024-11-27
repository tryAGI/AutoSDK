//HintName: G.IAdminClient.GetRevenueSegmentsAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetRevenueSegments<br/>
        /// GetRevenueSegments
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetRevenueSegmentsAsAdminAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}