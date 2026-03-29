//HintName: G.IDatasetsClient.DatasetsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete a dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DatasetsDeleteAsync(
            global::G.DatasetsDeleteCartesiaVersion cartesiaVersion,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}