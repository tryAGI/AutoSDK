//HintName: G.Api.DocumentsExtract.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_DocumentsExtractSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_DocumentsExtractSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_DocumentsExtractSecurityRequirement0,
            };
        partial void PrepareDocumentsExtractArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? toxicity,
            ref string? pii,
            ref string? replaceMethod,
            global::System.Collections.Generic.IList<string>? entityList,
            ref bool? injection,
            global::G.DocumentsExtractRequest request);
        partial void PrepareDocumentsExtractRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? toxicity,
            string? pii,
            string? replaceMethod,
            global::System.Collections.Generic.IList<string>? entityList,
            bool? injection,
            global::G.DocumentsExtractRequest request);
        partial void ProcessDocumentsExtractResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDocumentsExtractResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Documents Extract<br/>
        /// This endpoint allows you to parse text from documents using OCR.
        /// </summary>
        /// <param name="toxicity"></param>
        /// <param name="pii"></param>
        /// <param name="replaceMethod"></param>
        /// <param name="entityList"></param>
        /// <param name="injection"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DocumentsExtractResponse200> DocumentsExtractAsync(

            global::G.DocumentsExtractRequest request,
            bool? toxicity = default,
            string? pii = default,
            string? replaceMethod = default,
            global::System.Collections.Generic.IList<string>? entityList = default,
            bool? injection = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDocumentsExtractArguments(
                httpClient: HttpClient,
                toxicity: ref toxicity,
                pii: ref pii,
                replaceMethod: ref replaceMethod,
                entityList: entityList,
                injection: ref injection,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_DocumentsExtractSecurityRequirements,
                operationName: "DocumentsExtractAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/documents/extract",
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

            if (toxicity != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Toxicity", toxicity.ToString());
            }
            if (pii != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Pii", pii.ToString());
            }
            if (replaceMethod != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Replace-Method", replaceMethod.ToString());
            }
            if (entityList != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Entity-List", entityList.ToString());
            }
            if (injection != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Injection", injection.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (toxicity != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{toxicity}"),
                    name: "\"Toxicity\"");
            } 
            if (pii != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{pii}"),
                    name: "\"Pii\"");
            } 
            if (replaceMethod != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{replaceMethod}"),
                    name: "\"Replace-Method\"");
            } 
            if (entityList != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(entityList, x => x))}]"),
                    name: "\"Entity-List\"");
            } 
            if (injection != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{injection}"),
                    name: "\"Injection\"");
            }
            var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentFile,
                name: "\"file\"",
                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
            if (__contentFile.Headers.ContentDisposition != null)
            {
                __contentFile.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.EmbedImages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.EmbedImages}"),
                    name: "\"embedImages\"");
            } 
            if (request.OutputFormat != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputFormat}"),
                    name: "\"outputFormat\"");
            } 
            if (request.ChunkDocument != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ChunkDocument}"),
                    name: "\"chunkDocument\"");
            } 
            if (request.ChunkSize != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ChunkSize}"),
                    name: "\"chunkSize\"");
            } 
            if (request.EnableOCR != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.EnableOCR}"),
                    name: "\"enableOCR\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDocumentsExtractRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                toxicity: toxicity,
                pii: pii,
                replaceMethod: replaceMethod,
                entityList: entityList,
                injection: injection,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDocumentsExtractResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // General error response.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.DocumentsExtractRequestBadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.DocumentsExtractRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.DocumentsExtractRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.DocumentsExtractRequestBadRequestError>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
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
            // Failed auth response.
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.DocumentsExtractRequestForbiddenError? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.DocumentsExtractRequestForbiddenError.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.DocumentsExtractRequestForbiddenError.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.DocumentsExtractRequestForbiddenError>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
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
                ProcessDocumentsExtractResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.DocumentsExtractResponse200.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                    return
                        await global::G.DocumentsExtractResponse200.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Documents Extract<br/>
        /// This endpoint allows you to parse text from documents using OCR.
        /// </summary>
        /// <param name="toxicity"></param>
        /// <param name="pii"></param>
        /// <param name="replaceMethod"></param>
        /// <param name="entityList"></param>
        /// <param name="injection"></param>
        /// <param name="file">
        /// The document file to upload.
        /// </param>
        /// <param name="filename">
        /// The document file to upload.
        /// </param>
        /// <param name="embedImages">
        /// Whether to embed images from the document.
        /// </param>
        /// <param name="outputFormat">
        /// The output format for the content of the document.
        /// </param>
        /// <param name="chunkDocument">
        /// Whether to separate the document into chunks.
        /// </param>
        /// <param name="chunkSize">
        /// The size of chunks for the documents.
        /// </param>
        /// <param name="enableOCR">
        /// Whether to enable OCR for document parsing.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DocumentsExtractResponse200> DocumentsExtractAsync(
            byte[] file,
            string filename,
            bool? toxicity = default,
            string? pii = default,
            string? replaceMethod = default,
            global::System.Collections.Generic.IList<string>? entityList = default,
            bool? injection = default,
            bool? embedImages = default,
            string? outputFormat = default,
            bool? chunkDocument = default,
            int? chunkSize = default,
            bool? enableOCR = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.DocumentsExtractRequest
            {
                File = file,
                Filename = filename,
                EmbedImages = embedImages,
                OutputFormat = outputFormat,
                ChunkDocument = chunkDocument,
                ChunkSize = chunkSize,
                EnableOCR = enableOCR,
            };

            return await DocumentsExtractAsync(
                toxicity: toxicity,
                pii: pii,
                replaceMethod: replaceMethod,
                entityList: entityList,
                injection: injection,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}