//HintName: G.Api.PublicCloneVoice.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_PublicCloneVoiceSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_PublicCloneVoiceSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_PublicCloneVoiceSecurityRequirement0,
            };
        partial void PreparePublicCloneVoiceArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PublicCloneVoiceRequest request);
        partial void PreparePublicCloneVoiceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PublicCloneVoiceRequest request);
        partial void ProcessPublicCloneVoiceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPublicCloneVoiceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 复刻音色<br/>
        /// {"0":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"复刻指定音频文件中人声的音色。\n"},{"attributes":{"heading":"h2","anchor":"3f525ba3","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"c5MaoBbFEq","zoneType":"Z","type":"warning","title":"注意","border":"#fed4a4","background":"#fff5eb","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"和扣子智能体进行实时的智能语音通话时，你可以选择智能体使用的音色，支持使用扣子编程提供系统内置音色，或通过"},{"attributes":{"bold":"true"},"insert":"复刻音色"},{"insert":" API 复刻出的自定义音色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此 API 用于上传音频文件复刻一个新的音色。调用此 API 时需要上传一个音频文件作为音色复刻的素材。扣子编程会自动复刻音频文件中的人声音色，并将音色保存在当前账号的音色列表中。复刻出的音色可以用于合成语音，或者在扣子编程实时通话中作为智能体的音色。\n"},{"attributes":{"zoneId":"KCcSMkPgIR","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"anchor":"3b2af951","heading":"h3","lmkr":"1"},"insert":"*"},{"insert":"音色复刻素材要求\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"上传的音频文件素材应符合以下要求：\n"},{"attributes":{"aceTable":"rstw9af3o030ig2p2hu6g3ika0tosyulfb csde2erwde56jtl51i7nrq49730aq6248v"},"insert":"*"},{"insert":"\n"},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"c5MaoBbFEq":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"仅扣子企业版（企业标准版、企业旗舰版）用户可以使用音色复刻功能。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"企业版订阅套餐中默认赠送了一个复刻音色，如需调用复刻音色 OpenAPI 复刻更多音色，请联系超级管理员或管理员购买音色复刻扩容包，具体步骤请参见"},{"insert":"购买音色复刻扩容包","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/dev_how_to_guides/voice_clone#b6142634\",\"linkId\":\"THjJ1cI6xD\",\"newTab\":true}"}},{"insert":"。  音色复刻涉及"},{"insert":"音色数量费用","attributes":{"bold":"true"}},{"insert":"和"},{"insert":"音色模型存储数费用","attributes":{"bold":"true"}},{"insert":"，详细的费用信息可参考"},{"insert":"音视频费用","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/coze_pro/asr_tts_fee\",\"linkId\":\"TQj239g3FB\",\"newTab\":true}"}},{"insert":"。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"调用此 API 之前请确认账户中资源点或余额充足，以免账号欠费导致服务中断"},{"insert":"。\n"}],"zoneId":"c5MaoBbFEq","zoneType":"Z"},"KCcSMkPgIR":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"在工作空间中复刻的音色资源仅限于该工作空间的成员使用。即使在同一个企业中，不同工作空间复刻的音色资源是独立的，不允许跨空间使用。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"同一个音色 ID 最多复刻 10 次。为节省音色成本，你可以调用此接口训练自己已复刻的音色，即录制一个新的音频文件重新复刻音色，训练后的音色会覆盖原音色，但音色 ID 不变。例如，购买一个音色后，你可以对这个音色重新免费复刻 9 次。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"必须使用 multipart/form-data 方式上传音频文件。\n"}],"zoneId":"KCcSMkPgIR","zoneType":"Z"},"rstw9af3o030ig2p2hu6g3ika0tosyulfb":{"ops":[{"attributes":{"rowHeight":"41","colWidth":"100"},"insert":{"id":"r1lzjj9b0ev19m6nkkfv73ycj3jadnme7c"}},{"insert":{"id":"r16tl9w6e7gt7n3stqe62b8y8gkl0vuhzv"}},{"insert":{"id":"r1o3p4cp0fafwpqrt9zn8gt9wh6bmvsw39"}},{"insert":{"id":"r1ywgtjnwqiqmfaodl9b54tel15uf2kswo"}},{"attributes":{"rowHeight":"40"},"insert":{"id":"r1ihgfdkog6gnfgfi2hino5ttzwhp6g02k"}},{"insert":{"id":"r1b69hh28jkf2abd31147si9hjsafionni"}}],"zoneId":"rstw9af3o030ig2p2hu6g3ika0tosyulfb","zoneType":"R"},"csde2erwde56jtl51i7nrq49730aq6248v":{"ops":[{"attributes":{"colWidth":"170"},"insert":{"id":"c1kul8eniqvi40z591q2q6pcjml3i0fs3j"}},{"attributes":{"colWidth":"584"},"insert":{"id":"c13j1dgapnqywrrh86m8bkkmuemyascmgo"}}],"zoneId":"csde2erwde56jtl51i7nrq49730aq6248v","zoneType":"C"},"xr1lzjj9b0ev19m6nkkfv73ycj3jadnme7cxc1kul8eniqvi40z591q2q6pcjml3i0fs3j":{"ops":[{"attributes":{"bold":"true"},"insert":"类别"},{"insert":"\n"}],"zoneId":"xr1lzjj9b0ev19m6nkkfv73ycj3jadnme7cxc1kul8eniqvi40z591q2q6pcjml3i0fs3j","zoneType":"Z"},"xr1lzjj9b0ev19m6nkkfv73ycj3jadnme7cxc13j1dgapnqywrrh86m8bkkmuemyascmgo":{"ops":[{"attributes":{"bold":"true"},"insert":"说明"},{"insert":"\n"}],"zoneId":"xr1lzjj9b0ev19m6nkkfv73ycj3jadnme7cxc13j1dgapnqywrrh86m8bkkmuemyascmgo","zoneType":"Z"},"xr16tl9w6e7gt7n3stqe62b8y8gkl0vuhzvxc1kul8eniqvi40z591q2q6pcjml3i0fs3j":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"文件格式\n"}],"zoneId":"xr16tl9w6e7gt7n3stqe62b8y8gkl0vuhzvxc1kul8eniqvi40z591q2q6pcjml3i0fs3j","zoneType":"Z"},"xr16tl9w6e7gt7n3stqe62b8y8gkl0vuhzvxc13j1dgapnqywrrh86m8bkkmuemyascmgo":{"ops":[{"insert":"wav、mp3、ogg、m4a、aac、pcm。其中 pcm 仅支持 24k 采样率，单通道。\n"}],"zoneId":"xr16tl9w6e7gt7n3stqe62b8y8gkl0vuhzvxc13j1dgapnqywrrh86m8bkkmuemyascmgo","zoneType":"Z"},"xr1o3p4cp0fafwpqrt9zn8gt9wh6bmvsw39xc1kul8eniqvi40z591q2q6pcjml3i0fs3j":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"文件大小\n"}],"zoneId":"xr1o3p4cp0fafwpqrt9zn8gt9wh6bmvsw39xc1kul8eniqvi40z591q2q6pcjml3i0fs3j","zoneType":"Z"},"xr1o3p4cp0fafwpqrt9zn8gt9wh6bmvsw39xc13j1dgapnqywrrh86m8bkkmuemyascmgo":{"ops":[{"insert":"最大不超过 10MB。每次最多上传1个音频文件。\n"}],"zoneId":"xr1o3p4cp0fafwpqrt9zn8gt9wh6bmvsw39xc13j1dgapnqywrrh86m8bkkmuemyascmgo","zoneType":"Z"},"xr1ywgtjnwqiqmfaodl9b54tel15uf2kswoxc1kul8eniqvi40z591q2q6pcjml3i0fs3j":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"音频时长\n"}],"zoneId":"xr1ywgtjnwqiqmfaodl9b54tel15uf2kswoxc1kul8eniqvi40z591q2q6pcjml3i0fs3j","zoneType":"Z"},"xr1ywgtjnwqiqmfaodl9b54tel15uf2kswoxc13j1dgapnqywrrh86m8bkkmuemyascmgo":{"ops":[{"insert":"建议 10s~30s。\n"}],"zoneId":"xr1ywgtjnwqiqmfaodl9b54tel15uf2kswoxc13j1dgapnqywrrh86m8bkkmuemyascmgo","zoneType":"Z"},"xr1ihgfdkog6gnfgfi2hino5ttzwhp6g02kxc1kul8eniqvi40z591q2q6pcjml3i0fs3j":{"ops":[{"insert":"语种\n"}],"zoneId":"xr1ihgfdkog6gnfgfi2hino5ttzwhp6g02kxc1kul8eniqvi40z591q2q6pcjml3i0fs3j","zoneType":"Z"},"xr1ihgfdkog6gnfgfi2hino5ttzwhp6g02kxc13j1dgapnqywrrh86m8bkkmuemyascmgo":{"ops":[{"insert":"支持中文、英文、日语、西班牙语、印度尼西亚语葡萄牙语。\n"}],"zoneId":"xr1ihgfdkog6gnfgfi2hino5ttzwhp6g02kxc13j1dgapnqywrrh86m8bkkmuemyascmgo","zoneType":"Z"},"xr1b69hh28jkf2abd31147si9hjsafionnixc1kul8eniqvi40z591q2q6pcjml3i0fs3j":{"ops":[{"insert":"文件录制\n"}],"zoneId":"xr1b69hh28jkf2abd31147si9hjsafionnixc1kul8eniqvi40z591q2q6pcjml3i0fs3j","zoneType":"Z"},"xr1b69hh28jkf2abd31147si9hjsafionnixc13j1dgapnqywrrh86m8bkkmuemyascmgo":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"录制环境：选择安静的空间，建议将麦克风放置在离说话人50厘米以内的位置，尽量保持自然的发声状态，避免刻意改变声线或呢喃，这样得到的音色会更加自然。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"音频质量：确保录音中只包含一个人的声音，说话人应保持清晰的发音和音质、稳定的音量和语速，保持姿态稳定。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"录制内容：避免说话时韵律过于平淡，尽量让语调、节奏和强度有所变化，尽量不要尝试复刻小孩或老人的声音。\n"}],"zoneId":"xr1b69hh28jkf2abd31147si9hjsafionnixc13j1dgapnqywrrh86m8bkkmuemyascmgo","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PublicCloneVoiceResponse> PublicCloneVoiceAsync(

            global::G.PublicCloneVoiceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePublicCloneVoiceArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PublicCloneVoiceSecurityRequirements,
                operationName: "PublicCloneVoiceAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/audio/voices/clone",
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

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Audio}"),
                    name: "\"audio\"");
            }
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.AudioFormat}"),
                name: "\"audio_format\"");
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
            if (request.PreviewText != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PreviewText}"),
                    name: "\"preview_text\"");
            } 
            if (request.SpaceId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SpaceId}"),
                    name: "\"space_id\"");
            } 
            if (request.Text != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Text}"),
                    name: "\"text\"");
            } 
            if (request.VoiceId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VoiceId}"),
                    name: "\"voice_id\"");
            }
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.VoiceName}"),
                name: "\"voice_name\"");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePublicCloneVoiceRequest(
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
            ProcessPublicCloneVoiceResponse(
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
                ProcessPublicCloneVoiceResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PublicCloneVoiceResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PublicCloneVoiceResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 复刻音色<br/>
        /// {"0":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"复刻指定音频文件中人声的音色。\n"},{"attributes":{"heading":"h2","anchor":"3f525ba3","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"c5MaoBbFEq","zoneType":"Z","type":"warning","title":"注意","border":"#fed4a4","background":"#fff5eb","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"和扣子智能体进行实时的智能语音通话时，你可以选择智能体使用的音色，支持使用扣子编程提供系统内置音色，或通过"},{"attributes":{"bold":"true"},"insert":"复刻音色"},{"insert":" API 复刻出的自定义音色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此 API 用于上传音频文件复刻一个新的音色。调用此 API 时需要上传一个音频文件作为音色复刻的素材。扣子编程会自动复刻音频文件中的人声音色，并将音色保存在当前账号的音色列表中。复刻出的音色可以用于合成语音，或者在扣子编程实时通话中作为智能体的音色。\n"},{"attributes":{"zoneId":"KCcSMkPgIR","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"anchor":"3b2af951","heading":"h3","lmkr":"1"},"insert":"*"},{"insert":"音色复刻素材要求\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"上传的音频文件素材应符合以下要求：\n"},{"attributes":{"aceTable":"rstw9af3o030ig2p2hu6g3ika0tosyulfb csde2erwde56jtl51i7nrq49730aq6248v"},"insert":"*"},{"insert":"\n"},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"c5MaoBbFEq":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"仅扣子企业版（企业标准版、企业旗舰版）用户可以使用音色复刻功能。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"企业版订阅套餐中默认赠送了一个复刻音色，如需调用复刻音色 OpenAPI 复刻更多音色，请联系超级管理员或管理员购买音色复刻扩容包，具体步骤请参见"},{"insert":"购买音色复刻扩容包","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/dev_how_to_guides/voice_clone#b6142634\",\"linkId\":\"THjJ1cI6xD\",\"newTab\":true}"}},{"insert":"。  音色复刻涉及"},{"insert":"音色数量费用","attributes":{"bold":"true"}},{"insert":"和"},{"insert":"音色模型存储数费用","attributes":{"bold":"true"}},{"insert":"，详细的费用信息可参考"},{"insert":"音视频费用","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/coze_pro/asr_tts_fee\",\"linkId\":\"TQj239g3FB\",\"newTab\":true}"}},{"insert":"。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"调用此 API 之前请确认账户中资源点或余额充足，以免账号欠费导致服务中断"},{"insert":"。\n"}],"zoneId":"c5MaoBbFEq","zoneType":"Z"},"KCcSMkPgIR":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"在工作空间中复刻的音色资源仅限于该工作空间的成员使用。即使在同一个企业中，不同工作空间复刻的音色资源是独立的，不允许跨空间使用。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"同一个音色 ID 最多复刻 10 次。为节省音色成本，你可以调用此接口训练自己已复刻的音色，即录制一个新的音频文件重新复刻音色，训练后的音色会覆盖原音色，但音色 ID 不变。例如，购买一个音色后，你可以对这个音色重新免费复刻 9 次。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"必须使用 multipart/form-data 方式上传音频文件。\n"}],"zoneId":"KCcSMkPgIR","zoneType":"Z"},"rstw9af3o030ig2p2hu6g3ika0tosyulfb":{"ops":[{"attributes":{"rowHeight":"41","colWidth":"100"},"insert":{"id":"r1lzjj9b0ev19m6nkkfv73ycj3jadnme7c"}},{"insert":{"id":"r16tl9w6e7gt7n3stqe62b8y8gkl0vuhzv"}},{"insert":{"id":"r1o3p4cp0fafwpqrt9zn8gt9wh6bmvsw39"}},{"insert":{"id":"r1ywgtjnwqiqmfaodl9b54tel15uf2kswo"}},{"attributes":{"rowHeight":"40"},"insert":{"id":"r1ihgfdkog6gnfgfi2hino5ttzwhp6g02k"}},{"insert":{"id":"r1b69hh28jkf2abd31147si9hjsafionni"}}],"zoneId":"rstw9af3o030ig2p2hu6g3ika0tosyulfb","zoneType":"R"},"csde2erwde56jtl51i7nrq49730aq6248v":{"ops":[{"attributes":{"colWidth":"170"},"insert":{"id":"c1kul8eniqvi40z591q2q6pcjml3i0fs3j"}},{"attributes":{"colWidth":"584"},"insert":{"id":"c13j1dgapnqywrrh86m8bkkmuemyascmgo"}}],"zoneId":"csde2erwde56jtl51i7nrq49730aq6248v","zoneType":"C"},"xr1lzjj9b0ev19m6nkkfv73ycj3jadnme7cxc1kul8eniqvi40z591q2q6pcjml3i0fs3j":{"ops":[{"attributes":{"bold":"true"},"insert":"类别"},{"insert":"\n"}],"zoneId":"xr1lzjj9b0ev19m6nkkfv73ycj3jadnme7cxc1kul8eniqvi40z591q2q6pcjml3i0fs3j","zoneType":"Z"},"xr1lzjj9b0ev19m6nkkfv73ycj3jadnme7cxc13j1dgapnqywrrh86m8bkkmuemyascmgo":{"ops":[{"attributes":{"bold":"true"},"insert":"说明"},{"insert":"\n"}],"zoneId":"xr1lzjj9b0ev19m6nkkfv73ycj3jadnme7cxc13j1dgapnqywrrh86m8bkkmuemyascmgo","zoneType":"Z"},"xr16tl9w6e7gt7n3stqe62b8y8gkl0vuhzvxc1kul8eniqvi40z591q2q6pcjml3i0fs3j":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"文件格式\n"}],"zoneId":"xr16tl9w6e7gt7n3stqe62b8y8gkl0vuhzvxc1kul8eniqvi40z591q2q6pcjml3i0fs3j","zoneType":"Z"},"xr16tl9w6e7gt7n3stqe62b8y8gkl0vuhzvxc13j1dgapnqywrrh86m8bkkmuemyascmgo":{"ops":[{"insert":"wav、mp3、ogg、m4a、aac、pcm。其中 pcm 仅支持 24k 采样率，单通道。\n"}],"zoneId":"xr16tl9w6e7gt7n3stqe62b8y8gkl0vuhzvxc13j1dgapnqywrrh86m8bkkmuemyascmgo","zoneType":"Z"},"xr1o3p4cp0fafwpqrt9zn8gt9wh6bmvsw39xc1kul8eniqvi40z591q2q6pcjml3i0fs3j":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"文件大小\n"}],"zoneId":"xr1o3p4cp0fafwpqrt9zn8gt9wh6bmvsw39xc1kul8eniqvi40z591q2q6pcjml3i0fs3j","zoneType":"Z"},"xr1o3p4cp0fafwpqrt9zn8gt9wh6bmvsw39xc13j1dgapnqywrrh86m8bkkmuemyascmgo":{"ops":[{"insert":"最大不超过 10MB。每次最多上传1个音频文件。\n"}],"zoneId":"xr1o3p4cp0fafwpqrt9zn8gt9wh6bmvsw39xc13j1dgapnqywrrh86m8bkkmuemyascmgo","zoneType":"Z"},"xr1ywgtjnwqiqmfaodl9b54tel15uf2kswoxc1kul8eniqvi40z591q2q6pcjml3i0fs3j":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"音频时长\n"}],"zoneId":"xr1ywgtjnwqiqmfaodl9b54tel15uf2kswoxc1kul8eniqvi40z591q2q6pcjml3i0fs3j","zoneType":"Z"},"xr1ywgtjnwqiqmfaodl9b54tel15uf2kswoxc13j1dgapnqywrrh86m8bkkmuemyascmgo":{"ops":[{"insert":"建议 10s~30s。\n"}],"zoneId":"xr1ywgtjnwqiqmfaodl9b54tel15uf2kswoxc13j1dgapnqywrrh86m8bkkmuemyascmgo","zoneType":"Z"},"xr1ihgfdkog6gnfgfi2hino5ttzwhp6g02kxc1kul8eniqvi40z591q2q6pcjml3i0fs3j":{"ops":[{"insert":"语种\n"}],"zoneId":"xr1ihgfdkog6gnfgfi2hino5ttzwhp6g02kxc1kul8eniqvi40z591q2q6pcjml3i0fs3j","zoneType":"Z"},"xr1ihgfdkog6gnfgfi2hino5ttzwhp6g02kxc13j1dgapnqywrrh86m8bkkmuemyascmgo":{"ops":[{"insert":"支持中文、英文、日语、西班牙语、印度尼西亚语葡萄牙语。\n"}],"zoneId":"xr1ihgfdkog6gnfgfi2hino5ttzwhp6g02kxc13j1dgapnqywrrh86m8bkkmuemyascmgo","zoneType":"Z"},"xr1b69hh28jkf2abd31147si9hjsafionnixc1kul8eniqvi40z591q2q6pcjml3i0fs3j":{"ops":[{"insert":"文件录制\n"}],"zoneId":"xr1b69hh28jkf2abd31147si9hjsafionnixc1kul8eniqvi40z591q2q6pcjml3i0fs3j","zoneType":"Z"},"xr1b69hh28jkf2abd31147si9hjsafionnixc13j1dgapnqywrrh86m8bkkmuemyascmgo":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"录制环境：选择安静的空间，建议将麦克风放置在离说话人50厘米以内的位置，尽量保持自然的发声状态，避免刻意改变声线或呢喃，这样得到的音色会更加自然。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"音频质量：确保录音中只包含一个人的声音，说话人应保持清晰的发音和音质、稳定的音量和语速，保持姿态稳定。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"录制内容：避免说话时韵律过于平淡，尽量让语调、节奏和强度有所变化，尽量不要尝试复刻小孩或老人的声音。\n"}],"zoneId":"xr1b69hh28jkf2abd31147si9hjsafionnixc13j1dgapnqywrrh86m8bkkmuemyascmgo","zoneType":"Z"}}
        /// </summary>
        /// <param name="audio">
        /// 音频格式支持：wav、mp3、ogg、m4a、aac、pcm，其中pcm仅支持24k 单通道目前限制单文件上传最大10MB，每次最多上传1个音频文件
        /// </param>
        /// <param name="audioFormat">
        /// 传入文件的音频格式，例如 pcm, m4a, mp3
        /// </param>
        /// <param name="file">
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </param>
        /// <param name="filename">
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </param>
        /// <param name="language"></param>
        /// <param name="previewText">
        /// 如果传入会基于该文本生成预览音频，否则使用默认的文本"你好，我是你的专属AI克隆声音，希望未来可以一起好好相处哦"
        /// </param>
        /// <param name="spaceId">
        /// 克隆音色保存的空间，默认在个人空间
        /// </param>
        /// <param name="text">
        /// 可以让用户按照该文本念诵，服务会对比音频与该文本的差异。若差异过大会返回1109 WERError
        /// </param>
        /// <param name="voiceId">
        /// 如果有，则使用此 voice_id 进行训练覆盖，否则使用新的 voice_id 进行训练
        /// </param>
        /// <param name="voiceName">
        /// 音色名
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PublicCloneVoiceResponse> PublicCloneVoiceAsync(
            string audioFormat,
            byte[] file,
            string filename,
            string voiceName,
            global::G.PropertiesAudio? audio = default,
            string? language = default,
            string? previewText = default,
            string? spaceId = default,
            string? text = default,
            string? voiceId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PublicCloneVoiceRequest
            {
                Audio = audio,
                AudioFormat = audioFormat,
                File = file,
                Filename = filename,
                Language = language,
                PreviewText = previewText,
                SpaceId = spaceId,
                Text = text,
                VoiceId = voiceId,
                VoiceName = voiceName,
            };

            return await PublicCloneVoiceAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}