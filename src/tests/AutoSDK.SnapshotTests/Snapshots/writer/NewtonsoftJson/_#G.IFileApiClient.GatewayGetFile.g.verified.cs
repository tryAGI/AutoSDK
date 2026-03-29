//HintName: G.IFileApiClient.GatewayGetFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFileApiClient
    {
        /// <summary>
        /// Retrieve file<br/>
        /// Retrieve detailed information about a specific file, including its metadata, status, and associated graphs.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/files/{file_id} \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.FileResponse> GatewayGetFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}