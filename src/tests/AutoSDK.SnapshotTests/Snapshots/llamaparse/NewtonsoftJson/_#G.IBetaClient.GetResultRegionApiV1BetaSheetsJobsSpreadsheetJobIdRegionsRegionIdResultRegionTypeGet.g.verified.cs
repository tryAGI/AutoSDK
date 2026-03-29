//HintName: G.IBetaClient.GetResultRegionApiV1BetaSheetsJobsSpreadsheetJobIdRegionsRegionIdResultRegionTypeGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Get Result Region<br/>
        /// Generate a presigned URL to download a specific extracted region.<br/>
        /// Experimental: This endpoint is not yet ready for production use and is subject to change at any time.
        /// </summary>
        /// <param name="spreadsheetJobId"></param>
        /// <param name="regionId"></param>
        /// <param name="regionType"></param>
        /// <param name="expiresAtSeconds"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PresignedUrl> GetResultRegionApiV1BetaSheetsJobsSpreadsheetJobIdRegionsRegionIdResultRegionTypeGetAsync(
            string spreadsheetJobId,
            string regionId,
            global::G.SpreadsheetResultType regionType,
            int? expiresAtSeconds = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}