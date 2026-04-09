//HintName: G.IFilesClient.UploadFileFromUrlApiV1FilesUploadFromUrlPut.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload File From Url<br/>
        /// Upload a file from a URL.<br/>
        /// The server fetches the file from the provided URL and stores it.<br/>
        /// If `name` is omitted, the filename is derived from the response<br/>
        /// Content-Disposition header or the URL path.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.File> UploadFileFromUrlApiV1FilesUploadFromUrlPutAsync(

            global::G.FileCreateFromUrl request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File From Url<br/>
        /// Upload a file from a URL.<br/>
        /// The server fetches the file from the provided URL and stores it.<br/>
        /// If `name` is omitted, the filename is derived from the response<br/>
        /// Content-Disposition header or the URL path.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// Name that will be used for created file. If possible, always include the file extension in the name.
        /// </param>
        /// <param name="url">
        /// URL of the file to download
        /// </param>
        /// <param name="proxyUrl">
        /// URL of the proxy server to use for downloading the file
        /// </param>
        /// <param name="requestHeaders">
        /// Headers to include in the request when downloading the file
        /// </param>
        /// <param name="verifySsl">
        /// Whether to verify the SSL certificate when downloading the file<br/>
        /// Default Value: true
        /// </param>
        /// <param name="followRedirects">
        /// Whether to follow redirects when downloading the file<br/>
        /// Default Value: true
        /// </param>
        /// <param name="resourceInfo">
        /// Resource information for the file
        /// </param>
        /// <param name="storageType">
        /// Storage type for the file. Valid values: 'Ephemeral', 'Permanent' (no expiration). If not specified, defaults to permanent storage.<br/>
        /// Default Value: permanent
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.File> UploadFileFromUrlApiV1FilesUploadFromUrlPutAsync(
            string url,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? name = default,
            string? proxyUrl = default,
            global::System.Collections.Generic.Dictionary<string, string>? requestHeaders = default,
            bool? verifySsl = default,
            bool? followRedirects = default,
            object? resourceInfo = default,
            global::G.AnyOf<global::G.FileCreateFromUrlStorageType?, string>? storageType = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}