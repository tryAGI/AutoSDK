//HintName: G.IApi.GetJobsByJobidTranscript.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get the transcript for a transcription job
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="format"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetrieveTranscriptResponse> GetJobsByJobidTranscriptAsync(
            string jobid,
            global::G.GetJobsTranscriptFormat? format = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}