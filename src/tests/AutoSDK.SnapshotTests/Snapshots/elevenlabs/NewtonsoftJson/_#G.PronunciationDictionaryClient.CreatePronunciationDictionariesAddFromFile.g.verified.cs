//HintName: G.PronunciationDictionaryClient.CreatePronunciationDictionariesAddFromFile.g.cs

#nullable enable

namespace G
{
    public partial class PronunciationDictionaryClient
    {
        partial void PrepareCreatePronunciationDictionariesAddFromFileArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xiApiKey,
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost request);
        partial void PrepareCreatePronunciationDictionariesAddFromFileRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xiApiKey,
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost request);
        partial void ProcessCreatePronunciationDictionariesAddFromFileResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePronunciationDictionariesAddFromFileResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add A Pronunciation Dictionary<br/>
        /// Creates a new pronunciation dictionary from a lexicon .PLS file
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AddPronunciationDictionaryResponseModel> CreatePronunciationDictionariesAddFromFileAsync(
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreatePronunciationDictionariesAddFromFileArguments(
                httpClient: HttpClient,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/pronunciation-dictionaries/add-from-file",
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
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Name}"),
                name: "name");
            if (request.File != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>()),
                    name: "file",
                    fileName: request.Filename ?? string.Empty);
            } 
            if (request.Description != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Description}"),
                    name: "description");
            } 
            if (request.WorkspaceAccess != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.WorkspaceAccess?.ToValueString()}"),
                    name: "workspace_access");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreatePronunciationDictionariesAddFromFileRequest(
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
            ProcessCreatePronunciationDictionariesAddFromFileResponse(
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
                ProcessCreatePronunciationDictionariesAddFromFileResponseContent(
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
                    global::G.AddPronunciationDictionaryResponseModel.FromJson(__content, JsonSerializerOptions) ??
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
                    await global::G.AddPronunciationDictionaryResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Add A Pronunciation Dictionary<br/>
        /// Creates a new pronunciation dictionary from a lexicon .PLS file
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// The name of the pronunciation dictionary, used for identification only.
        /// </param>
        /// <param name="file">
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </param>
        /// <param name="filename">
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </param>
        /// <param name="description">
        /// A description of the pronunciation dictionary, used for identification only.
        /// </param>
        /// <param name="workspaceAccess">
        /// Should be one of 'editor' or 'viewer'. If not provided, defaults to no access.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AddPronunciationDictionaryResponseModel> CreatePronunciationDictionariesAddFromFileAsync(
            string name,
            string? xiApiKey = default,
            byte[]? file = default,
            string? filename = default,
            string? description = default,
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? workspaceAccess = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost
            {
                Name = name,
                File = file,
                Filename = filename,
                Description = description,
                WorkspaceAccess = workspaceAccess,
            };

            return await CreatePronunciationDictionariesAddFromFileAsync(
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}