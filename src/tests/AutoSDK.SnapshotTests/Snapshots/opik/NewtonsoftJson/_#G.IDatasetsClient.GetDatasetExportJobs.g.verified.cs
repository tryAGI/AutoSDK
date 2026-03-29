//HintName: G.IDatasetsClient.GetDatasetExportJobs.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get all dataset export jobs<br/>
        /// Retrieves all export jobs for the workspace. This is used to restore the export panel state after page refresh.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DatasetExportJobPublic>> GetDatasetExportJobsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}