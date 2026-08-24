//HintName: G.IApi.GetJobsByJobidObjectUrlsAsBytes.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get object URLs<br/>
        /// Get signed urls for data files associated to the job.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="ttl"></param>
        /// <param name="urlFor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetJobsByJobidObjectUrlsAsBytesAsync(
            string jobid,
            int ttl,
            global::System.Collections.Generic.IList<global::G.GetJobsObjectUrlsUrlForItem> urlFor,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get object URLs<br/>
        /// Get signed urls for data files associated to the job.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="ttl"></param>
        /// <param name="urlFor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetJobsByJobidObjectUrlsAsBytesAsStreamAsync(
            string jobid,
            int ttl,
            global::System.Collections.Generic.IList<global::G.GetJobsObjectUrlsUrlForItem> urlFor,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get object URLs<br/>
        /// Get signed urls for data files associated to the job.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="ttl"></param>
        /// <param name="urlFor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<byte[]>> GetJobsByJobidObjectUrlsAsBytesAsResponseAsync(
            string jobid,
            int ttl,
            global::System.Collections.Generic.IList<global::G.GetJobsObjectUrlsUrlForItem> urlFor,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}