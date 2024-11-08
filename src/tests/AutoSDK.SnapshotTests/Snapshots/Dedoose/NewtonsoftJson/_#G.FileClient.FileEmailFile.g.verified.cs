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
        public async global::System.Threading.Tasks.Task<string> FileEmailFileAsync(
            string? token = default,
            string? fileURI = default,
            string? attachmentFileName = default,
            string? emailAddress = default,
            string? subject = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFileEmailFileArguments(
                httpClient: HttpClient,
                token: ref token,
                fileURI: ref fileURI,
                attachmentFileName: ref attachmentFileName,
                emailAddress: ref emailAddress,
                subject: ref subject);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/file/emailfile",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("fileURI", fileURI) 
                .AddOptionalParameter("attachmentFileName", attachmentFileName) 
                .AddOptionalParameter("emailAddress", emailAddress) 
                .AddOptionalParameter("subject", subject) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareFileEmailFileRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                fileURI: fileURI,
                attachmentFileName: attachmentFileName,
                emailAddress: emailAddress,
                subject: subject);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFileEmailFileResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessFileEmailFileResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::System.InvalidOperationException(__content, __ex);
                }

                    return __content;
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

            using var __streamReader = new global::System.IO.StreamReader(__responseStream);
            using var __jsonReader = new global::Newtonsoft.Json.JsonTextReader(__streamReader);
            var __serializer = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions);
            var __responseValue = __serializer.Deserialize<string?>(__jsonReader);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}