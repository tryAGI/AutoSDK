//HintName: G.FileClient.FileEmailFile.g.cs

#nullable enable

namespace G
{
    public partial class FileClient
    {
        partial void PrepareFileEmailFileArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? fileURI,
            ref string? attachmentFileName,
            ref string? emailAddress,
            ref string? subject);
        partial void PrepareFileEmailFileRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? fileURI,
            string? attachmentFileName,
            string? emailAddress,
            string? subject);
        partial void ProcessFileEmailFileResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFileEmailFileResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::G.FileEmailFileResponse> FileEmailFileAsync(
            string? token = default,
            string? fileURI = default,
            string? attachmentFileName = default,
            string? emailAddress = default,
            string? subject = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareFileEmailFileArguments(
                httpClient: _httpClient,
                token: ref token,
                fileURI: ref fileURI,
                attachmentFileName: ref attachmentFileName,
                emailAddress: ref emailAddress,
                subject: ref subject);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/file/emailfile?fileURI={fileURI}&attachmentFileName={attachmentFileName}&emailAddress={emailAddress}&subject={subject}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareFileEmailFileRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                fileURI: fileURI,
                attachmentFileName: attachmentFileName,
                emailAddress: emailAddress,
                subject: subject);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessFileEmailFileResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessFileEmailFileResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileEmailFileResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}