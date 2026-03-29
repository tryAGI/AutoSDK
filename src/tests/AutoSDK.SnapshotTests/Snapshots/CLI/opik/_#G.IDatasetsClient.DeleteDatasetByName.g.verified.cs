//HintName: G.IDatasetsClient.DeleteDatasetByName.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete dataset by name<br/>
        /// Delete dataset by name
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDatasetByNameAsync(

            global::G.DatasetIdentifier request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete dataset by name<br/>
        /// Delete dataset by name
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="projectName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteDatasetByNameAsync(
            string datasetName,
            string? projectName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}