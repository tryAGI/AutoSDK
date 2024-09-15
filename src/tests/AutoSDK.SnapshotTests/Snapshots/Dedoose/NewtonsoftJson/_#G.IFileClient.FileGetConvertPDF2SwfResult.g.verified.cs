//HintName: G.IFileClient.FileGetConvertPDF2SwfResult.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// GetConvertPDF2SwfResult.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileGetConvertPDF2SwfResultResponse> FileGetConvertPDF2SwfResultAsync(
            string? token = default,
            global::System.Guid jobId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}