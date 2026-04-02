//HintName: G.V1GenerationClient.UpscaleImage.g.cs

#nullable enable

namespace G
{
    public partial class V1GenerationClient
    {
        partial void PrepareUpscaleImageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string engineId,
            ref global::G.UpscaleImageAccept? accept,
            ref string? organization,
            global::G.UpscaleImageRequestBody request);
        partial void PrepareUpscaleImageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string engineId,
            global::G.UpscaleImageAccept? accept,
            string? organization,
            global::G.UpscaleImageRequestBody request);
        partial void ProcessUpscaleImageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpscaleImageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// image-to-image/upscale<br/>
        /// Create a higher resolution version of an input image.<br/>
        /// This operation outputs an image with a maximum pixel count of **4,194,304**. This is equivalent to dimensions such as `2048x2048` and `4096x1024`.<br/>
        /// By default, the input image will be upscaled by a factor of 2.  For additional control over the output dimensions, a `width` or `height` parameter may be specified.
        /// </summary>
        /// <param name="engineId"></param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// if [ -z "$STABILITY_API_KEY" ]; then<br/>
        ///     echo "STABILITY_API_KEY environment variable is not set"<br/>
        ///     exit 1<br/>
        /// fi<br/>
        /// OUTPUT_FILE=./out/v1_upscaled_image.png<br/>
        /// BASE_URL=${API_HOST:-https://api.stability.ai}<br/>
        /// URL="$BASE_URL/v1/generation/esrgan-v1-x2plus/image-to-image/upscale"<br/>
        /// curl -f -sS -X POST "$URL" \<br/>
        ///   -H 'Content-Type: multipart/form-data' \<br/>
        ///   -H 'Accept: image/png' \<br/>
        ///   -H "Authorization: Bearer $STABILITY_API_KEY" \<br/>
        ///   -F 'image=@"../init_image.png"' \<br/>
        ///   -F 'width=1024' \<br/>
        ///   -o "$OUTPUT_FILE"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Image>> UpscaleImageAsync(
            string engineId,

            global::G.UpscaleImageRequestBody request,
            global::G.UpscaleImageAccept? accept = default,
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await UpscaleImageAsResponseAsync(
                engineId: engineId,

                request: request,
                accept: accept,
                organization: organization,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// image-to-image/upscale<br/>
        /// Create a higher resolution version of an input image.<br/>
        /// This operation outputs an image with a maximum pixel count of **4,194,304**. This is equivalent to dimensions such as `2048x2048` and `4096x1024`.<br/>
        /// By default, the input image will be upscaled by a factor of 2.  For additional control over the output dimensions, a `width` or `height` parameter may be specified.
        /// </summary>
        /// <param name="engineId"></param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// if [ -z "$STABILITY_API_KEY" ]; then<br/>
        ///     echo "STABILITY_API_KEY environment variable is not set"<br/>
        ///     exit 1<br/>
        /// fi<br/>
        /// OUTPUT_FILE=./out/v1_upscaled_image.png<br/>
        /// BASE_URL=${API_HOST:-https://api.stability.ai}<br/>
        /// URL="$BASE_URL/v1/generation/esrgan-v1-x2plus/image-to-image/upscale"<br/>
        /// curl -f -sS -X POST "$URL" \<br/>
        ///   -H 'Content-Type: multipart/form-data' \<br/>
        ///   -H 'Accept: image/png' \<br/>
        ///   -H "Authorization: Bearer $STABILITY_API_KEY" \<br/>
        ///   -F 'image=@"../init_image.png"' \<br/>
        ///   -F 'width=1024' \<br/>
        ///   -o "$OUTPUT_FILE"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.Image>>> UpscaleImageAsResponseAsync(
            string engineId,

            global::G.UpscaleImageRequestBody request,
            global::G.UpscaleImageAccept? accept = default,
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpscaleImageArguments(
                httpClient: HttpClient,
                engineId: ref engineId,
                accept: ref accept,
                organization: ref organization,
                request: request);

            var acceptValue = accept switch
            {
                global::G.UpscaleImageAccept.ApplicationJson => "application/json",
                global::G.UpscaleImageAccept.ImagePng => "image/png",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/generation/{engineId}/image-to-image/upscale",
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

            if (accept != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Accept", accept?.ToValueString() ?? string.Empty);
            }
            if (organization != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Organization", organization.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{engineId}"),
                name: "\"engine_id\"");
            if (accept != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{accept?.ToValueString()}"),
                    name: "\"Accept\"");
            } 
            if (organization != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{organization}"),
                    name: "\"Organization\"");
            }
            var __contentImage = new global::System.Net.Http.ByteArrayContent(request.Image ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentImage,
                name: "\"image\"",
                fileName: request.Imagename != null ? $"\"{request.Imagename}\"" : string.Empty);
            if (__contentImage.Headers.ContentDisposition != null)
            {
                __contentImage.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.Width != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Width}"),
                    name: "\"width\"");
            } 
            if (request.Height != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Height}"),
                    name: "\"height\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpscaleImageRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                engineId: engineId,
                accept: accept,
                organization: organization,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpscaleImageResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // bad_request: general error for invalid parameters <br/><br/>  <p style="display: flex; margin-top: -20px; margin-bottom: 0">More specific errors:</p>    - invalid_file_size: The file size of one or more of the provided files is invalid   - invalid_mime_type: The mime type of one or more of the provided files is invalid   - invalid_pixel_count: The requested image would exceed the maximum pixel count of 4,194,304
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.Error? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.Error.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.Error.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
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
            // unauthorized: API key missing or invalid
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.Error? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.Error.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.Error.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
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
            // permission_denied: You lack the necessary permissions to perform this action
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.Error? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
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
            // not_found: The requested resource was not found (e.g. specifing a model that does not exist)
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.Error? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.Error.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.Error.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
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
            // server_error: Some unexpected server error occurred
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.Error? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.Error.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.Error.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
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
                ProcessUpscaleImageResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __value = global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Image>?>(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                    return new global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.Image>>(
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

                    var __value = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.Image>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                    return new global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.Image>>(
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
        /// image-to-image/upscale<br/>
        /// Create a higher resolution version of an input image.<br/>
        /// This operation outputs an image with a maximum pixel count of **4,194,304**. This is equivalent to dimensions such as `2048x2048` and `4096x1024`.<br/>
        /// By default, the input image will be upscaled by a factor of 2.  For additional control over the output dimensions, a `width` or `height` parameter may be specified.
        /// </summary>
        /// <param name="engineId"></param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
        /// <param name="image">
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="imagename">
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="width">
        /// Desired width of the output image.  Only one of `width` or `height` may be specified.
        /// </param>
        /// <param name="height">
        /// Desired height of the output image.  Only one of `width` or `height` may be specified.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Image>> UpscaleImageAsync(
            string engineId,
            byte[] image,
            string imagename,
            global::G.UpscaleImageAccept? accept = default,
            string? organization = default,
            int? width = default,
            int? height = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.UpscaleImageRequestBody
            {
                Image = image,
                Imagename = imagename,
                Width = width,
                Height = height,
            };

            return await UpscaleImageAsync(
                engineId: engineId,
                accept: accept,
                organization: organization,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}