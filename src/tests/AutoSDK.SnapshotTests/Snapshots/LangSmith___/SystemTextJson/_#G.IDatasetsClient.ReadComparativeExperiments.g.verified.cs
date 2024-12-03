//HintName: G.IDatasetsClient.ReadComparativeExperiments.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Read Comparative Experiments<br/>
        /// Get all comparative experiments for a given dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="id"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="sortBy">
        /// Enum for available comparative experiment columns to sort by.
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ComparativeExperiment>> ReadComparativeExperimentsAsync(
            global::System.Guid datasetId,
            string? name = default,
            string? nameContains = default,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            int? offset = default,
            int? limit = default,
            global::G.SortByComparativeExperimentColumn? sortBy = default,
            bool? sortByDesc = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}