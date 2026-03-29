//HintName: G.IParsingClient.GetParsingJobDetailsApiV1ParsingJobJobIdDetailsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Get Parsing Job Details<br/>
        /// Get detailed parsing job information including status, parameters, and telemetry.<br/>
        /// Returns comprehensive job details with:<br/>
        /// - Job status and error information<br/>
        /// - Job parameters (with sensitive API keys removed)<br/>
        /// - Job metadata (telemetry, performance metrics)<br/>
        /// - Session logs (errors, warnings, page-level details)
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetParsingJobDetailsApiV1ParsingJobJobIdDetailsGetAsync(
            string jobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}