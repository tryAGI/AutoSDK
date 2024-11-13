//HintName: G.VoicesClient.CreateSimilarVoices.g.cs

#nullable enable

namespace G
{
    public partial class VoicesClient
    {
        partial void PrepareCreateSimilarVoicesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xiApiKey,
            global::G.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost request);
        partial void PrepareCreateSimilarVoicesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xiApiKey,
            global::G.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost request);
        partial void ProcessCreateSimilarVoicesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateSimilarVoicesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Similar Library Voices<br/>
        /// Returns a list of shared voices similar to the provided audio sample. If neither similarity_threshold nor top_k is provided, we will apply default values.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetLibraryVoicesResponseModel> CreateSimilarVoicesAsync(
            global::G.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateSimilarVoicesArguments(
                httpClient: HttpClient,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/similar-voices",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (xiApiKey != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xiApiKey}"),
                    name: "xi-api-key");
            } 
            if (request.AudioFile != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.AudioFile ?? global::System.Array.Empty<byte>()),
                    name: "audio_file",
                    fileName: request.AudioFilename ?? string.Empty);
            } 
            if (request.SimilarityThreshold != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SimilarityThreshold}"),
                    name: "similarity_threshold");
            } 
            if (request.TopK != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TopK}"),
                    name: "top_k");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateSimilarVoicesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateSimilarVoicesResponse(
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
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateSimilarVoicesResponseContent(
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
                    global::G.GetLibraryVoicesResponseModel.FromJson(__content, JsonSerializerOptions) ??
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

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.GetLibraryVoicesResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Get Similar Library Voices<br/>
        /// Returns a list of shared voices similar to the provided audio sample. If neither similarity_threshold nor top_k is provided, we will apply default values.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="audioFile"></param>
        /// <param name="audioFilename"></param>
        /// <param name="similarityThreshold">
        /// Threshold for voice similarity between provided sample and library voices. Must be in range &lt;0, 2&gt;. The smaller the value the more similar voices will be returned.
        /// </param>
        /// <param name="topK">
        /// Number of most similar voices to return. If similarity_threshold is provided, less than this number of voices may be returned. Must be in range &lt;1, 100&gt;.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetLibraryVoicesResponseModel> CreateSimilarVoicesAsync(
            string? xiApiKey = default,
            byte[]? audioFile = default,
            string? audioFilename = default,
            double? similarityThreshold = default,
            int? topK = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost
            {
                AudioFile = audioFile,
                AudioFilename = audioFilename,
                SimilarityThreshold = similarityThreshold,
                TopK = topK,
            };

            return await CreateSimilarVoicesAsync(
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}