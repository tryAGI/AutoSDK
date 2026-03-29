//HintName: G.IDatasetsClient.ApiDatasetsImportPartialUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Export candidate tasks to project<br/>
        /// Export Candidate task for a specific dataset to project.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="signal"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetsImportPartialUpdateAsync(
            int? jobId = default,
            string? signal = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}