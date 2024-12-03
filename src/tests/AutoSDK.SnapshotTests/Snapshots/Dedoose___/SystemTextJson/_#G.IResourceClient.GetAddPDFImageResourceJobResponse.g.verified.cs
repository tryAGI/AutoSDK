//HintName: G.IResourceClient.GetAddPDFImageResourceJobResponse.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// GetAddPDFImageResourceJobResponse<br/>
        /// GetAddPDFImageResourceJobResponse
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetAddPDFImageResourceJobResponseAsync(
            global::G.GetAddPDFImageResourceJobResponseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetAddPDFImageResourceJobResponse<br/>
        /// GetAddPDFImageResourceJobResponse
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetAddPDFImageResourceJobResponseAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}