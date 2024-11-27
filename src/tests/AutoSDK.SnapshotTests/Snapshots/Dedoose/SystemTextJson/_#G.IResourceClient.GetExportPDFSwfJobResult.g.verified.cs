//HintName: G.IResourceClient.GetExportPDFSwfJobResult.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// GetExportPDFSwfJobResult<br/>
        /// GetExportPDFSwfJobResult
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetExportPDFSwfJobResultAsync(
            global::G.GetExportPDFSwfJobResultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetExportPDFSwfJobResult<br/>
        /// GetExportPDFSwfJobResult
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetExportPDFSwfJobResultAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}