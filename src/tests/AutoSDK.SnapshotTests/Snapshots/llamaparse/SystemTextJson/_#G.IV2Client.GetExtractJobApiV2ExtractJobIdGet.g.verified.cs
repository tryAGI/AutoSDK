//HintName: G.IV2Client.GetExtractJobApiV2ExtractJobIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Get Extract Job<br/>
        /// Get a single extraction job by ID.<br/>
        /// Returns the job status and results when complete.<br/>
        /// Use `expand=configuration` to include the full configuration used,<br/>
        /// and `expand=extract_metadata` for per-field metadata.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="expand">
        /// Additional fields to include: configuration, extract_metadata
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractV2Job> GetExtractJobApiV2ExtractJobIdGetAsync(
            string jobId,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}