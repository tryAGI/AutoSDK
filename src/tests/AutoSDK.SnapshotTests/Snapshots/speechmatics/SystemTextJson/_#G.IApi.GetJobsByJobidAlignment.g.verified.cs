//HintName: G.IApi.GetJobsByJobidAlignment.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get the aligned text file for an alignment job.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetJobsByJobidAlignmentAsync(
            string jobid,
            global::G.GetJobsAlignmentTags? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}