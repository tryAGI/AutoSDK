//HintName: G.SubpackageAssetsClient.Create.g.cs

#nullable enable

namespace G
{
    public partial class SubpackageAssetsClient
    {
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xApiKey,
            global::G.CreateRequest2 request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xApiKey,
            global::G.CreateRequest2 request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an asset<br/>
        /// This method creates an asset by uploading a file to the platform. Assets are media files that you can use in downstream workflows, including indexing, analyzing video content, and creating entities.<br/>
        /// **Supported content**: Video, audio, and images.<br/>
        /// **Upload methods**:<br/>
        /// - **Local file**: Set the `method` parameter to `direct` and use the `file` parameter to specify the file.<br/>
        /// - **Publicly accessible URL**: Set the `method` parameter to `url` and use the `url` parameter to specify the URL of your file.<br/>
        /// **File size**: 200MB maximum for local file uploads, 4GB maximum for URL uploads.<br/>
        /// **Additional requirements** depend on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements)<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#input-requirements)<br/>
        /// - **Entity search**: [Marengo image requirements](/v1.3/docs/concepts/models/marengo#image-file-requirements)<br/>
        /// - **Create embeddings**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#input-requirements)<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Asset> CreateAsync(
            string xApiKey,

            global::G.CreateRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                xApiKey: ref xApiKey,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/assets",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            __httpRequest.Headers.TryAddWithoutValidation("x-api-key", xApiKey.ToString());

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{xApiKey}"),
                name: "\"x-api-key\"");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Method.ToValueString()}"),
                name: "\"method\"");
            if (request.File != default)
            {

                var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentFile,
                    name: "\"file\"",
                    fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                if (__contentFile.Headers.ContentDisposition != null)
                {
                    __contentFile.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.Url != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Url}"),
                    name: "\"url\"");
            } 
            if (request.Filename != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Filename}"),
                    name: "\"filename\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xApiKey: xApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // The request has failed.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.CreateAssetRequestBadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.CreateAssetRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.CreateAssetRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateAssetRequestBadRequestError>(
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
                ProcessCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.Asset.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.Asset.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create an asset<br/>
        /// This method creates an asset by uploading a file to the platform. Assets are media files that you can use in downstream workflows, including indexing, analyzing video content, and creating entities.<br/>
        /// **Supported content**: Video, audio, and images.<br/>
        /// **Upload methods**:<br/>
        /// - **Local file**: Set the `method` parameter to `direct` and use the `file` parameter to specify the file.<br/>
        /// - **Publicly accessible URL**: Set the `method` parameter to `url` and use the `url` parameter to specify the URL of your file.<br/>
        /// **File size**: 200MB maximum for local file uploads, 4GB maximum for URL uploads.<br/>
        /// **Additional requirements** depend on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements)<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#input-requirements)<br/>
        /// - **Entity search**: [Marengo image requirements](/v1.3/docs/concepts/models/marengo#image-file-requirements)<br/>
        /// - **Create embeddings**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#input-requirements)<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="method">
        /// Specifies the upload method for the asset. Use `direct` to upload a local file or `url` for a publicly accessible URL.
        /// </param>
        /// <param name="file">
        /// Specify this parameter to upload a file from your local file system. This parameter is required when `method` is set to `direct`.<br/>
        /// Direct uploads are limited to 200MB. For files larger than 200MB, use the [Multipart Upload API](/api-reference/upload-content/multipart-uploads).
        /// </param>
        /// <param name="url">
        /// Specify this parameter to upload a file from a publicly accessible URL. This parameter is required when `method` is set to `url`.<br/>
        /// URL uploads have a maximum limit of 4GB.
        /// </param>
        /// <param name="filename">
        /// The optional filename of the asset. If not provided, the platform will determine the filename from the file or URL.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Asset> CreateAsync(
            string xApiKey,
            global::G.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod method,
            byte[]? file = default,
            string? url = default,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateRequest2
            {
                Method = method,
                File = file,
                Url = url,
                Filename = filename,
            };

            return await CreateAsync(
                xApiKey: xApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}