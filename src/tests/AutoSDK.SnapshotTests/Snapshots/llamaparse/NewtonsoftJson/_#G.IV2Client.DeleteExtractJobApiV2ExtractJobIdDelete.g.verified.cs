//HintName: G.IV2Client.DeleteExtractJobApiV2ExtractJobIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Delete Extract Job<br/>
        /// Delete an extraction job and its results.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteExtractJobApiV2ExtractJobIdDeleteAsync(
            string jobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}