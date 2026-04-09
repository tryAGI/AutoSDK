//HintName: G.Api.RemoveBackground.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_RemoveBackgroundSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "XApiKey",
                        Location = "Header",
                        Name = "x-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_RemoveBackgroundSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_RemoveBackgroundSecurityRequirement0,
            };
        partial void PrepareRemoveBackgroundArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.RemoveBackgroundPostParams request);
        partial void PrepareRemoveBackgroundRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.RemoveBackgroundPostParams request);
        partial void ProcessRemoveBackgroundResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRemoveBackgroundResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remove Background (Basic plan)<br/>
        /// Remove background from an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RemoveBackgroundResponse> RemoveBackgroundAsync(

            global::G.RemoveBackgroundPostParams request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await RemoveBackgroundAsResponseAsync(

                request: request,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Remove Background (Basic plan)<br/>
        /// Remove background from an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.RemoveBackgroundResponse>> RemoveBackgroundAsResponseAsync(

            global::G.RemoveBackgroundPostParams request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRemoveBackgroundArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RemoveBackgroundSecurityRequirements,
                operationName: "RemoveBackgroundAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/segment",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            var __contentImageFile = new global::System.Net.Http.ByteArrayContent(request.ImageFile ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentImageFile,
                name: "\"image_file\"",
                fileName: request.ImageFilename != null ? $"\"{request.ImageFilename}\"" : string.Empty);
            if (__contentImageFile.Headers.ContentDisposition != null)
            {
                __contentImageFile.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.Format != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Format?.ToValueString()}"),
                    name: "\"format\"");
            } 
            if (request.Channels != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Channels?.ToValueString()}"),
                    name: "\"channels\"");
            } 
            if (request.BgColor != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BgColor}"),
                    name: "\"bg_color\"");
            } 
            if (request.Size != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Size?.ToValueString()}"),
                    name: "\"size\"");
            } 
            if (request.Crop != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Crop?.ToValueString()}"),
                    name: "\"crop\"");
            } 
            if (request.Despill != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Despill?.ToValueString()}"),
                    name: "\"despill\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRemoveBackgroundRequest(
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
            ProcessRemoveBackgroundResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.RemoveBackgroundResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.RemoveBackgroundResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.RemoveBackgroundResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.RemoveBackgroundResponse2>(
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
            // Payment Required
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                global::G.RemoveBackgroundResponse3? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::G.RemoveBackgroundResponse3.FromJson(__content_402, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_402 = global::G.RemoveBackgroundResponse3.FromJson(__content_402, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::G.ApiException<global::G.RemoveBackgroundResponse3>(
                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_402,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_402,
                    ResponseObject = __value_402,
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
                ProcessRemoveBackgroundResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __value = global::G.RemoveBackgroundResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                    return new global::G.AutoSDKHttpResponse<global::G.RemoveBackgroundResponse>(
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

                    var __value = await global::G.RemoveBackgroundResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                    return new global::G.AutoSDKHttpResponse<global::G.RemoveBackgroundResponse>(
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
        /// Remove Background (Basic plan)<br/>
        /// Remove background from an image
        /// </summary>
        /// <param name="imageFile">
        /// The image file to render
        /// </param>
        /// <param name="imageFilename">
        /// The image file to render
        /// </param>
        /// <param name="format">
        /// The format of the resulting image<br/>
        /// Default Value: png
        /// </param>
        /// <param name="channels">
        /// The channels of the resulting image<br/>
        /// Default Value: rgba
        /// </param>
        /// <param name="bgColor">
        /// The background color of the resulting image. Can be a hex code (`#FF00FF`) or a HTML color (`red`, `green`, etc.)
        /// </param>
        /// <param name="size">
        /// Will resize the output to the specified size. Can be `preview` (0.25 Megapixels), `medium` (1.5 MP), `hd` (4 MP) or `full` (36 MP, can be slower for large images). Useful for mobile apps that need smaller images.<br/>
        /// Default Value: full
        /// </param>
        /// <param name="crop">
        /// If `true`, the image returned is cropped to the cutout border. Transparent pixels are removed from the border<br/>
        /// Default Value: false
        /// </param>
        /// <param name="despill">
        /// If `true`, automatically removes colored reflections that have been left on the main subject by a green background.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RemoveBackgroundResponse> RemoveBackgroundAsync(
            byte[] imageFile,
            string imageFilename,
            global::G.RemoveBackgroundPostParamsFormat? format = default,
            global::G.RemoveBackgroundPostParamsChannels? channels = default,
            string? bgColor = default,
            global::G.RemoveBackgroundPostParamsSize? size = default,
            global::G.RemoveBackgroundPostParamsCrop? crop = default,
            global::G.RemoveBackgroundPostParamsDespill? despill = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.RemoveBackgroundPostParams
            {
                ImageFile = imageFile,
                ImageFilename = imageFilename,
                Format = format,
                Channels = channels,
                BgColor = bgColor,
                Size = size,
                Crop = crop,
                Despill = despill,
            };

            return await RemoveBackgroundAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}