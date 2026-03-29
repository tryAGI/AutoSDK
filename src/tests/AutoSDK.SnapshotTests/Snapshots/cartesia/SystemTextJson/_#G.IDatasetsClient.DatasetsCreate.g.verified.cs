//HintName: G.IDatasetsClient.DatasetsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create a new dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Dataset> DatasetsCreateAsync(
            global::G.DatasetsCreateCartesiaVersion cartesiaVersion,

            global::G.CreateDatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="name">
        /// Name for the new dataset
        /// </param>
        /// <param name="description">
        /// Optional description for the dataset
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Dataset> DatasetsCreateAsync(
            global::G.DatasetsCreateCartesiaVersion cartesiaVersion,
            string name,
            string description,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}