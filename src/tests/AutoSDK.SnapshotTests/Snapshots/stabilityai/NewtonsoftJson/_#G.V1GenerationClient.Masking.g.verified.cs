//HintName: G.V1GenerationClient.Masking.g.cs

#nullable enable

namespace G
{
    public partial class V1GenerationClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_MaskingSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_MaskingSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_MaskingSecurityRequirement0,
            };
        partial void PrepareMaskingArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string engineId,
            ref global::G.MaskingAccept? accept,
            ref string? organization,
            global::G.MaskingRequestBody request);
        partial void PrepareMaskingRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string engineId,
            global::G.MaskingAccept? accept,
            string? organization,
            global::G.MaskingRequestBody request);
        partial void ProcessMaskingResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMaskingResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// image-to-image/masking<br/>
        /// Selectively modify portions of an image using a mask
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
        /// #!/bin/sh<br/>
        /// set -e<br/>
        /// if [ -z "$STABILITY_API_KEY" ]; then<br/>
        ///     echo "STABILITY_API_KEY environment variable is not set"<br/>
        ///     exit 1<br/>
        /// fi<br/>
        /// OUTPUT_FILE=./out/v1_img2img_masking.png<br/>
        /// BASE_URL=${API_HOST:-https://api.stability.ai}<br/>
        /// URL="$BASE_URL/v1/generation/stable-inpainting-512-v2-0/image-to-image/masking"<br/>
        /// curl -f -sS -X POST "$URL" \<br/>
        ///   -H 'Content-Type: multipart/form-data' \<br/>
        ///   -H 'Accept: image/png' \<br/>
        ///   -H "Authorization: Bearer $STABILITY_API_KEY" \<br/>
        ///   -F 'init_image=@"../init_image.png"' \<br/>
        ///   -F 'mask_image=@"../mask_image_white.png"' \<br/>
        ///   -F 'mask_source=MASK_IMAGE_WHITE' \<br/>
        ///   -F 'text_prompts[0][text]=A large spiral galaxy with a bright central bulge and a ring of stars around it' \<br/>
        ///   -F 'cfg_scale=7' \<br/>
        ///   -F 'clip_guidance_preset=FAST_BLUE' \<br/>
        ///   -F 'samples=1' \<br/>
        ///   -F 'steps=30' \<br/>
        ///   -o "$OUTPUT_FILE"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Image>> MaskingAsync(
            string engineId,

            global::G.MaskingRequestBody request,
            global::G.MaskingAccept? accept = default,
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await MaskingAsResponseAsync(
                engineId: engineId,

                request: request,
                accept: accept,
                organization: organization,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// image-to-image/masking<br/>
        /// Selectively modify portions of an image using a mask
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
        /// #!/bin/sh<br/>
        /// set -e<br/>
        /// if [ -z "$STABILITY_API_KEY" ]; then<br/>
        ///     echo "STABILITY_API_KEY environment variable is not set"<br/>
        ///     exit 1<br/>
        /// fi<br/>
        /// OUTPUT_FILE=./out/v1_img2img_masking.png<br/>
        /// BASE_URL=${API_HOST:-https://api.stability.ai}<br/>
        /// URL="$BASE_URL/v1/generation/stable-inpainting-512-v2-0/image-to-image/masking"<br/>
        /// curl -f -sS -X POST "$URL" \<br/>
        ///   -H 'Content-Type: multipart/form-data' \<br/>
        ///   -H 'Accept: image/png' \<br/>
        ///   -H "Authorization: Bearer $STABILITY_API_KEY" \<br/>
        ///   -F 'init_image=@"../init_image.png"' \<br/>
        ///   -F 'mask_image=@"../mask_image_white.png"' \<br/>
        ///   -F 'mask_source=MASK_IMAGE_WHITE' \<br/>
        ///   -F 'text_prompts[0][text]=A large spiral galaxy with a bright central bulge and a ring of stars around it' \<br/>
        ///   -F 'cfg_scale=7' \<br/>
        ///   -F 'clip_guidance_preset=FAST_BLUE' \<br/>
        ///   -F 'samples=1' \<br/>
        ///   -F 'steps=30' \<br/>
        ///   -o "$OUTPUT_FILE"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.Image>>> MaskingAsResponseAsync(
            string engineId,

            global::G.MaskingRequestBody request,
            global::G.MaskingAccept? accept = default,
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMaskingArguments(
                httpClient: HttpClient,
                engineId: ref engineId,
                accept: ref accept,
                organization: ref organization,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_MaskingSecurityRequirements,
                operationName: "MaskingAsync");

            var acceptValue = accept switch
            {
                global::G.MaskingAccept.ApplicationJson => "application/json",
                global::G.MaskingAccept.ImagePng => "image/png",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/generation/{engineId}/image-to-image/masking",
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
            var __contentInitImage = new global::System.Net.Http.ByteArrayContent(request.InitImage ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentInitImage,
                name: "\"init_image\"",
                fileName: request.InitImagename != null ? $"\"{request.InitImagename}\"" : string.Empty);
            if (__contentInitImage.Headers.ContentDisposition != null)
            {
                __contentInitImage.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.MaskImage != default)
            {

                var __contentMaskImage = new global::System.Net.Http.ByteArrayContent(request.MaskImage ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentMaskImage,
                    name: "\"mask_image\"",
                    fileName: request.MaskImagename != null ? $"\"{request.MaskImagename}\"" : string.Empty);
                if (__contentMaskImage.Headers.ContentDisposition != null)
                {
                    __contentMaskImage.Headers.ContentDisposition.FileNameStar = null;
                }
            }
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.TextPrompts, x => x))}]"),
                name: "\"text_prompts\"");
            if (request.CfgScale != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.CfgScale}"),
                    name: "\"cfg_scale\"");
            } 
            if (request.ClipGuidancePreset != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ClipGuidancePreset?.ToValueString()}"),
                    name: "\"clip_guidance_preset\"");
            } 
            if (request.Sampler != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Sampler?.ToValueString()}"),
                    name: "\"sampler\"");
            } 
            if (request.Samples != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Samples}"),
                    name: "\"samples\"");
            } 
            if (request.Seed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Seed}"),
                    name: "\"seed\"");
            } 
            if (request.Steps != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Steps}"),
                    name: "\"steps\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMaskingRequest(
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
            ProcessMaskingResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // bad_request: general error for invalid parameters <br/><br/>  <p style="display: flex; margin-top: -20px; margin-bottom: 0">More specific errors:</p>    - invalid_samples: Sample count may only be greater than 1 when the accept header is set to `application/json`   - invalid_height_or_width: Height and width must be specified in increments of 64   - invalid_file_size: The file size of one or more of the provided files is invalid   - invalid_mime_type: The mime type of one or more of the provided files is invalid   - invalid_image_dimensions: The dimensions of the provided `init_image` and `mask_image` do not match   - invalid_mask_image: The parameter `mask_source` was set to `MASK_IMAGE_WHITE` or `MASK_IMAGE_BLACK` but no `mask_image` was provided   - invalid_prompts: One or more of the prompts contains filtered words   - invalid_pixel_count: Incorrect number of pixels specified. Requirements:     - For 768 engines : <span style='display: inline-flex; justify-content: flex-start; gap:8px'>589,824 <span>≤</span> `height * width` <span>≤</span> 1,048,576</span>     - All other engines: <span style='display: inline-flex; justify-content: flex-start; gap:8px'>262,144 <span>≤</span> `height * width` <span>≤</span> 1,048,576</span>
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
                ProcessMaskingResponseContent(
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
        /// image-to-image/masking<br/>
        /// Selectively modify portions of an image using a mask
        /// </summary>
        /// <param name="engineId"></param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
        /// <param name="initImage">
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="initImagename">
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="maskImage">
        /// Optional grayscale mask that allows for influence over which pixels are eligible for diffusion and at what strength. Must be the same dimensions as the `init_image`. Use the `mask_source` option to specify whether the white or black pixels should be inpainted.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="maskImagename">
        /// Optional grayscale mask that allows for influence over which pixels are eligible for diffusion and at what strength. Must be the same dimensions as the `init_image`. Use the `mask_source` option to specify whether the white or black pixels should be inpainted.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="textPrompts">
        /// An array of text prompts to use for generation.<br/>
        /// Due to how arrays are represented in `multipart/form-data` requests, prompts must adhear to the format `text_prompts[index][text|weight]`,<br/>
        /// where `index` is some integer used to tie the text and weight together.  While `index` does not have to be sequential, duplicate entries <br/>
        /// will override previous entries, so it is recommended to use sequential indices.<br/>
        /// Given a text prompt with the text `A lighthouse on a cliff` and a weight of `0.5`, it would be represented as:<br/>
        /// ```<br/>
        /// text_prompts[0][text]: "A lighthouse on a cliff"<br/>
        /// text_prompts[0][weight]: 0.5<br/>
        /// ```<br/>
        /// To add another prompt to that request simply provide the values under a new `index`:<br/>
        /// ```<br/>
        /// text_prompts[0][text]: "A lighthouse on a cliff"<br/>
        /// text_prompts[0][weight]: 0.5<br/>
        /// text_prompts[1][text]: "land, ground, dirt, grass"<br/>
        /// text_prompts[1][weight]: -0.9<br/>
        /// ```
        /// </param>
        /// <param name="cfgScale">
        /// How strictly the diffusion process adheres to the prompt text (higher values keep your image closer to your prompt)<br/>
        /// Default Value: 7<br/>
        /// Example: 7
        /// </param>
        /// <param name="clipGuidancePreset">
        /// Default Value: NONE<br/>
        /// Example: FAST_BLUE
        /// </param>
        /// <param name="sampler">
        /// Which sampler to use for the diffusion process. If this value is omitted we'll automatically select an appropriate sampler for you.<br/>
        /// Example: K_DPM_2_ANCESTRAL
        /// </param>
        /// <param name="samples">
        /// Number of images to generate<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="seed">
        /// Random noise seed (omit this option or use `0` for a random seed)<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="steps">
        /// Number of diffusion steps to run<br/>
        /// Default Value: 50<br/>
        /// Example: 75
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Image>> MaskingAsync(
            string engineId,
            byte[] initImage,
            string initImagename,
            global::System.Collections.Generic.IList<global::G.TextPrompt> textPrompts,
            global::G.MaskingAccept? accept = default,
            string? organization = default,
            byte[]? maskImage = default,
            string? maskImagename = default,
            double? cfgScale = default,
            global::G.ClipGuidancePreset? clipGuidancePreset = default,
            global::G.Sampler? sampler = default,
            int? samples = default,
            long? seed = default,
            int? steps = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.MaskingRequestBody
            {
                InitImage = initImage,
                InitImagename = initImagename,
                MaskImage = maskImage,
                MaskImagename = maskImagename,
                TextPrompts = textPrompts,
                CfgScale = cfgScale,
                ClipGuidancePreset = clipGuidancePreset,
                Sampler = sampler,
                Samples = samples,
                Seed = seed,
                Steps = steps,
            };

            return await MaskingAsync(
                engineId: engineId,
                accept: accept,
                organization: organization,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}