//HintName: G.IFileApiClient.GatewayDownloadFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFileApiClient
    {
        /// <summary>
        /// Download file<br/>
        /// Download the binary content of a file. The response will contain the file data in the appropriate MIME type.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/files/{file_id}/download \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> GatewayDownloadFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download file<br/>
        /// Download the binary content of a file. The response will contain the file data in the appropriate MIME type.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/files/{file_id}/download \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<byte[]>> GatewayDownloadFileAsResponseAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}