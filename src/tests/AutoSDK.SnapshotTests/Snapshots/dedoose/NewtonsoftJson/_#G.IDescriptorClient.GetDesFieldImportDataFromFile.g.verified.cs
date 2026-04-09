//HintName: G.IDescriptorClient.GetDesFieldImportDataFromFile.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// GetDesFieldImportDataFromFile<br/>
        /// GetDesFieldImportDataFromFile
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetDesFieldImportDataFromFileAsync(

            global::G.GetDesFieldImportDataFromFileRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// GetDesFieldImportDataFromFile<br/>
        /// GetDesFieldImportDataFromFile
        /// </summary>
        /// <param name="relativeFileURL"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetDesFieldImportDataFromFileAsync(
            string relativeFileURL,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}