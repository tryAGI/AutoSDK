//HintName: G.IApi.GetJobsByJobidObjectUrls.g.cs
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetrieveObjectUrlsResponse> GetJobsByJobidObjectUrlsAsync(
            string jobid,
            int ttl,
            global::System.Collections.Generic.IList<global::G.GetJobsObjectUrlsUrlForItem> urlFor,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}