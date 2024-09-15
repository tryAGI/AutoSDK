//HintName: G.IDatasetsClient.GetDatasetVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get Dataset Versions<br/>
        /// Get dataset versions.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="search"></param>
        /// <param name="example"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DatasetVersion>> GetDatasetVersionsAsync(
            global::System.Guid datasetId,
            global::G.AnyOf<string, object>? search = default,
            global::G.AnyOf<global::System.Guid?, object>? example = default,
            int limit = 100,
            int offset = 0,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}