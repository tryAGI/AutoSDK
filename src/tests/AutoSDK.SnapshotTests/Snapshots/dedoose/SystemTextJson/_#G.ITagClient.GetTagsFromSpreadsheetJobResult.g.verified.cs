//HintName: G.ITagClient.GetTagsFromSpreadsheetJobResult.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// GetTagsFromSpreadsheetJobResult<br/>
        /// GetTagsFromSpreadsheetJobResult
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetTagsFromSpreadsheetJobResultAsync(
            global::G.GetTagsFromSpreadsheetJobResultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetTagsFromSpreadsheetJobResult<br/>
        /// GetTagsFromSpreadsheetJobResult
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetTagsFromSpreadsheetJobResultAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}