//HintName: G.Api.OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPost.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xDeepinfraSource,
            ref string? xiApiKey,
            global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPost request);
        partial void PrepareOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xDeepinfraSource,
            string? xiApiKey,
            global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPost request);
        partial void ProcessOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Openai Audio Transcriptions
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostAsync(
            global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPost request,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostArguments(
                httpClient: HttpClient,
                xDeepinfraSource: ref xDeepinfraSource,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/openai/audio/transcriptions",
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

            if (xDeepinfraSource != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-deepinfra-source", xDeepinfraSource.ToString());
            }
            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (xDeepinfraSource != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xDeepinfraSource}"),
                    name: "x-deepinfra-source");
            } 
            if (xiApiKey != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xiApiKey}"),
                    name: "xi-api-key");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>()),
                name: "file",
                fileName: request.Filename ?? string.Empty);
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Model}"),
                name: "model");
            if (request.Language != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Language}"),
                    name: "language");
            } 
            if (request.Prompt != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Prompt}"),
                    name: "prompt");
            } 
            if (request.ResponseFormat != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ResponseFormat?.ToValueString()}"),
                    name: "response_format");
            } 
            if (request.Temperature != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Temperature}"),
                    name: "temperature");
            } 
            if (request.TimestampGranularities != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.TimestampGranularities, x => x.ToValueString()))}]"),
                    name: "timestamp_granularities");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xDeepinfraSource: xDeepinfraSource,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponse(
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
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
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
                ProcessOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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

                    var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
                }
                catch (global::System.Exception __ex)
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
            }
        }

        /// <summary>
        /// Openai Audio Transcriptions
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="model"></param>
        /// <param name="language"></param>
        /// <param name="prompt"></param>
        /// <param name="responseFormat">
        /// Default Value: json
        /// </param>
        /// <param name="temperature">
        /// Default Value: 0
        /// </param>
        /// <param name="timestampGranularities"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostAsync(
            byte[] file,
            string filename,
            string model,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            string? language = default,
            string? prompt = default,
            global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat? responseFormat = default,
            double? temperature = default,
            global::System.Collections.Generic.IList<global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitie>? timestampGranularities = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPost
            {
                File = file,
                Filename = filename,
                Model = model,
                Language = language,
                Prompt = prompt,
                ResponseFormat = responseFormat,
                Temperature = temperature,
                TimestampGranularities = timestampGranularities,
            };

            return await OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostAsync(
                xDeepinfraSource: xDeepinfraSource,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}