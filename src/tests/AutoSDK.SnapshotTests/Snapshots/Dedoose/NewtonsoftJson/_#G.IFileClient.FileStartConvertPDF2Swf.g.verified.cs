//HintName: G.IFileClient.FileStartConvertPDF2Swf.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// StartConvertPDF2Swf.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="pdfURI"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileStartConvertPDF2SwfResponse> FileStartConvertPDF2SwfAsync(
            string? token = default,
            global::System.Guid projectId = default,
            string? pdfURI = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}