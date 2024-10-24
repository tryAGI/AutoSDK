//HintName: G.IDatasetsClient.ShareDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Share Dataset<br/>
        /// Share a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="shareProjects">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetShareSchema> ShareDatasetAsync(
            global::System.Guid datasetId,
            bool? shareProjects = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}