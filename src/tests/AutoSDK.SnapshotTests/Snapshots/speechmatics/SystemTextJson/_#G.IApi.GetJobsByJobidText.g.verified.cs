//HintName: G.IApi.GetJobsByJobidText.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get the text file used as input to an alignment job.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetJobsByJobidTextAsync(
            string jobid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}