//HintName: G.IDatasetsClient.CreateDatasetItemsFromCsv.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create dataset items from CSV file<br/>
        /// Create dataset items from uploaded CSV file. CSV should have headers in the first row. Processing happens asynchronously in batches.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetItemsFromCsvAsync(

            global::G.CreateDatasetItemsFromCsvRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dataset items from CSV file<br/>
        /// Create dataset items from uploaded CSV file. CSV should have headers in the first row. Processing happens asynchronously in batches.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetItemsFromCsvAsync(
            object file,
            global::System.Guid datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}