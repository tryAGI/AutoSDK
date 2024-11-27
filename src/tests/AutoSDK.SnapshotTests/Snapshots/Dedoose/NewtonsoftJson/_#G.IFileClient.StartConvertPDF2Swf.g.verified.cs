//HintName: G.IFileClient.StartConvertPDF2Swf.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// StartConvertPDF2Swf<br/>
        /// StartConvertPDF2Swf
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartConvertPDF2SwfAsync(
            global::G.StartConvertPDF2SwfRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartConvertPDF2Swf<br/>
        /// StartConvertPDF2Swf
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="pdfURI"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartConvertPDF2SwfAsync(
            global::System.Guid projectId,
            string pdfURI,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}