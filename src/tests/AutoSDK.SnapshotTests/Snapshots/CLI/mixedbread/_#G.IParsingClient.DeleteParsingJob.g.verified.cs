//HintName: G.IParsingClient.DeleteParsingJob.g.cs
#nullable enable

namespace G
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Delete a parsing job<br/>
        /// Delete a specific parse job.<br/>
        /// Args:<br/>
        ///     job_id: The ID of the parse job to delete.<br/>
        /// Returns:<br/>
        ///     The deleted parsing job.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the parse job to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParsingJobDeleted> DeleteParsingJobAsync(
            global::System.Guid jobId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}