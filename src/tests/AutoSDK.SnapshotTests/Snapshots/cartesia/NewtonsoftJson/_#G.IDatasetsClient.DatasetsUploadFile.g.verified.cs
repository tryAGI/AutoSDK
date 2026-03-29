//HintName: G.IDatasetsClient.DatasetsUploadFile.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Upload a new file to a dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DatasetsUploadFileAsync(
            global::G.DatasetsUploadFileCartesiaVersion cartesiaVersion,
            string id,

            global::G.DatasetsUploadFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a new file to a dataset
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="purpose">
        /// Purpose of the file (e.g., fine_tune)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DatasetsUploadFileAsync(
            global::G.DatasetsUploadFileCartesiaVersion cartesiaVersion,
            string id,
            byte[]? file = default,
            string? filename = default,
            string? purpose = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}