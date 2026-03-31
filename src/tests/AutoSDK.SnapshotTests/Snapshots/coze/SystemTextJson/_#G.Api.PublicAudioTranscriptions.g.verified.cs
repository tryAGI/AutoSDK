//HintName: G.Api.PublicAudioTranscriptions.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PreparePublicAudioTranscriptionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PublicAudioTranscriptionsRequest request);
        partial void PreparePublicAudioTranscriptionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PublicAudioTranscriptionsRequest request);
        partial void ProcessPublicAudioTranscriptionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPublicAudioTranscriptionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 语音识别<br/>
        /// {"0":{"ops":[{"insert":"将音频文件转录为文本。\n"},{"attributes":{"anchor":"be23719f","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此 API 用于将指定音频文件转录为文本。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"x4xWyDX0dW","zoneType":"Z","type":"warning","title":"注意","border":"#fed4a4","background":"#fff5eb","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"语音文件的具体限制如下：\n"},{"attributes":{"aceTable":"rsaz3aujktbark4q0n5mcl19it13pjr5nd cstwhi7s9g55zzhf3dkmsu3llge1jpfmdh"},"insert":"*"},{"insert":"\n"},{"attributes":{"zoneId":"xMnnYIBhOG","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"x4xWyDX0dW":{"ops":[{"insert":"调用语音识别 API 会产生"},{"attributes":{"bold":"true"},"insert":"语音识别费用"},{"insert":"，具体费用详情请参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/coze_pro/asr_tts_fee#d4ab71d9\",\"linkId\":\"XgGO5Oid8O\",\"newTab\":true}"},"insert":"音视频费用"},{"insert":"。\n"}],"zoneId":"x4xWyDX0dW","zoneType":"Z"},"rsaz3aujktbark4q0n5mcl19it13pjr5nd":{"ops":[{"attributes":{"colWidth":"100"},"insert":{"id":"r1gv0diy056deo5u873mcy1ewpju9gkmvn"}},{"attributes":{"rowHeight":"41","colWidth":"100"},"insert":{"id":"r1ivmnay4ygvf86q92qsgzajlt0kp1ur85"}},{"attributes":{"colWidth":"100","rowHeight":"40"},"insert":{"id":"r1eaudhza0s7t3oe0tsopelm9n5mq66vcm"}}],"zoneId":"rsaz3aujktbark4q0n5mcl19it13pjr5nd","zoneType":"R"},"cstwhi7s9g55zzhf3dkmsu3llge1jpfmdh":{"ops":[{"attributes":{"colWidth":"151"},"insert":{"id":"c1m1wojhwkam09ehofvmdy4pg0lcbhnzob"}},{"attributes":{"colWidth":"752"},"insert":{"id":"c10lug6nb45li27qbvjdu2fq20u107pde0"}}],"zoneId":"cstwhi7s9g55zzhf3dkmsu3llge1jpfmdh","zoneType":"C"},"xr1gv0diy056deo5u873mcy1ewpju9gkmvnxc1m1wojhwkam09ehofvmdy4pg0lcbhnzob":{"ops":[{"attributes":{"bold":"true"},"insert":"限制"},{"insert":"\n"}],"zoneId":"xr1gv0diy056deo5u873mcy1ewpju9gkmvnxc1m1wojhwkam09ehofvmdy4pg0lcbhnzob","zoneType":"Z"},"xr1gv0diy056deo5u873mcy1ewpju9gkmvnxc10lug6nb45li27qbvjdu2fq20u107pde0":{"ops":[{"attributes":{"bold":"true"},"insert":"说明"},{"insert":"\n"}],"zoneId":"xr1gv0diy056deo5u873mcy1ewpju9gkmvnxc10lug6nb45li27qbvjdu2fq20u107pde0","zoneType":"Z"},"xr1ivmnay4ygvf86q92qsgzajlt0kp1ur85xc1m1wojhwkam09ehofvmdy4pg0lcbhnzob":{"ops":[{"insert":"文件格式\n"}],"zoneId":"xr1ivmnay4ygvf86q92qsgzajlt0kp1ur85xc1m1wojhwkam09ehofvmdy4pg0lcbhnzob","zoneType":"Z"},"xr1ivmnay4ygvf86q92qsgzajlt0kp1ur85xc10lug6nb45li27qbvjdu2fq20u107pde0":{"ops":[{"insert":"支持的文件格式包括 ogg、mp3 和 wav。\n"}],"zoneId":"xr1ivmnay4ygvf86q92qsgzajlt0kp1ur85xc10lug6nb45li27qbvjdu2fq20u107pde0","zoneType":"Z"},"xr1eaudhza0s7t3oe0tsopelm9n5mq66vcmxc1m1wojhwkam09ehofvmdy4pg0lcbhnzob":{"ops":[{"insert":"文件大小\n"}],"zoneId":"xr1eaudhza0s7t3oe0tsopelm9n5mq66vcmxc1m1wojhwkam09ehofvmdy4pg0lcbhnzob","zoneType":"Z"},"xr1eaudhza0s7t3oe0tsopelm9n5mq66vcmxc10lug6nb45li27qbvjdu2fq20u107pde0":{"ops":[{"insert":"每个音频文件最大为 10 MB，并且时长需小于 30 分钟。\n"}],"zoneId":"xr1eaudhza0s7t3oe0tsopelm9n5mq66vcmxc10lug6nb45li27qbvjdu2fq20u107pde0","zoneType":"Z"},"xMnnYIBhOG":{"ops":[{"insert":"*","attributes":{"list":"bullet1","lmkr":"1"}},{"insert":"上传的音频文件的采样率和码率等参数无限制。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"如果语音文件过大，建议调用 WebSocket 的"},{"insert":"双向流式语音识别 API","attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/asr_api\",\"linkId\":\"CRfi4OuzbE\"}"}},{"insert":" 分片上传文件。\n"}],"zoneId":"xMnnYIBhOG","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PublicAudioTranscriptionsResponse> PublicAudioTranscriptionsAsync(

            global::G.PublicAudioTranscriptionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePublicAudioTranscriptionsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/audio/transcriptions",
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentFile,
                name: "\"file\"",
                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
            if (__contentFile.Headers.ContentDisposition != null)
            {
                __contentFile.Headers.ContentDisposition.FileNameStar = null;
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePublicAudioTranscriptionsRequest(
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
            ProcessPublicAudioTranscriptionsResponse(
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
                ProcessPublicAudioTranscriptionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PublicAudioTranscriptionsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PublicAudioTranscriptionsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 语音识别<br/>
        /// {"0":{"ops":[{"insert":"将音频文件转录为文本。\n"},{"attributes":{"anchor":"be23719f","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此 API 用于将指定音频文件转录为文本。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"x4xWyDX0dW","zoneType":"Z","type":"warning","title":"注意","border":"#fed4a4","background":"#fff5eb","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"语音文件的具体限制如下：\n"},{"attributes":{"aceTable":"rsaz3aujktbark4q0n5mcl19it13pjr5nd cstwhi7s9g55zzhf3dkmsu3llge1jpfmdh"},"insert":"*"},{"insert":"\n"},{"attributes":{"zoneId":"xMnnYIBhOG","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"x4xWyDX0dW":{"ops":[{"insert":"调用语音识别 API 会产生"},{"attributes":{"bold":"true"},"insert":"语音识别费用"},{"insert":"，具体费用详情请参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/coze_pro/asr_tts_fee#d4ab71d9\",\"linkId\":\"XgGO5Oid8O\",\"newTab\":true}"},"insert":"音视频费用"},{"insert":"。\n"}],"zoneId":"x4xWyDX0dW","zoneType":"Z"},"rsaz3aujktbark4q0n5mcl19it13pjr5nd":{"ops":[{"attributes":{"colWidth":"100"},"insert":{"id":"r1gv0diy056deo5u873mcy1ewpju9gkmvn"}},{"attributes":{"rowHeight":"41","colWidth":"100"},"insert":{"id":"r1ivmnay4ygvf86q92qsgzajlt0kp1ur85"}},{"attributes":{"colWidth":"100","rowHeight":"40"},"insert":{"id":"r1eaudhza0s7t3oe0tsopelm9n5mq66vcm"}}],"zoneId":"rsaz3aujktbark4q0n5mcl19it13pjr5nd","zoneType":"R"},"cstwhi7s9g55zzhf3dkmsu3llge1jpfmdh":{"ops":[{"attributes":{"colWidth":"151"},"insert":{"id":"c1m1wojhwkam09ehofvmdy4pg0lcbhnzob"}},{"attributes":{"colWidth":"752"},"insert":{"id":"c10lug6nb45li27qbvjdu2fq20u107pde0"}}],"zoneId":"cstwhi7s9g55zzhf3dkmsu3llge1jpfmdh","zoneType":"C"},"xr1gv0diy056deo5u873mcy1ewpju9gkmvnxc1m1wojhwkam09ehofvmdy4pg0lcbhnzob":{"ops":[{"attributes":{"bold":"true"},"insert":"限制"},{"insert":"\n"}],"zoneId":"xr1gv0diy056deo5u873mcy1ewpju9gkmvnxc1m1wojhwkam09ehofvmdy4pg0lcbhnzob","zoneType":"Z"},"xr1gv0diy056deo5u873mcy1ewpju9gkmvnxc10lug6nb45li27qbvjdu2fq20u107pde0":{"ops":[{"attributes":{"bold":"true"},"insert":"说明"},{"insert":"\n"}],"zoneId":"xr1gv0diy056deo5u873mcy1ewpju9gkmvnxc10lug6nb45li27qbvjdu2fq20u107pde0","zoneType":"Z"},"xr1ivmnay4ygvf86q92qsgzajlt0kp1ur85xc1m1wojhwkam09ehofvmdy4pg0lcbhnzob":{"ops":[{"insert":"文件格式\n"}],"zoneId":"xr1ivmnay4ygvf86q92qsgzajlt0kp1ur85xc1m1wojhwkam09ehofvmdy4pg0lcbhnzob","zoneType":"Z"},"xr1ivmnay4ygvf86q92qsgzajlt0kp1ur85xc10lug6nb45li27qbvjdu2fq20u107pde0":{"ops":[{"insert":"支持的文件格式包括 ogg、mp3 和 wav。\n"}],"zoneId":"xr1ivmnay4ygvf86q92qsgzajlt0kp1ur85xc10lug6nb45li27qbvjdu2fq20u107pde0","zoneType":"Z"},"xr1eaudhza0s7t3oe0tsopelm9n5mq66vcmxc1m1wojhwkam09ehofvmdy4pg0lcbhnzob":{"ops":[{"insert":"文件大小\n"}],"zoneId":"xr1eaudhza0s7t3oe0tsopelm9n5mq66vcmxc1m1wojhwkam09ehofvmdy4pg0lcbhnzob","zoneType":"Z"},"xr1eaudhza0s7t3oe0tsopelm9n5mq66vcmxc10lug6nb45li27qbvjdu2fq20u107pde0":{"ops":[{"insert":"每个音频文件最大为 10 MB，并且时长需小于 30 分钟。\n"}],"zoneId":"xr1eaudhza0s7t3oe0tsopelm9n5mq66vcmxc10lug6nb45li27qbvjdu2fq20u107pde0","zoneType":"Z"},"xMnnYIBhOG":{"ops":[{"insert":"*","attributes":{"list":"bullet1","lmkr":"1"}},{"insert":"上传的音频文件的采样率和码率等参数无限制。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"如果语音文件过大，建议调用 WebSocket 的"},{"insert":"双向流式语音识别 API","attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/asr_api\",\"linkId\":\"CRfi4OuzbE\"}"}},{"insert":" 分片上传文件。\n"}],"zoneId":"xMnnYIBhOG","zoneType":"Z"}}
        /// </summary>
        /// <param name="file">
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </param>
        /// <param name="filename">
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PublicAudioTranscriptionsResponse> PublicAudioTranscriptionsAsync(
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.PublicAudioTranscriptionsRequest
            {
                File = file,
                Filename = filename,
            };

            return await PublicAudioTranscriptionsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}