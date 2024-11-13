//HintName: G.EmbedJobsClient.CreateEmbedJob.g.cs

#nullable enable

namespace G
{
    public partial class EmbedJobsClient
    {
        partial void PrepareCreateEmbedJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::G.CreateEmbedJobRequest request);
        partial void PrepareCreateEmbedJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.CreateEmbedJobRequest request);
        partial void ProcessCreateEmbedJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateEmbedJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an Embed Job<br/>
        /// This API launches an async Embed job for a [Dataset](https://docs.cohere.com/docs/datasets) of type `embed-input`. The result of a completed embed job is new Dataset of type `embed-output`, which contains the original text entries and the corresponding embeddings.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateEmbedJobResponse> CreateEmbedJobAsync(
            global::G.CreateEmbedJobRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateEmbedJobArguments(
                httpClient: HttpClient,
                xClientName: ref xClientName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/embed-jobs",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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

            if (xClientName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateEmbedJobRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xClientName: xClientName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateEmbedJobResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // This error is returned when the request is not well formed. This could be because:   - JSON is invalid   - The request is missing required fields   - The request contains an invalid combination of fields 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::G.CreateEmbedJobResponse2? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::G.CreateEmbedJobResponse2.FromJson(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::G.CreateEmbedJobResponse2.FromJsonStreamAsync(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CreateEmbedJobResponse2>(
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
            // This error indicates that the operation attempted to be performed is not allowed. This could be because:   - The api token is invalid   - The user does not have the necessary permissions 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::G.CreateEmbedJobResponse3? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::G.CreateEmbedJobResponse3.FromJson(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::G.CreateEmbedJobResponse3.FromJsonStreamAsync(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CreateEmbedJobResponse3>(
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
            // This error indicates that the operation attempted to be performed is not allowed. This could be because:   - The api token is invalid   - The user does not have the necessary permissions 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::G.CreateEmbedJobResponse4? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::G.CreateEmbedJobResponse4.FromJson(__content_403, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::G.CreateEmbedJobResponse4.FromJsonStreamAsync(__contentStream_403, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CreateEmbedJobResponse4>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a resource is not found. This could be because:   - The endpoint does not exist   - The resource does not exist eg model id, dataset id 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::G.CreateEmbedJobResponse5? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::G.CreateEmbedJobResponse5.FromJson(__content_404, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::G.CreateEmbedJobResponse5.FromJsonStreamAsync(__contentStream_404, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CreateEmbedJobResponse5>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when the request is not well formed. This could be because:   - JSON is invalid   - The request is missing required fields   - The request contains an invalid combination of fields 
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::G.CreateEmbedJobResponse6? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.CreateEmbedJobResponse6.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.CreateEmbedJobResponse6.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CreateEmbedJobResponse6>(
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
            // Too many requests
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::G.CreateEmbedJobResponse7? __value_429 = null;
                if (ReadResponseAsString)
                {
                    __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_429 = global::G.CreateEmbedJobResponse7.FromJson(__content_429, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_429 = await global::G.CreateEmbedJobResponse7.FromJsonStreamAsync(__contentStream_429, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CreateEmbedJobResponse7>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request or response contains a deny-listed token. 
            if ((int)__response.StatusCode == 498)
            {
                string? __content_498 = null;
                global::G.CreateEmbedJobResponse8? __value_498 = null;
                if (ReadResponseAsString)
                {
                    __content_498 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_498 = global::G.CreateEmbedJobResponse8.FromJson(__content_498, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_498 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_498 = await global::G.CreateEmbedJobResponse8.FromJsonStreamAsync(__contentStream_498, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CreateEmbedJobResponse8>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_498,
                    ResponseObject = __value_498,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request is cancelled by the user. 
            if ((int)__response.StatusCode == 499)
            {
                string? __content_499 = null;
                global::G.CreateEmbedJobResponse9? __value_499 = null;
                if (ReadResponseAsString)
                {
                    __content_499 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_499 = global::G.CreateEmbedJobResponse9.FromJson(__content_499, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_499 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_499 = await global::G.CreateEmbedJobResponse9.FromJsonStreamAsync(__contentStream_499, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CreateEmbedJobResponse9>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_499,
                    ResponseObject = __value_499,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when an uncategorised internal server error occurs. 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::G.CreateEmbedJobResponse10? __value_500 = null;
                if (ReadResponseAsString)
                {
                    __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = global::G.CreateEmbedJobResponse10.FromJson(__content_500, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_500 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = await global::G.CreateEmbedJobResponse10.FromJsonStreamAsync(__contentStream_500, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CreateEmbedJobResponse10>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when the requested feature is not implemented. 
            if ((int)__response.StatusCode == 501)
            {
                string? __content_501 = null;
                global::G.CreateEmbedJobResponse11? __value_501 = null;
                if (ReadResponseAsString)
                {
                    __content_501 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_501 = global::G.CreateEmbedJobResponse11.FromJson(__content_501, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_501 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_501 = await global::G.CreateEmbedJobResponse11.FromJsonStreamAsync(__contentStream_501, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CreateEmbedJobResponse11>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_501,
                    ResponseObject = __value_501,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when the service is unavailable. This could be due to:   - Too many users trying to access the service at the same time 
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::G.CreateEmbedJobResponse12? __value_503 = null;
                if (ReadResponseAsString)
                {
                    __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = global::G.CreateEmbedJobResponse12.FromJson(__content_503, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_503 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = await global::G.CreateEmbedJobResponse12.FromJsonStreamAsync(__contentStream_503, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CreateEmbedJobResponse12>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
                    ResponseObject = __value_503,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request to the server times out. This could be due to:   - An internal services taking too long to respond 
            if ((int)__response.StatusCode == 504)
            {
                string? __content_504 = null;
                global::G.CreateEmbedJobResponse13? __value_504 = null;
                if (ReadResponseAsString)
                {
                    __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_504 = global::G.CreateEmbedJobResponse13.FromJson(__content_504, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_504 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_504 = await global::G.CreateEmbedJobResponse13.FromJsonStreamAsync(__contentStream_504, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CreateEmbedJobResponse13>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_504,
                    ResponseObject = __value_504,
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
                ProcessCreateEmbedJobResponseContent(
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
                    global::G.CreateEmbedJobResponse.FromJson(__content, JsonSerializerOptions) ??
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
                    await global::G.CreateEmbedJobResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Create an Embed Job<br/>
        /// This API launches an async Embed job for a [Dataset](https://docs.cohere.com/docs/datasets) of type `embed-input`. The result of a completed embed job is new Dataset of type `embed-output`, which contains the original text entries and the corresponding embeddings.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="model">
        /// ID of the embedding model.<br/>
        /// Available models and corresponding embedding dimensions:<br/>
        /// - `embed-english-v3.0` : 1024<br/>
        /// - `embed-multilingual-v3.0` : 1024<br/>
        /// - `embed-english-light-v3.0` : 384<br/>
        /// - `embed-multilingual-light-v3.0` : 384
        /// </param>
        /// <param name="datasetId">
        /// ID of a [Dataset](https://docs.cohere.com/docs/datasets). The Dataset must be of type `embed-input` and must have a validation status `Validated`
        /// </param>
        /// <param name="inputType">
        /// Specifies the type of input passed to the model. Required for embedding models v3 and higher.<br/>
        /// - `"search_document"`: Used for embeddings stored in a vector database for search use-cases.<br/>
        /// - `"search_query"`: Used for embeddings of search queries run against a vector DB to find relevant documents.<br/>
        /// - `"classification"`: Used for embeddings passed through a text classifier.<br/>
        /// - `"clustering"`: Used for the embeddings run through a clustering algorithm.<br/>
        /// - `"image"`: Used for embeddings with image input.
        /// </param>
        /// <param name="name">
        /// The name of the embed job.
        /// </param>
        /// <param name="embeddingTypes">
        /// Specifies the types of embeddings you want to get back. Not required and default is None, which returns the Embed Floats response type. Can be one or more of the following types.<br/>
        /// * `"float"`: Use this when you want to get back the default float embeddings. Valid for all models.<br/>
        /// * `"int8"`: Use this when you want to get back signed int8 embeddings. Valid for only v3 models.<br/>
        /// * `"uint8"`: Use this when you want to get back unsigned int8 embeddings. Valid for only v3 models.<br/>
        /// * `"binary"`: Use this when you want to get back signed binary embeddings. Valid for only v3 models.<br/>
        /// * `"ubinary"`: Use this when you want to get back unsigned binary embeddings. Valid for only v3 models.
        /// </param>
        /// <param name="truncate">
        /// One of `START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// Default Value: END
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateEmbedJobResponse> CreateEmbedJobAsync(
            string model,
            string datasetId,
            global::G.EmbedInputType inputType,
            string? xClientName = default,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.EmbeddingType>? embeddingTypes = default,
            global::G.CreateEmbedJobRequestTruncate? truncate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateEmbedJobRequest
            {
                Model = model,
                DatasetId = datasetId,
                InputType = inputType,
                Name = name,
                EmbeddingTypes = embeddingTypes,
                Truncate = truncate,
            };

            return await CreateEmbedJobAsync(
                xClientName: xClientName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}