//HintName: G.Api.PublicCreateRoom.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PreparePublicCreateRoomArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PublicCreateRoomRequest request);
        partial void PreparePublicCreateRoomRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PublicCreateRoomRequest request);
        partial void ProcessPublicCreateRoomResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPublicCreateRoomResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 创建房间<br/>
        /// {"0":{"ops":[{"insert":"创建房间，并将智能体加入房间。\n"},{"attributes":{"heading":"h2","anchor":"bc27564a","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"s3JUqU6ETU","zoneType":"Z","type":"warning","title":"注意","border":"#fed4a4","background":"#fff5eb","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"扣子智能语音功能通过 RTC 技术实现用户和智能体的实时语音通话。在 RTC 领域中，房间是一个虚拟的概念，类似逻辑上的分组，同一个房间内的用户才能互相接收和交换音视频数据、实现音视频通话。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此 API 用于创建一个房间，并将智能体加入房间，然后才能调用 RTC SDK 和智能体开始语音通话。\n"}],"zoneId":"0","zoneType":"Z"},"s3JUqU6ETU":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"调用创建房间 API 之后，智能体随即加入房间并开始计费，包括智能体的"},{"attributes":{"bold":"true"},"insert":"对话式 Al-音频费用"},{"insert":"和"},{"attributes":{"bold":"true"},"insert":"语音通话费用"},{"insert":"，具体费用详情请参考"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/coze_pro/asr_tts_fee#f4e51f74\",\"linkId\":\"mxSwtZlTiE\",\"newTab\":true}"},"insert":"音视频费用"},{"insert":"。"},{"attributes":{"bold":"true"},"insert":"为避免不必要的费用产生，请在调用接口前仔细了解费用详情，并合理控制创建房间接口的调用频率。"},{"insert":"\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"用户未加入房间与智能体进行对话时，智能体会在房间等待用户 3 分钟，这期间会产生 3 分钟的最低费用。\n"}],"zoneId":"s3JUqU6ETU","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PublicCreateRoomResponse> PublicCreateRoomAsync(

            global::G.PublicCreateRoomRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePublicCreateRoomArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/audio/rooms",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePublicCreateRoomRequest(
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
            ProcessPublicCreateRoomResponse(
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
                ProcessPublicCreateRoomResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PublicCreateRoomResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PublicCreateRoomResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 创建房间<br/>
        /// {"0":{"ops":[{"insert":"创建房间，并将智能体加入房间。\n"},{"attributes":{"heading":"h2","anchor":"bc27564a","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"s3JUqU6ETU","zoneType":"Z","type":"warning","title":"注意","border":"#fed4a4","background":"#fff5eb","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"扣子智能语音功能通过 RTC 技术实现用户和智能体的实时语音通话。在 RTC 领域中，房间是一个虚拟的概念，类似逻辑上的分组，同一个房间内的用户才能互相接收和交换音视频数据、实现音视频通话。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此 API 用于创建一个房间，并将智能体加入房间，然后才能调用 RTC SDK 和智能体开始语音通话。\n"}],"zoneId":"0","zoneType":"Z"},"s3JUqU6ETU":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"调用创建房间 API 之后，智能体随即加入房间并开始计费，包括智能体的"},{"attributes":{"bold":"true"},"insert":"对话式 Al-音频费用"},{"insert":"和"},{"attributes":{"bold":"true"},"insert":"语音通话费用"},{"insert":"，具体费用详情请参考"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/coze_pro/asr_tts_fee#f4e51f74\",\"linkId\":\"mxSwtZlTiE\",\"newTab\":true}"},"insert":"音视频费用"},{"insert":"。"},{"attributes":{"bold":"true"},"insert":"为避免不必要的费用产生，请在调用接口前仔细了解费用详情，并合理控制创建房间接口的调用频率。"},{"insert":"\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"用户未加入房间与智能体进行对话时，智能体会在房间等待用户 3 分钟，这期间会产生 3 分钟的最低费用。\n"}],"zoneId":"s3JUqU6ETU","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId">
        /// 必选参数，Bot id
        /// </param>
        /// <param name="config">
        /// 可选参数，room 的配置
        /// </param>
        /// <param name="conversationId">
        /// 可选参数， conversation_id，不传会默认创建一个，见【创建会话】接口
        /// </param>
        /// <param name="uid">
        /// 可选参数，标识当前与智能体的用户，由使用方自行定义、生成与维护。uid 用于标识对话中的不同用户，不同的 uid，其对话的数据库等对话记忆数据互相隔离。如果不需要用户数据隔离，可以不传此参数。
        /// </param>
        /// <param name="voiceId">
        /// 可选参数，音色 id，不传默认为 xxxy音色
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PublicCreateRoomResponse> PublicCreateRoomAsync(
            string botId,
            global::G.PropertiesConfig? config = default,
            string? conversationId = default,
            string? uid = default,
            string? voiceId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PublicCreateRoomRequest
            {
                BotId = botId,
                Config = config,
                ConversationId = conversationId,
                Uid = uid,
                VoiceId = voiceId,
            };

            return await PublicCreateRoomAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}