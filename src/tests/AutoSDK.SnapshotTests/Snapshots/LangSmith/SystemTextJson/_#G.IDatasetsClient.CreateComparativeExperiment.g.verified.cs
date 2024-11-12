//HintName: G.IDatasetsClient.CreateComparativeExperiment.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create Comparative Experiment<br/>
        /// Create a comparative experiment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ComparativeExperimentBase> CreateComparativeExperimentAsync(
            global::G.ComparativeExperimentCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Comparative Experiment<br/>
        /// Create a comparative experiment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="experimentIds"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="extra"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ComparativeExperimentBase> CreateComparativeExperimentAsync(
            global::System.Collections.Generic.IList<global::System.Guid> experimentIds,
            global::System.Guid referenceDatasetId,
            global::System.Guid? id = default,
            string? name = default,
            string? description = default,
            global::System.DateTime? createdAt = default,
            global::System.DateTime? modifiedAt = default,
            object? extra = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}