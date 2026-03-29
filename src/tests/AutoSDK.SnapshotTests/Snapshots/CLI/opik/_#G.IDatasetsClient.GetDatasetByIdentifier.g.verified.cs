//HintName: G.IDatasetsClient.GetDatasetByIdentifier.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get dataset by name<br/>
        /// Get dataset by name
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetPublic> GetDatasetByIdentifierAsync(

            global::G.DatasetIdentifierPublic request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get dataset by name<br/>
        /// Get dataset by name
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="projectName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetPublic> GetDatasetByIdentifierAsync(
            string datasetName,
            string? projectName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}