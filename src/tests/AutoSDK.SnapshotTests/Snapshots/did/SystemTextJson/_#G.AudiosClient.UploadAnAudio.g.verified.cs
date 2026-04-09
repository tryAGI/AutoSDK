//HintName: G.AudiosClient.UploadAnAudio.g.cs

#nullable enable

namespace G
{
    public partial class AudiosClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_UploadAnAudioSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Basic",
                        FriendlyName = "Basic",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_UploadAnAudioSecurityRequirement1 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_UploadAnAudioSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_UploadAnAudioSecurityRequirement0,
                s_UploadAnAudioSecurityRequirement1,
            };
        partial void PrepareUploadAnAudioArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UploadAnAudioRequest request);
        partial void PrepareUploadAnAudioRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UploadAnAudioRequest request);
        partial void ProcessUploadAnAudioResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadAnAudioResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload audio file<br/>
        /// Upload an audio file to a temporary storage before creating an animation.<br/>
        /// The audio is uploaded using multipart/form-data. the filename directive is optional and if provided should contain up to 50 valid characters long.<br/>
        /// The resulting file is stored as a .wav file in a 16kHz sample rate.<br/>
        /// Valid characters: a-z A-Z 0-9 . _ -<br/>
        /// Supported mime types: "audio/, video/"<br/>
        /// Storage duration: 24-48H
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UploadAnAudioResponse> UploadAnAudioAsync(

            global::G.UploadAnAudioRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadAnAudioArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UploadAnAudioSecurityRequirements,
                operationName: "UploadAnAudioAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/audios",
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
            if (request.Audio != default)
            {

                var __contentAudio = new global::System.Net.Http.ByteArrayContent(request.Audio ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentAudio,
                    name: "\"audio\"",
                    fileName: request.Audioname != null ? $"\"{request.Audioname}\"" : string.Empty);
                if (__contentAudio.Headers.ContentDisposition != null)
                {
                    __contentAudio.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.SourceUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SourceUrl}"),
                    name: "\"source_url\"");
            } 
            if (request.ResultUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ResultUrl}"),
                    name: "\"result_url\"");
            } 
            if (request.Persist != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Persist}"),
                    name: "\"persist\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUploadAnAudioRequest(
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
            ProcessUploadAnAudioResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // BadRequestError | InvalidFileSizeError | InvalidAudioDurationError
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.UploadAnAudioResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.UploadAnAudioResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.UploadAnAudioResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.UploadAnAudioResponse2>(
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
            // AuthorizationError
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.UploadAnAudioResponse3? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.UploadAnAudioResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.UploadAnAudioResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.UploadAnAudioResponse3>(
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
            // InsufficientCreditsError
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                global::G.UploadAnAudioResponse4? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::G.UploadAnAudioResponse4.FromJson(__content_402, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_402 = global::G.UploadAnAudioResponse4.FromJson(__content_402, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::G.ApiException<global::G.UploadAnAudioResponse4>(
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
            // UnsupportedMimeTypeError
            if ((int)__response.StatusCode == 415)
            {
                string? __content_415 = null;
                global::System.Exception? __exception_415 = null;
                global::G.UploadAnAudioResponse5? __value_415 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_415 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_415 = global::G.UploadAnAudioResponse5.FromJson(__content_415, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_415 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_415 = global::G.UploadAnAudioResponse5.FromJson(__content_415, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_415 = __ex;
                }

                throw new global::G.ApiException<global::G.UploadAnAudioResponse5>(
                    message: __content_415 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_415,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_415,
                    ResponseObject = __value_415,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // AudioModerationError
            if ((int)__response.StatusCode == 451)
            {
                string? __content_451 = null;
                global::System.Exception? __exception_451 = null;
                global::G.UploadAnAudioResponse6? __value_451 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_451 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_451 = global::G.UploadAnAudioResponse6.FromJson(__content_451, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_451 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_451 = global::G.UploadAnAudioResponse6.FromJson(__content_451, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_451 = __ex;
                }

                throw new global::G.ApiException<global::G.UploadAnAudioResponse6>(
                    message: __content_451 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_451,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_451,
                    ResponseObject = __value_451,
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
                ProcessUploadAnAudioResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.UploadAnAudioResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.UploadAnAudioResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Upload audio file<br/>
        /// Upload an audio file to a temporary storage before creating an animation.<br/>
        /// The audio is uploaded using multipart/form-data. the filename directive is optional and if provided should contain up to 50 valid characters long.<br/>
        /// The resulting file is stored as a .wav file in a 16kHz sample rate.<br/>
        /// Valid characters: a-z A-Z 0-9 . _ -<br/>
        /// Supported mime types: "audio/, video/"<br/>
        /// Storage duration: 24-48H
        /// </summary>
        /// <param name="audio">
        /// The uploaded audio file, the file must not exceed 6MB in size.
        /// </param>
        /// <param name="audioname">
        /// The uploaded audio file, the file must not exceed 6MB in size.
        /// </param>
        /// <param name="sourceUrl"></param>
        /// <param name="resultUrl">
        /// A URL to upload the audio to. If provided, the audio will be uploaded to this URL instead of the default bucket. https presigned URL supported. S3 presigned urls should have the putObject permission with content type audio/wav.
        /// </param>
        /// <param name="persist"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UploadAnAudioResponse> UploadAnAudioAsync(
            byte[]? audio = default,
            string? audioname = default,
            string? sourceUrl = default,
            string? resultUrl = default,
            string? persist = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.UploadAnAudioRequest
            {
                Audio = audio,
                Audioname = audioname,
                SourceUrl = sourceUrl,
                ResultUrl = resultUrl,
                Persist = persist,
            };

            return await UploadAnAudioAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}