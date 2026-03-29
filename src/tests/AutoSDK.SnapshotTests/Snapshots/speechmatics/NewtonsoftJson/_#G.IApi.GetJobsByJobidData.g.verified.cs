//HintName: G.IApi.GetJobsByJobidData.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get the data file used as input to a job.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetJobsByJobidDataAsync(
            string jobid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}