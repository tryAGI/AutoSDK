//HintName: G.IApi.GetJobsByJobidLog.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get the log file for a job.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetJobsByJobidLogAsync(
            string jobid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}