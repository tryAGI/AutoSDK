//HintName: G.IApi.GetJobsByJobid.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get job details<br/>
        /// Get job details, including progress and any error reports.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetrieveJobResponse> GetJobsByJobidAsync(
            string jobid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}