//HintName: G.IDatasetsClient.DatasetsDeleteFile.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Remove a file from a dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="fileID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DatasetsDeleteFileAsync(
            global::G.DatasetsDeleteFileCartesiaVersion cartesiaVersion,
            string id,
            string fileID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}