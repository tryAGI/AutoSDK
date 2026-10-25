//HintName: G.IApi.GetJobsByJobidTranscriptAsBytes.g.cs
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
        global::System.Threading.Tasks.Task<byte[]> GetJobsByJobidTranscriptAsBytesAsync(
            string jobid,
            global::G.GetJobsTranscriptFormat? format = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the transcript for a transcription job
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="format"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetJobsByJobidTranscriptAsBytesAsStreamAsync(
            string jobid,
            global::G.GetJobsTranscriptFormat? format = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the transcript for a transcription job
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="format"></param>
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::System.IO.Stream>> GetJobsByJobidTranscriptAsBytesAsStreamAsResponseAsync(
            string jobid,
            global::G.GetJobsTranscriptFormat? format = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the transcript for a transcription job
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="format"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<byte[]>> GetJobsByJobidTranscriptAsBytesAsResponseAsync(
            string jobid,
            global::G.GetJobsTranscriptFormat? format = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}