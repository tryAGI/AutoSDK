//HintName: G.IFileClient.FileEmailFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// EmailFile.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="fileURI"></param>
        /// <param name="attachmentFileName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="subject"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> FileEmailFileAsync(
            string? token = default,
            string? fileURI = default,
            string? attachmentFileName = default,
            string? emailAddress = default,
            string? subject = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}