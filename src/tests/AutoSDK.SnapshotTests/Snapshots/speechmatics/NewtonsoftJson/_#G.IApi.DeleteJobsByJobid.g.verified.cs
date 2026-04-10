//HintName: G.IApi.DeleteJobsByJobid.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete a job<br/>
        /// Delete a job and remove all associated resources.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="force"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteJobResponse> DeleteJobsByJobidAsync(
            string jobid,
            bool? force = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}