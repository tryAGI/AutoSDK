//HintName: G.TranslateDocumentsClient.TranslateDocument.g.cs

#nullable enable

namespace G
{
    public partial class TranslateDocumentsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_TranslateDocumentSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "Authorization",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_TranslateDocumentSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_TranslateDocumentSecurityRequirement0,
            };
        partial void PrepareTranslateDocumentArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.TranslateDocumentRequest request);
        partial void PrepareTranslateDocumentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.TranslateDocumentRequest request);
        partial void ProcessTranslateDocumentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTranslateDocumentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload and Translate a Document<br/>
        /// This call uploads a document and queues it for translation.<br/>
        /// The call returns once the upload is complete, returning a document ID and key which can be used to<br/>
        /// [query the translation status](https://www.deepl.com/docs-api/documents/get-document-status)<br/>
        /// and to [download the translated document](https://www.deepl.com/docs-api/documents/download-document) once translation is complete.<br/>
        /// Because the request includes a file upload, it must be an HTTP POST request with content type `multipart/form-data`.<br/>
        /// Please be aware that the uploaded document is automatically removed from the server once the translated document has been downloaded.<br/>
        /// You have to upload the document again in order to restart the translation.<br/>
        /// The maximum upload limit for documents is [available here](https://support.deepl.com/hc/articles/360020582359-Document-formats)<br/>
        /// and may vary based on API plan and document type.<br/>
        /// You may specify the glossary to use for the document translation using the `glossary_id` parameter.<br/>
        /// **Important:** This requires the `source_lang` parameter to be set and the language pair of the glossary has to match the language pair of the request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TranslateDocumentResponse> TranslateDocumentAsync(

            global::G.TranslateDocumentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await TranslateDocumentAsResponseAsync(

                request: request,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Upload and Translate a Document<br/>
        /// This call uploads a document and queues it for translation.<br/>
        /// The call returns once the upload is complete, returning a document ID and key which can be used to<br/>
        /// [query the translation status](https://www.deepl.com/docs-api/documents/get-document-status)<br/>
        /// and to [download the translated document](https://www.deepl.com/docs-api/documents/download-document) once translation is complete.<br/>
        /// Because the request includes a file upload, it must be an HTTP POST request with content type `multipart/form-data`.<br/>
        /// Please be aware that the uploaded document is automatically removed from the server once the translated document has been downloaded.<br/>
        /// You have to upload the document again in order to restart the translation.<br/>
        /// The maximum upload limit for documents is [available here](https://support.deepl.com/hc/articles/360020582359-Document-formats)<br/>
        /// and may vary based on API plan and document type.<br/>
        /// You may specify the glossary to use for the document translation using the `glossary_id` parameter.<br/>
        /// **Important:** This requires the `source_lang` parameter to be set and the language pair of the glossary has to match the language pair of the request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.TranslateDocumentResponse>> TranslateDocumentAsResponseAsync(

            global::G.TranslateDocumentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTranslateDocumentArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TranslateDocumentSecurityRequirements,
                operationName: "TranslateDocumentAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/document",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            if (request.SourceLang != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SourceLang?.ToValueString()}"),
                    name: "\"source_lang\"");
            }
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.TargetLang.ToValueString()}"),
                name: "\"target_lang\"");
            var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentFile,
                name: "\"file\"",
                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
            if (__contentFile.Headers.ContentDisposition != null)
            {
                __contentFile.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.Filename != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Filename}"),
                    name: "\"filename\"");
            } 
            if (request.OutputFormat != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputFormat}"),
                    name: "\"output_format\"");
            } 
            if (request.Formality != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Formality?.ToValueString()}"),
                    name: "\"formality\"");
            } 
            if (request.GlossaryId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.GlossaryId}"),
                    name: "\"glossary_id\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTranslateDocumentRequest(
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
            ProcessTranslateDocumentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 413)
            {
                string? __content_413 = null;
                global::System.Exception? __exception_413 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_413 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_413,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_413,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 456)
            {
                string? __content_456 = null;
                global::System.Exception? __exception_456 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_456 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_456 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_456 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_456 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_456,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_456,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 504)
            {
                string? __content_504 = null;
                global::System.Exception? __exception_504 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_504 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_504 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_504,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_504,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 529)
            {
                string? __content_529 = null;
                global::System.Exception? __exception_529 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_529 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_529 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_529 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_529 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_529,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_529,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessTranslateDocumentResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __value = global::G.TranslateDocumentResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                    return new global::G.AutoSDKHttpResponse<global::G.TranslateDocumentResponse>(
                        statusCode: __response.StatusCode,
                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __value);
                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    var __value = await global::G.TranslateDocumentResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                    return new global::G.AutoSDKHttpResponse<global::G.TranslateDocumentResponse>(
                        statusCode: __response.StatusCode,
                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __value);
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
            }
        }
        /// <summary>
        /// Upload and Translate a Document<br/>
        /// This call uploads a document and queues it for translation.<br/>
        /// The call returns once the upload is complete, returning a document ID and key which can be used to<br/>
        /// [query the translation status](https://www.deepl.com/docs-api/documents/get-document-status)<br/>
        /// and to [download the translated document](https://www.deepl.com/docs-api/documents/download-document) once translation is complete.<br/>
        /// Because the request includes a file upload, it must be an HTTP POST request with content type `multipart/form-data`.<br/>
        /// Please be aware that the uploaded document is automatically removed from the server once the translated document has been downloaded.<br/>
        /// You have to upload the document again in order to restart the translation.<br/>
        /// The maximum upload limit for documents is [available here](https://support.deepl.com/hc/articles/360020582359-Document-formats)<br/>
        /// and may vary based on API plan and document type.<br/>
        /// You may specify the glossary to use for the document translation using the `glossary_id` parameter.<br/>
        /// **Important:** This requires the `source_lang` parameter to be set and the language pair of the glossary has to match the language pair of the request.
        /// </summary>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to detect the language of the text and translate it.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: EN
        /// </param>
        /// <param name="targetLang">
        /// The language into which the text should be translated.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: DE
        /// </param>
        /// <param name="file">
        /// The document file to be translated. The file name should be included in this part's content disposition. As an alternative, the filename parameter can be used. The following file types and extensions are supported:<br/>
        ///   * `docx` - Microsoft Word Document<br/>
        ///   * `pptx` - Microsoft PowerPoint Document<br/>
        ///   * `xlsx` - Microsoft Excel Document<br/>
        ///   * `pdf` - Portable Document Format<br/>
        ///   * `htm / html` - HTML Document<br/>
        ///   * `txt` - Plain Text Document<br/>
        ///   * `xlf / xliff` - XLIFF Document, version 2.1<br/>
        ///   * `srt` - SRT Document<br/>
        ///   * `jpeg / jpg / png` - Image
        /// </param>
        /// <param name="filename">
        /// The name of the uploaded file. Can be used as an alternative to including the file name in the file part's content disposition.
        /// </param>
        /// <param name="outputFormat">
        /// File extension of desired format of translated file, for example: `docx`. If unspecified, by default the translated file will be in the same format as the input file.<br/>
        /// Note: Not all combinations of input file and translation file extensions are permitted. See [Document Format Conversions](https://www.deepl.com/docs-api/documents/format-conversions) for the permitted combinations.
        /// </param>
        /// <param name="formality">
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// This feature currently only works for target languages<br/>
        /// `DE` (German),<br/>
        /// `FR` (French),<br/>
        /// `IT` (Italian),<br/>
        /// `ES` (Spanish),<br/>
        /// `ES-419` (Latin American Spanish),<br/>
        /// `NL` (Dutch),<br/>
        /// `PL` (Polish),<br/>
        /// `PT-BR` and `PT-PT` (Portuguese),<br/>
        /// `JA` (Japanese),<br/>
        /// and `RU` (Russian).<br/>
        /// Learn more about the plain/polite feature for Japanese [here](https://support.deepl.com/hc/en-us/articles/6306700061852-About-the-plain-polite-feature-in-Japanese).<br/>
        /// Setting this parameter with a target language that does not support formality will fail,<br/>
        /// unless one of the `prefer_...` options are used.<br/>
        /// Possible options are:<br/>
        ///   * `default` (default)<br/>
        ///   * `more` - for a more formal language<br/>
        ///   * `less` - for a more informal language<br/>
        ///   * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
        ///   * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
        /// Default Value: default
        /// </param>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TranslateDocumentResponse> TranslateDocumentAsync(
            global::G.TargetLanguage targetLang,
            byte[] file,
            global::G.SourceLanguage? sourceLang = default,
            string? filename = default,
            string? outputFormat = default,
            global::G.Formality? formality = default,
            string? glossaryId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TranslateDocumentRequest
            {
                SourceLang = sourceLang,
                TargetLang = targetLang,
                File = file,
                Filename = filename,
                OutputFormat = outputFormat,
                Formality = formality,
                GlossaryId = glossaryId,
            };

            return await TranslateDocumentAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}