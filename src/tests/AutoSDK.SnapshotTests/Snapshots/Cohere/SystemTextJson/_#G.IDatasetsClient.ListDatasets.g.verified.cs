//HintName: G.IDatasetsClient.ListDatasets.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List Datasets<br/>
        /// List datasets that have been created.
        /// </summary>
        /// <param name="datasetType"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="validationStatus">
        /// The validation status of the dataset
        /// </param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListDatasetsResponse> ListDatasetsAsync(
            string? datasetType = default,
            global::System.DateTime before = default,
            global::System.DateTime after = default,
            double limit = default,
            double offset = default,
            global::G.DatasetValidationStatus? validationStatus = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}