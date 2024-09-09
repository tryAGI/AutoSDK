//HintName: G.FileClient.FileEmailFile.g.cs

#nullable enable

namespace G
{
    public partial class FileClient
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task FileEmailFileAsync(
            string token,
            string fileURI,
            string attachmentFileName,
            string emailAddress,
            string subject,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/file/emailfile?fileURI={fileURI}&attachmentFileName={attachmentFileName}&emailAddress={emailAddress}&subject={subject}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}