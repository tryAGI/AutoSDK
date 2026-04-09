//HintName: G.Api.PublicAudioSpeech.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_PublicAudioSpeechSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_PublicAudioSpeechSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_PublicAudioSpeechSecurityRequirement0,
            };
        partial void PreparePublicAudioSpeechArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PublicAudioSpeechRequest request);
        partial void PreparePublicAudioSpeechRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PublicAudioSpeechRequest request);
        partial void ProcessPublicAudioSpeechResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPublicAudioSpeechResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 语音合成<br/>
        /// {"0":{"ops":[{"insert":"将指定文本合成为音频文件。\n"},{"attributes":{"anchor":"677ab7d5","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此 API 用于将指定文本内容合成为自然流畅的音频，同步返回合成的音频文件，适用于有声书合成、智能客服语音、音视频配音等场景。合成音频文件之前，可以先调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/list_voices\",\"linkId\":\"ZEUd6rdOvN\"}"},"insert":"查看音色列表"},{"insert":" API，查看所有可用音色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"KCecIryVWB","zoneType":"Z","type":"warning","title":"注意","border":"#fed4a4","background":"#fff5eb","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"KCecIryVWB":{"ops":[{"insert":"调用语音合成 API 会产生"},{"attributes":{"bold":"true"},"insert":"语音合成费用"},{"insert":"，具体费用详情请参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/coze_pro/asr_tts_fee#b7ced22d\",\"linkId\":\"CEZbHqqDri\",\"newTab\":true}"},"insert":"音视频费用"},{"insert":"。\n"}],"zoneId":"KCecIryVWB","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PublicAudioSpeechResponse> PublicAudioSpeechAsync(

            global::G.PublicAudioSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePublicAudioSpeechArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PublicAudioSpeechSecurityRequirements,
                operationName: "PublicAudioSpeechAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/audio/speech",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePublicAudioSpeechRequest(
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
            ProcessPublicAudioSpeechResponse(
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
                ProcessPublicAudioSpeechResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PublicAudioSpeechResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PublicAudioSpeechResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 语音合成<br/>
        /// {"0":{"ops":[{"insert":"将指定文本合成为音频文件。\n"},{"attributes":{"anchor":"677ab7d5","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此 API 用于将指定文本内容合成为自然流畅的音频，同步返回合成的音频文件，适用于有声书合成、智能客服语音、音视频配音等场景。合成音频文件之前，可以先调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/list_voices\",\"linkId\":\"ZEUd6rdOvN\"}"},"insert":"查看音色列表"},{"insert":" API，查看所有可用音色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"KCecIryVWB","zoneType":"Z","type":"warning","title":"注意","border":"#fed4a4","background":"#fff5eb","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"KCecIryVWB":{"ops":[{"insert":"调用语音合成 API 会产生"},{"attributes":{"bold":"true"},"insert":"语音合成费用"},{"insert":"，具体费用详情请参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/coze_pro/asr_tts_fee#b7ced22d\",\"linkId\":\"CEZbHqqDri\",\"newTab\":true}"},"insert":"音视频费用"},{"insert":"。\n"}],"zoneId":"KCecIryVWB","zoneType":"Z"}}
        /// </summary>
        /// <param name="contextTexts">
        /// 语音合成辅助信息
        /// </param>
        /// <param name="emotion">
        /// 情感，可选值 [none,happy,angry,sad,neutral]，默认 none
        /// </param>
        /// <param name="emotionScale">
        /// 情绪值，[1,5]，默认 4
        /// </param>
        /// <param name="input">
        /// 必选，合成语音的文本，长度限制 1024 字节（UTF-8编码）。
        /// </param>
        /// <param name="loudnessRate">
        /// 音量，[-50,100]，默认 0
        /// </param>
        /// <param name="responseFormat">
        /// 音频编码格式，wav / pcm / ogg_opus / mp3，默认为 mp3
        /// </param>
        /// <param name="sampleRate">
        /// 采样率，可选值 [8000,16000,22050,24000,32000,44100,48000]，默认 24000
        /// </param>
        /// <param name="speed">
        /// 语速，[0.2,3]，默认为1，通常保留一位小数即可
        /// </param>
        /// <param name="voiceId">
        /// 必选，音色id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PublicAudioSpeechResponse> PublicAudioSpeechAsync(
            string input,
            string voiceId,
            string? contextTexts = default,
            global::G.PublicAudioSpeechRequestEmotion? emotion = default,
            double? emotionScale = default,
            int? loudnessRate = default,
            global::G.PublicAudioSpeechRequestResponseFormat? responseFormat = default,
            int? sampleRate = default,
            double? speed = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PublicAudioSpeechRequest
            {
                ContextTexts = contextTexts,
                Emotion = emotion,
                EmotionScale = emotionScale,
                Input = input,
                LoudnessRate = loudnessRate,
                ResponseFormat = responseFormat,
                SampleRate = sampleRate,
                Speed = speed,
                VoiceId = voiceId,
            };

            return await PublicAudioSpeechAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}