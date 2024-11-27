//HintName: G.IFileClient.GetFXMLDocJobResult.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// GetFXMLDocJobResult<br/>
        /// GetFXMLDocJobResult
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFXMLDocJobResultAsync(
            global::G.GetFXMLDocJobResultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetFXMLDocJobResult<br/>
        /// GetFXMLDocJobResult
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetFXMLDocJobResultAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}