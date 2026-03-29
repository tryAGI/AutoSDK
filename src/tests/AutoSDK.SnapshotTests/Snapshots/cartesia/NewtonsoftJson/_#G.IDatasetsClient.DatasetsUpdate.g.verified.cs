//HintName: G.IDatasetsClient.DatasetsUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update an existing dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DatasetsUpdateAsync(
            global::G.DatasetsUpdateCartesiaVersion cartesiaVersion,
            string id,

            global::G.UpdateDatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="name">
        /// New name for the dataset
        /// </param>
        /// <param name="description">
        /// New description for the dataset
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DatasetsUpdateAsync(
            global::G.DatasetsUpdateCartesiaVersion cartesiaVersion,
            string id,
            string name,
            string description,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}