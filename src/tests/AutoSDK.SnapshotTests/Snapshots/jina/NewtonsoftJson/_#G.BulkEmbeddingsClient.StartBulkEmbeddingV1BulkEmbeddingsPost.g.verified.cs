//HintName: G.BulkEmbeddingsClient.StartBulkEmbeddingV1BulkEmbeddingsPost.g.cs

#nullable enable

namespace G
{
    public partial class BulkEmbeddingsClient
    {
        partial void PrepareStartBulkEmbeddingV1BulkEmbeddingsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.BodyStartBulkEmbeddingV1BulkEmbeddingsPost request);
        partial void PrepareStartBulkEmbeddingV1BulkEmbeddingsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.BodyStartBulkEmbeddingV1BulkEmbeddingsPost request);
        partial void ProcessStartBulkEmbeddingV1BulkEmbeddingsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStartBulkEmbeddingV1BulkEmbeddingsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Start Bulk Embedding<br/>
        /// Upload a file and get embeddings for each row
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BulkEmbeddingJobResponse> StartBulkEmbeddingV1BulkEmbeddingsPostAsync(
            global::G.BodyStartBulkEmbeddingV1BulkEmbeddingsPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStartBulkEmbeddingV1BulkEmbeddingsPostArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/bulk-embeddings",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>()),
                name: "file",
                fileName: request.Filename ?? string.Empty);
            if (request.Email != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Email}"),
                    name: "email");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Model}"),
                name: "model");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareStartBulkEmbeddingV1BulkEmbeddingsPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessStartBulkEmbeddingV1BulkEmbeddingsPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessStartBulkEmbeddingV1BulkEmbeddingsPostResponseContent(
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

                return
                    global::G.BulkEmbeddingJobResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                using var __content = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                return
                    await global::G.BulkEmbeddingJobResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Start Bulk Embedding<br/>
        /// Upload a file and get embeddings for each row
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="email"></param>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BulkEmbeddingJobResponse> StartBulkEmbeddingV1BulkEmbeddingsPostAsync(
            byte[] file,
            string filename,
            string model,
            string? email = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyStartBulkEmbeddingV1BulkEmbeddingsPost
            {
                File = file,
                Filename = filename,
                Email = email,
                Model = model,
            };

            return await StartBulkEmbeddingV1BulkEmbeddingsPostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}