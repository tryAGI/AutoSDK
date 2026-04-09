//HintName: G.IBetaClient.GetSpreadsheetJobApiV1BetaSheetsJobsSpreadsheetJobIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Get Spreadsheet Job<br/>
        /// Get a spreadsheet parsing job.<br/>
        /// When include_results=True (default), the response will include extracted regions and results<br/>
        /// if the job is complete, eliminating the need for a separate /results call.<br/>
        /// Experimental: This endpoint is not yet ready for production use and is subject to change at any time.
        /// </summary>
        /// <param name="spreadsheetJobId"></param>
        /// <param name="includeResults">
        /// Default Value: true
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpreadsheetJob> GetSpreadsheetJobApiV1BetaSheetsJobsSpreadsheetJobIdGetAsync(
            string spreadsheetJobId,
            bool? includeResults = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}