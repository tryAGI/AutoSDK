//HintName: G.InfillClient.InfillBytes.g.cs

#nullable enable

namespace G
{
    public partial class InfillClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_InfillBytesSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "TokenAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_InfillBytesSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_InfillBytesSecurityRequirement0,
            };
        partial void PrepareInfillBytesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.InfillBytesCartesiaVersion cartesiaVersion,
            global::G.InfillBytesRequest request);
        partial void PrepareInfillBytesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.InfillBytesCartesiaVersion cartesiaVersion,
            global::G.InfillBytesRequest request);
        partial void ProcessInfillBytesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInfillBytesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Infill (Bytes)<br/>
        /// Generate audio that smoothly connects two existing audio segments. This is useful for inserting new speech between existing speech segments while maintaining natural transitions.<br/>
        /// **The cost is 1 credit per character of the infill text plus a fixed cost of 300 credits.**<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// As with all generative models, there's some inherent variability, but here's some tips we recommend to get the best results from infill:<br/>
        /// - Use longer infill transcripts<br/>
        ///   - This gives the model more flexibility to adapt to the rest of the audio<br/>
        /// - Target natural pauses in the audio when deciding where to clip<br/>
        ///   - This means you don't need word-level timestamps to be as precise<br/>
        /// - Clip right up to the start and end of the audio segment you want infilled, keeping as much silence in the left/right audio segments as possible<br/>
        ///   - This helps the model generate more natural transitions
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> InfillBytesAsync(
            global::G.InfillBytesCartesiaVersion cartesiaVersion,

            global::G.InfillBytesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareInfillBytesArguments(
                httpClient: HttpClient,
                cartesiaVersion: ref cartesiaVersion,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_InfillBytesSecurityRequirements,
                operationName: "InfillBytesAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/infill/bytes",
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

            __httpRequest.Headers.TryAddWithoutValidation("Cartesia-Version", cartesiaVersion.ToValueString());

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{cartesiaVersion.ToValueString()}"),
                name: "\"Cartesia-Version\"");
            if (request.LeftAudio != default)
            {

                var __contentLeftAudio = new global::System.Net.Http.ByteArrayContent(request.LeftAudio ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentLeftAudio,
                    name: "\"left_audio\"",
                    fileName: request.LeftAudioname != null ? $"\"{request.LeftAudioname}\"" : string.Empty);
                if (__contentLeftAudio.Headers.ContentDisposition != null)
                {
                    __contentLeftAudio.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.RightAudio != default)
            {

                var __contentRightAudio = new global::System.Net.Http.ByteArrayContent(request.RightAudio ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentRightAudio,
                    name: "\"right_audio\"",
                    fileName: request.RightAudioname != null ? $"\"{request.RightAudioname}\"" : string.Empty);
                if (__contentRightAudio.Headers.ContentDisposition != null)
                {
                    __contentRightAudio.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.ModelId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ModelId}"),
                    name: "\"model_id\"");
            } 
            if (request.Language != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Language}"),
                    name: "\"language\"");
            } 
            if (request.Transcript != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Transcript}"),
                    name: "\"transcript\"");
            } 
            if (request.VoiceId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VoiceId}"),
                    name: "\"voice_id\"");
            } 
            if (request.OutputFormat != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.OutputFormat?.ToString() ?? string.Empty),
                    name: "\"output_format\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareInfillBytesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cartesiaVersion: cartesiaVersion,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessInfillBytesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessInfillBytesResponseContent(
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
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
        /// Infill (Bytes)<br/>
        /// Generate audio that smoothly connects two existing audio segments. This is useful for inserting new speech between existing speech segments while maintaining natural transitions.<br/>
        /// **The cost is 1 credit per character of the infill text plus a fixed cost of 300 credits.**<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// As with all generative models, there's some inherent variability, but here's some tips we recommend to get the best results from infill:<br/>
        /// - Use longer infill transcripts<br/>
        ///   - This gives the model more flexibility to adapt to the rest of the audio<br/>
        /// - Target natural pauses in the audio when deciding where to clip<br/>
        ///   - This means you don't need word-level timestamps to be as precise<br/>
        /// - Clip right up to the start and end of the audio segment you want infilled, keeping as much silence in the left/right audio segments as possible<br/>
        ///   - This helps the model generate more natural transitions
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="leftAudio"></param>
        /// <param name="leftAudioname"></param>
        /// <param name="rightAudio"></param>
        /// <param name="rightAudioname"></param>
        /// <param name="modelId">
        /// The ID of the model to use for generating audio. Any model other than the first `"sonic"` model is supported.
        /// </param>
        /// <param name="language">
        /// The language of the transcript
        /// </param>
        /// <param name="transcript">
        /// The infill text to generate
        /// </param>
        /// <param name="voiceId">
        /// The ID of the voice to use for generating audio
        /// </param>
        /// <param name="outputFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> InfillBytesAsync(
            global::G.InfillBytesCartesiaVersion cartesiaVersion,
            byte[]? leftAudio = default,
            string? leftAudioname = default,
            byte[]? rightAudio = default,
            string? rightAudioname = default,
            string? modelId = default,
            string? language = default,
            string? transcript = default,
            string? voiceId = default,
            global::G.OutputFormat? outputFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.InfillBytesRequest
            {
                LeftAudio = leftAudio,
                LeftAudioname = leftAudioname,
                RightAudio = rightAudio,
                RightAudioname = rightAudioname,
                ModelId = modelId,
                Language = language,
                Transcript = transcript,
                VoiceId = voiceId,
                OutputFormat = outputFormat,
            };

            return await InfillBytesAsync(
                cartesiaVersion: cartesiaVersion,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}