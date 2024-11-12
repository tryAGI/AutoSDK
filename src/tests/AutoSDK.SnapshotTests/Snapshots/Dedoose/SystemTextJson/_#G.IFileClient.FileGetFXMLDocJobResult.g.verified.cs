//HintName: G.IFileClient.FileGetFXMLDocJobResult.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// GetFXMLDocJobResult.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> FileGetFXMLDocJobResultAsync(
            string? token = default,
            global::System.Guid? jobId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}