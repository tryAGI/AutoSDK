//HintName: G.IFileClient.EmailFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// EmailFile<br/>
        /// EmailFile
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EmailFileAsync(
            global::G.EmailFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// EmailFile<br/>
        /// EmailFile
        /// </summary>
        /// <param name="fileURI"></param>
        /// <param name="attachmentFileName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="subject"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> EmailFileAsync(
            string fileURI,
            string attachmentFileName,
            string emailAddress,
            string subject,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}