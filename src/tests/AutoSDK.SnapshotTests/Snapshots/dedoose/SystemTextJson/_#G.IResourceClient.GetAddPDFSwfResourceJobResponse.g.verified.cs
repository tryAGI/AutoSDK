//HintName: G.IResourceClient.GetAddPDFSwfResourceJobResponse.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// GetAddPDFSwfResourceJobResponse<br/>
        /// GetAddPDFSwfResourceJobResponse
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Resource> GetAddPDFSwfResourceJobResponseAsync(
            global::G.GetAddPDFSwfResourceJobResponseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetAddPDFSwfResourceJobResponse<br/>
        /// GetAddPDFSwfResourceJobResponse
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Resource> GetAddPDFSwfResourceJobResponseAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}