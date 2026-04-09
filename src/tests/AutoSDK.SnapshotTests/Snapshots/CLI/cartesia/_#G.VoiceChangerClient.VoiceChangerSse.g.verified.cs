//HintName: G.VoiceChangerClient.VoiceChangerSse.g.cs

#nullable enable

namespace G
{
    public partial class VoiceChangerClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_VoiceChangerSseSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_VoiceChangerSseSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_VoiceChangerSseSecurityRequirement0,
            };
        partial void PrepareVoiceChangerSseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.VoiceChangerSseCartesiaVersion cartesiaVersion,
            global::G.VoiceChangerSseRequest request);
        partial void PrepareVoiceChangerSseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.VoiceChangerSseCartesiaVersion cartesiaVersion,
            global::G.VoiceChangerSseRequest request);
        partial void ProcessVoiceChangerSseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Voice Changer (SSE)
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task VoiceChangerSseAsync(
            global::G.VoiceChangerSseCartesiaVersion cartesiaVersion,

            global::G.VoiceChangerSseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareVoiceChangerSseArguments(
                httpClient: HttpClient,
                cartesiaVersion: ref cartesiaVersion,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_VoiceChangerSseSecurityRequirements,
                operationName: "VoiceChangerSseAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/voice-changer/sse",
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

            __httpRequest.Headers.TryAddWithoutValidation("Cartesia-Version", cartesiaVersion.ToValueString());

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{cartesiaVersion.ToValueString()}"),
                name: "\"Cartesia-Version\"");
            if (request.Clip != default)
            {

                var __contentClip = new global::System.Net.Http.ByteArrayContent(request.Clip ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentClip,
                    name: "\"clip\"",
                    fileName: request.Clipname != null ? $"\"{request.Clipname}\"" : string.Empty);
                if (__contentClip.Headers.ContentDisposition != null)
                {
                    __contentClip.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.VoiceId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VoiceId}"),
                    name: "\"voice[id]\"");
            } 
            if (request.OutputFormatContainer != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputFormatContainer?.ToValueString()}"),
                    name: "\"output_format[container]\"");
            } 
            if (request.OutputFormatSampleRate != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputFormatSampleRate}"),
                    name: "\"output_format[sample_rate]\"");
            } 
            if (request.OutputFormatEncoding != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputFormatEncoding?.ToValueString()}"),
                    name: "\"output_format[encoding]\"");
            } 
            if (request.OutputFormatBitRate != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputFormatBitRate}"),
                    name: "\"output_format[bit_rate]\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareVoiceChangerSseRequest(
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
            ProcessVoiceChangerSseResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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

                try
                {
                    __response.EnsureSuccessStatusCode();

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
        /// Voice Changer (SSE)
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="clip"></param>
        /// <param name="clipname"></param>
        /// <param name="voiceId"></param>
        /// <param name="outputFormatContainer"></param>
        /// <param name="outputFormatSampleRate"></param>
        /// <param name="outputFormatEncoding"></param>
        /// <param name="outputFormatBitRate">
        /// Required for `mp3` containers.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task VoiceChangerSseAsync(
            global::G.VoiceChangerSseCartesiaVersion cartesiaVersion,
            byte[]? clip = default,
            string? clipname = default,
            string? voiceId = default,
            global::G.OutputFormatContainer? outputFormatContainer = default,
            int? outputFormatSampleRate = default,
            global::G.RawEncoding? outputFormatEncoding = default,
            int? outputFormatBitRate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.VoiceChangerSseRequest
            {
                Clip = clip,
                Clipname = clipname,
                VoiceId = voiceId,
                OutputFormatContainer = outputFormatContainer,
                OutputFormatSampleRate = outputFormatSampleRate,
                OutputFormatEncoding = outputFormatEncoding,
                OutputFormatBitRate = outputFormatBitRate,
            };

            await VoiceChangerSseAsync(
                cartesiaVersion: cartesiaVersion,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}