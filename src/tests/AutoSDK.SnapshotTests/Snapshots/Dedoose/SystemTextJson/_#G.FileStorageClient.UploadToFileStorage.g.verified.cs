//HintName: G.FileStorageClient.UploadToFileStorage.g.cs

#nullable enable

namespace G
{
    public partial class FileStorageClient
    {
        partial void PrepareUploadToFileStorageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? name,
            ref global::System.Guid? projectId,
            ref int? uploadType,
            byte[] request);
        partial void PrepareUploadToFileStorageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? name,
            global::System.Guid? projectId,
            int? uploadType,
            byte[] request);
        partial void ProcessUploadToFileStorageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadToFileStorageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Returns data path.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="uploadType"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> UploadToFileStorageAsync(
            byte[] request,
            string? token = default,
            string? name = default,
            global::System.Guid? projectId = default,
            int? uploadType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadToFileStorageArguments(
                httpClient: HttpClient,
                token: ref token,
                name: ref name,
                projectId: ref projectId,
                uploadType: ref uploadType,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/uploadtofilestorage",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("name", name) 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("uploadType", uploadType?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }

            var __httpRequestContentBody = global::System.Convert.ToBase64String(request);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/octet-stream");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUploadToFileStorageRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                name: name,
                projectId: projectId,
                uploadType: uploadType,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUploadToFileStorageResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Token is null.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                string? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::System.Text.Json.JsonSerializer.DeserializeAsync<string?>(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Token is invalid.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                string? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::System.Text.Json.JsonSerializer.DeserializeAsync<string?>(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUploadToFileStorageResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return __content;
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                return __content;
            }
        }
    }
}