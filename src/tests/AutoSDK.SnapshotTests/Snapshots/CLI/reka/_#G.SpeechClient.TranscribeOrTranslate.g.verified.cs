//HintName: G.SpeechClient.TranscribeOrTranslate.g.cs

#nullable enable

namespace G
{
    public partial class SpeechClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_TranscribeOrTranslateSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApiKeyAuth",
                        Location = "Header",
                        Name = "X-Api-Key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_TranscribeOrTranslateSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_TranscribeOrTranslateSecurityRequirement0,
            };
        partial void PrepareTranscribeOrTranslateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.TranscribeOrTranslateRequest request);
        partial void PrepareTranscribeOrTranslateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.TranscribeOrTranslateRequest request);
        partial void ProcessTranscribeOrTranslateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTranscribeOrTranslateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Transcribe or translate audio<br/>
        /// Transcribes audio to text and optionally translates it to a target language.<br/>
        /// Supports three modes: transcription only, translation (text output), and<br/>
        /// speech-to-speech translation (with audio output).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TranscribeOrTranslateResponse> TranscribeOrTranslateAsync(

            global::G.TranscribeOrTranslateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTranscribeOrTranslateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TranscribeOrTranslateSecurityRequirements,
                operationName: "TranscribeOrTranslateAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/transcription_or_translation",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTranscribeOrTranslateRequest(
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
            ProcessTranscribeOrTranslateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
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
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessTranscribeOrTranslateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.TranscribeOrTranslateResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.TranscribeOrTranslateResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Transcribe or translate audio<br/>
        /// Transcribes audio to text and optionally translates it to a target language.<br/>
        /// Supports three modes: transcription only, translation (text output), and<br/>
        /// speech-to-speech translation (with audio output).
        /// </summary>
        /// <param name="audioUrl">
        /// URL to a WAV audio file (http/https) or a base64-encoded data URI (data:audio/wav;base64,...).
        /// </param>
        /// <param name="samplingRate">
        /// Audio sampling rate in Hz. Recommended value is 16000.<br/>
        /// Default Value: 16000
        /// </param>
        /// <param name="targetLanguage">
        /// Target language for translation. When omitted, only transcription is performed.
        /// </param>
        /// <param name="isTranslate">
        /// Set to true to indicate this is a translation request. Must be true when target_language is specified.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnTranslationAudio">
        /// Set to true to receive base64-encoded WAV audio of the translated speech. Requires is_translate and target_language.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="temperature">
        /// Controls randomness in generation. Use 0.0 for deterministic output.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TranscribeOrTranslateResponse> TranscribeOrTranslateAsync(
            string audioUrl,
            int samplingRate,
            global::G.TranscribeOrTranslateRequestTargetLanguage? targetLanguage = default,
            bool? isTranslate = default,
            bool? returnTranslationAudio = default,
            double? temperature = default,
            int? maxTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TranscribeOrTranslateRequest
            {
                AudioUrl = audioUrl,
                SamplingRate = samplingRate,
                TargetLanguage = targetLanguage,
                IsTranslate = isTranslate,
                ReturnTranslationAudio = returnTranslationAudio,
                Temperature = temperature,
                MaxTokens = maxTokens,
            };

            return await TranscribeOrTranslateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}