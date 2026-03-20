//HintName: G.IFilesClient.FilesApiRoutesGetSignedUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Get Signed Url
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="expiry">
        /// Number of hours before the url becomes invalid. Defaults to 24h<br/>
        /// Default Value: 24
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileSignedURL> FilesApiRoutesGetSignedUrlAsync(
            global::System.Guid fileId,
            int? expiry = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}