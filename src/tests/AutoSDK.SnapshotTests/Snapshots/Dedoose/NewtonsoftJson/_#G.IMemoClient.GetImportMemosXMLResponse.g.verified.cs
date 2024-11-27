//HintName: G.IMemoClient.GetImportMemosXMLResponse.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// GetImportMemosXMLResponse<br/>
        /// GetImportMemosXMLResponse
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetImportMemosXMLResponseAsync(
            global::G.GetImportMemosXMLResponseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetImportMemosXMLResponse<br/>
        /// GetImportMemosXMLResponse
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetImportMemosXMLResponseAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}