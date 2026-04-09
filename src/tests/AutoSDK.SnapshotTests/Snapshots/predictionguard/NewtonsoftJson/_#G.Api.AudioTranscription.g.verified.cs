//HintName: G.Api.AudioTranscription.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_AudioTranscriptionSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_AudioTranscriptionSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_AudioTranscriptionSecurityRequirement0,
            };
        partial void PrepareAudioTranscriptionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? toxicity,
            ref string? pii,
            ref string? replaceMethod,
            global::System.Collections.Generic.IList<string>? entityList,
            ref bool? injection,
            global::G.AudioTranscriptionRequest request);
        partial void PrepareAudioTranscriptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? toxicity,
            string? pii,
            string? replaceMethod,
            global::System.Collections.Generic.IList<string>? entityList,
            bool? injection,
            global::G.AudioTranscriptionRequest request);
        partial void ProcessAudioTranscriptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAudioTranscriptionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Audio Transcription<br/>
        /// This endpoint allows you to transcribe audio.
        /// </summary>
        /// <param name="toxicity"></param>
        /// <param name="pii"></param>
        /// <param name="replaceMethod"></param>
        /// <param name="entityList"></param>
        /// <param name="injection"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AudioTranscriptionResponse200> AudioTranscriptionAsync(

            global::G.AudioTranscriptionRequest request,
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
            PrepareAudioTranscriptionArguments(
                httpClient: HttpClient,
                toxicity: ref toxicity,
                pii: ref pii,
                replaceMethod: ref replaceMethod,
                entityList: entityList,
                injection: ref injection,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AudioTranscriptionSecurityRequirements,
                operationName: "AudioTranscriptionAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/audio/transcriptions",
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
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Model}"),
                name: "\"model\"");
            var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentFile,
                name: "\"file\"",
                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
            if (__contentFile.Headers.ContentDisposition != null)
            {
                __contentFile.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.Language != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Language}"),
                    name: "\"language\"");
            } 
            if (request.Prompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Prompt}"),
                    name: "\"prompt\"");
            } 
            if (request.Temperature != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Temperature}"),
                    name: "\"temperature\"");
            } 
            if (request.TimestampsGranularities != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.TimestampsGranularities?.ToString() ?? string.Empty),
                    name: "\"timestamps_granularities[]\"");
            } 
            if (request.Diarization != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Diarization}"),
                    name: "\"diarization\"");
            } 
            if (request.ResponseFormat != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ResponseFormat}"),
                    name: "\"response_format\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAudioTranscriptionRequest(
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
            ProcessAudioTranscriptionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // General error response.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.AudioTranscriptionRequestBadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.AudioTranscriptionRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.AudioTranscriptionRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.AudioTranscriptionRequestBadRequestError>(
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
                global::G.AudioTranscriptionRequestForbiddenError? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.AudioTranscriptionRequestForbiddenError.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.AudioTranscriptionRequestForbiddenError.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.AudioTranscriptionRequestForbiddenError>(
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
                ProcessAudioTranscriptionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AudioTranscriptionResponse200.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.AudioTranscriptionResponse200.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Audio Transcription<br/>
        /// This endpoint allows you to transcribe audio.
        /// </summary>
        /// <param name="toxicity"></param>
        /// <param name="pii"></param>
        /// <param name="replaceMethod"></param>
        /// <param name="entityList"></param>
        /// <param name="injection"></param>
        /// <param name="model">
        /// The transcription model to use.
        /// </param>
        /// <param name="file">
        /// The audio file to upload.
        /// </param>
        /// <param name="filename">
        /// The audio file to upload.
        /// </param>
        /// <param name="language">
        /// The language the audio is in.
        /// </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio segment.
        /// </param>
        /// <param name="temperature">
        /// The temperature parameter for controlling randomness in transcription. Supports a range of 0.0-2.0.
        /// </param>
        /// <param name="timestampsGranularities">
        /// Sets whether timestamps are returned and at what granularity.
        /// </param>
        /// <param name="diarization">
        /// Whether to diarize the audio and return speaker turns. Not currently supported in multi-tenant environments.
        /// </param>
        /// <param name="responseFormat">
        /// The format for the response object. Defaults to "json" and must be set to "verbose_json" when using diarization or timestamp granularities.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AudioTranscriptionResponse200> AudioTranscriptionAsync(
            string model,
            byte[] file,
            string filename,
            bool? toxicity = default,
            string? pii = default,
            string? replaceMethod = default,
            global::System.Collections.Generic.IList<string>? entityList = default,
            bool? injection = default,
            string? language = default,
            string? prompt = default,
            double? temperature = default,
            global::G.AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities? timestampsGranularities = default,
            bool? diarization = default,
            string? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.AudioTranscriptionRequest
            {
                Model = model,
                File = file,
                Filename = filename,
                Language = language,
                Prompt = prompt,
                Temperature = temperature,
                TimestampsGranularities = timestampsGranularities,
                Diarization = diarization,
                ResponseFormat = responseFormat,
            };

            return await AudioTranscriptionAsync(
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