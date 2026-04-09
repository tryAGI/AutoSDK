//HintName: G.IResourceClient.StartExportDocumentJobWithRTL.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// StartExportDocumentJobWithRTL<br/>
        /// StartExportDocumentJobWithRTL
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportDocumentJobWithRTLAsync(

            global::G.StartExportDocumentJobWithRTLRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// StartExportDocumentJobWithRTL<br/>
        /// StartExportDocumentJobWithRTL
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="includeExRegions"></param>
        /// <param name="rtl"></param>
        /// <param name="exportExtension"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportDocumentJobWithRTLAsync(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            bool includeExRegions,
            bool rtl,
            string exportExtension,
            string encryptedSymKey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}