//HintName: G.Api.UploadFileOpen.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_UploadFileOpenSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_UploadFileOpenSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_UploadFileOpenSecurityRequirement0,
            };
        partial void PrepareUploadFileOpenArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UploadFileOpenRequest request);
        partial void PrepareUploadFileOpenRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UploadFileOpenRequest request);
        partial void ProcessUploadFileOpenResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadFileOpenResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 上传文件<br/>
        /// {"0":{"ops":[{"insert":"调用接口上传文件到扣子编程。\n"},{"attributes":{"anchor":"4a17eba2","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"消息中无法直接使用本地文件，创建消息或对话前，需要先调用此接口上传本地文件到扣子编程。上传文件后，你可以在消息中通过指定 file_id 的方式在多模态内容中直接使用此文件。此接口上传的文件可用于"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/chat_v3\",\"linkId\":\"sWhpYOLZKs\",\"newTab\":true}"},"insert":"发起对话"},{"insert":"等 API 中传入文件等多模态内容。使用方式可参考 "},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/chat_v3#426b92e7\",\"linkId\":\"HipDna9ICa\",\"newTab\":true}"},"insert":"object_string object"},{"insert":" 。\n"},{"attributes":{"anchor":"f4019a6b","heading":"h3","lmkr":"1"},"insert":"*"},{"insert":"使用限制\n"},{"attributes":{"aceTable":"rsectv8fn4uf3yq22j9qfggt72t64c9ayv cs1mq851aq0tpzkn8tqaibbi4qs7uuvnpe"},"insert":"*"},{"insert":"\n"},{"attributes":{"anchor":"e1ace7ce","lmkr":"1","heading":"h3"},"insert":"*"},{"insert":"支持的文件格式\n"},{"attributes":{"aceTable":"rs916q7d5ndps2oz5o1yvp2z8nqb9drfcq csbk97emfhmm7myb43qkolm0vkul3kw2sf"},"insert":"*"},{"insert":"\n"},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"rsectv8fn4uf3yq22j9qfggt72t64c9ayv":{"ops":[{"attributes":{"colWidth":"100"},"insert":{"id":"r1wy62r3stit94f89lzdvs2czz76744dlr"}},{"attributes":{"colWidth":"100"},"insert":{"id":"r1lckattw0m59vdv8dm7qhsm8jlm8m0spp"}},{"attributes":{},"insert":{"id":"r15fcffl38z9h3whp3covgncziqncikmtf"}},{"attributes":{},"insert":{"id":"r1zuusni9cfqi5yl4rrh7ncf3bm133wwws"}},{"attributes":{},"insert":{"id":"r1ruizo46r3q6ctlj4brqcqczn86fzcfq3"}},{"insert":{"id":"r1jitzwh43yc39m4dwcpehyvtym53qs3eo"}}],"zoneId":"rsectv8fn4uf3yq22j9qfggt72t64c9ayv","zoneType":"R"},"cs1mq851aq0tpzkn8tqaibbi4qs7uuvnpe":{"ops":[{"attributes":{"colWidth":"154"},"insert":{"id":"c1cvkrz7ke9jvut4bfyu0w9dilrow35u42"}},{"attributes":{"colWidth":"590"},"insert":{"id":"c1zg60rnu3iuith3fjn20zkb2133q063ej"}}],"zoneId":"cs1mq851aq0tpzkn8tqaibbi4qs7uuvnpe","zoneType":"C"},"xr1wy62r3stit94f89lzdvs2czz76744dlrxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42":{"ops":[{"attributes":{"bold":"true"},"insert":"限制"},{"insert":"\n"}],"zoneId":"xr1wy62r3stit94f89lzdvs2czz76744dlrxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42","zoneType":"Z"},"xr1wy62r3stit94f89lzdvs2czz76744dlrxc1zg60rnu3iuith3fjn20zkb2133q063ej":{"ops":[{"attributes":{"bold":"true"},"insert":"说明"},{"insert":"\n"}],"zoneId":"xr1wy62r3stit94f89lzdvs2czz76744dlrxc1zg60rnu3iuith3fjn20zkb2133q063ej","zoneType":"Z"},"xr1lckattw0m59vdv8dm7qhsm8jlm8m0sppxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"文件大小\n"}],"zoneId":"xr1lckattw0m59vdv8dm7qhsm8jlm8m0sppxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42","zoneType":"Z"},"xr1lckattw0m59vdv8dm7qhsm8jlm8m0sppxc1zg60rnu3iuith3fjn20zkb2133q063ej":{"ops":[{"attributes":{"lmkr":"1","align":"left"},"insert":"*"},{"insert":"该 API 允许上传的最大文件大小为 512 MB。然而，在与智能体对话时，实际可使用的文件大小取决于智能体的模型版本。\n"}],"zoneId":"xr1lckattw0m59vdv8dm7qhsm8jlm8m0sppxc1zg60rnu3iuith3fjn20zkb2133q063ej","zoneType":"Z"},"xr15fcffl38z9h3whp3covgncziqncikmtfxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42":{"ops":[{"insert":"上传方式\n"}],"zoneId":"xr15fcffl38z9h3whp3covgncziqncikmtfxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42","zoneType":"Z"},"xr15fcffl38z9h3whp3covgncziqncikmtfxc1zg60rnu3iuith3fjn20zkb2133q063ej":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"必须使用 multipart/form-data 方式上传文件。\n"}],"zoneId":"xr15fcffl38z9h3whp3covgncziqncikmtfxc1zg60rnu3iuith3fjn20zkb2133q063ej","zoneType":"Z"},"xr1zuusni9cfqi5yl4rrh7ncf3bm133wwwsxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42":{"ops":[{"insert":"有效期\n"}],"zoneId":"xr1zuusni9cfqi5yl4rrh7ncf3bm133wwwsxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42","zoneType":"Z"},"xr1zuusni9cfqi5yl4rrh7ncf3bm133wwwsxc1zg60rnu3iuith3fjn20zkb2133q063ej":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"普通上传的文件将保存在扣子编程服务端，有效期为 3 个月。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"若上传的文件被用作扣子头像，则永久有效。\n"}],"zoneId":"xr1zuusni9cfqi5yl4rrh7ncf3bm133wwwsxc1zg60rnu3iuith3fjn20zkb2133q063ej","zoneType":"Z"},"xr1ruizo46r3q6ctlj4brqcqczn86fzcfq3xc1cvkrz7ke9jvut4bfyu0w9dilrow35u42":{"ops":[{"insert":"使用限制\n"}],"zoneId":"xr1ruizo46r3q6ctlj4brqcqczn86fzcfq3xc1cvkrz7ke9jvut4bfyu0w9dilrow35u42","zoneType":"Z"},"xr1ruizo46r3q6ctlj4brqcqczn86fzcfq3xc1zg60rnu3iuith3fjn20zkb2133q063ej":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"上传到扣子编程的文件仅限本账号查看或使用。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"调用此接口上传文件只能获得文件的 "},{"attributes":{"bold":"true"},"insert":"file_id"},{"insert":"，如需获取文件的 URL，建议将文件上传到专业的存储工具中。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"不支持下载已上传的文件。用户仅可在对话、工作流、端插件、RTC 和 WebSocket 中通过 "},{"attributes":{"removeLink":"true","inlineCode":"true"},"insert":"file.id"},{"insert":" 访问和使用文件。\n"}],"zoneId":"xr1ruizo46r3q6ctlj4brqcqczn86fzcfq3xc1zg60rnu3iuith3fjn20zkb2133q063ej","zoneType":"Z"},"xr1jitzwh43yc39m4dwcpehyvtym53qs3eoxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42":{"ops":[{"insert":"API 流控\n"}],"zoneId":"xr1jitzwh43yc39m4dwcpehyvtym53qs3eoxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42","zoneType":"Z"},"xr1jitzwh43yc39m4dwcpehyvtym53qs3eoxc1zg60rnu3iuith3fjn20zkb2133q063ej":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"个人版：10 QPS。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"企业版：20 QPS。\n"}],"zoneId":"xr1jitzwh43yc39m4dwcpehyvtym53qs3eoxc1zg60rnu3iuith3fjn20zkb2133q063ej","zoneType":"Z"},"rs916q7d5ndps2oz5o1yvp2z8nqb9drfcq":{"ops":[{"attributes":{"colWidth":"100"},"insert":{"id":"r1jeopi8ejybsetlp8unfgs730otmnlfgt"}},{"attributes":{"colWidth":"100"},"insert":{"id":"r1r9icq9w1fr7gsk59rgem75vn3sur3tu3"}},{"attributes":{},"insert":{"id":"r1aqbcg692np4zprhwdhmjiuzjzhr8z54i"}},{"attributes":{},"insert":{"id":"r1tbjfo5hgm2lduto6cnm6uf4hmv08u2p8"}},{"attributes":{},"insert":{"id":"r13070mlmwoms1bgc5gq26lmeqnyfo7h0u"}},{"attributes":{},"insert":{"id":"r1tmo7qnsb8tzboi29cpebfe11ai7dufhd"}},{"attributes":{},"insert":{"id":"r15acnhsr31mdqo8v290j22n1c3bnnlznd"}}],"zoneId":"rs916q7d5ndps2oz5o1yvp2z8nqb9drfcq","zoneType":"R"},"csbk97emfhmm7myb43qkolm0vkul3kw2sf":{"ops":[{"attributes":{"colWidth":"130"},"insert":{"id":"c1gb2mqy8sve0p2uecg0516lj9bu45ll78"}},{"attributes":{"colWidth":"627"},"insert":{"id":"c12w9bw3p8u03o233ezvzh7oeichmqzkio"}}],"zoneId":"csbk97emfhmm7myb43qkolm0vkul3kw2sf","zoneType":"C"},"xr1jeopi8ejybsetlp8unfgs730otmnlfgtxc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"attributes":{"bold":"true"},"insert":"文件类型"},{"insert":"\n"}],"zoneId":"xr1jeopi8ejybsetlp8unfgs730otmnlfgtxc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr1jeopi8ejybsetlp8unfgs730otmnlfgtxc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"attributes":{"bold":"true"},"insert":"支持的格式"},{"insert":"\n"}],"zoneId":"xr1jeopi8ejybsetlp8unfgs730otmnlfgtxc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"},"xr1r9icq9w1fr7gsk59rgem75vn3sur3tu3xc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"文档\n"}],"zoneId":"xr1r9icq9w1fr7gsk59rgem75vn3sur3tu3xc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr1r9icq9w1fr7gsk59rgem75vn3sur3tu3xc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"insert":"DOC、DOCX、XLS、XLSX、PPT、PPTX、PDF、Numbers、CSV\n"}],"zoneId":"xr1r9icq9w1fr7gsk59rgem75vn3sur3tu3xc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"},"xr1aqbcg692np4zprhwdhmjiuzjzhr8z54ixc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"insert":"文本文件\n"}],"zoneId":"xr1aqbcg692np4zprhwdhmjiuzjzhr8z54ixc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr1aqbcg692np4zprhwdhmjiuzjzhr8z54ixc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"insert":"CPP、PY、JAVA、C \n"}],"zoneId":"xr1aqbcg692np4zprhwdhmjiuzjzhr8z54ixc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"},"xr1tbjfo5hgm2lduto6cnm6uf4hmv08u2p8xc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"图片\n"}],"zoneId":"xr1tbjfo5hgm2lduto6cnm6uf4hmv08u2p8xc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr1tbjfo5hgm2lduto6cnm6uf4hmv08u2p8xc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"insert":"JPG、JPG2、PNG、GIF、WEBP、HEIC、HEIF、BMP、PCD、TIFF\n"}],"zoneId":"xr1tbjfo5hgm2lduto6cnm6uf4hmv08u2p8xc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"},"xr13070mlmwoms1bgc5gq26lmeqnyfo7h0uxc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"音频\n"}],"zoneId":"xr13070mlmwoms1bgc5gq26lmeqnyfo7h0uxc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr13070mlmwoms1bgc5gq26lmeqnyfo7h0uxc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"insert":"WAV、MP3、FLAC、M4A、AAC、OGG、WMA、MIDI\n"}],"zoneId":"xr13070mlmwoms1bgc5gq26lmeqnyfo7h0uxc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"},"xr1tmo7qnsb8tzboi29cpebfe11ai7dufhdxc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"insert":"视频\n"}],"zoneId":"xr1tmo7qnsb8tzboi29cpebfe11ai7dufhdxc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr1tmo7qnsb8tzboi29cpebfe11ai7dufhdxc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"insert":"MP4、AVI、MOV、3GP、3GPP、FLV、WEBM、WMV、RMVB、M4V、MKV \n"}],"zoneId":"xr1tmo7qnsb8tzboi29cpebfe11ai7dufhdxc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"},"xr15acnhsr31mdqo8v290j22n1c3bnnlzndxc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"insert":"压缩文件\n"}],"zoneId":"xr15acnhsr31mdqo8v290j22n1c3bnnlzndxc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr15acnhsr31mdqo8v290j22n1c3bnnlzndxc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"insert":"RAR、ZIP、7Z、GZ、GZIP、BZ2\n"}],"zoneId":"xr15acnhsr31mdqo8v290j22n1c3bnnlzndxc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UploadFileOpenResponse> UploadFileOpenAsync(

            global::G.UploadFileOpenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadFileOpenArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UploadFileOpenSecurityRequirements,
                operationName: "UploadFileOpenAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/files/upload",
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
            PrepareUploadFileOpenRequest(
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
            ProcessUploadFileOpenResponse(
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
                ProcessUploadFileOpenResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.UploadFileOpenResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.UploadFileOpenResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 上传文件<br/>
        /// {"0":{"ops":[{"insert":"调用接口上传文件到扣子编程。\n"},{"attributes":{"anchor":"4a17eba2","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"消息中无法直接使用本地文件，创建消息或对话前，需要先调用此接口上传本地文件到扣子编程。上传文件后，你可以在消息中通过指定 file_id 的方式在多模态内容中直接使用此文件。此接口上传的文件可用于"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/chat_v3\",\"linkId\":\"sWhpYOLZKs\",\"newTab\":true}"},"insert":"发起对话"},{"insert":"等 API 中传入文件等多模态内容。使用方式可参考 "},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/chat_v3#426b92e7\",\"linkId\":\"HipDna9ICa\",\"newTab\":true}"},"insert":"object_string object"},{"insert":" 。\n"},{"attributes":{"anchor":"f4019a6b","heading":"h3","lmkr":"1"},"insert":"*"},{"insert":"使用限制\n"},{"attributes":{"aceTable":"rsectv8fn4uf3yq22j9qfggt72t64c9ayv cs1mq851aq0tpzkn8tqaibbi4qs7uuvnpe"},"insert":"*"},{"insert":"\n"},{"attributes":{"anchor":"e1ace7ce","lmkr":"1","heading":"h3"},"insert":"*"},{"insert":"支持的文件格式\n"},{"attributes":{"aceTable":"rs916q7d5ndps2oz5o1yvp2z8nqb9drfcq csbk97emfhmm7myb43qkolm0vkul3kw2sf"},"insert":"*"},{"insert":"\n"},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"rsectv8fn4uf3yq22j9qfggt72t64c9ayv":{"ops":[{"attributes":{"colWidth":"100"},"insert":{"id":"r1wy62r3stit94f89lzdvs2czz76744dlr"}},{"attributes":{"colWidth":"100"},"insert":{"id":"r1lckattw0m59vdv8dm7qhsm8jlm8m0spp"}},{"attributes":{},"insert":{"id":"r15fcffl38z9h3whp3covgncziqncikmtf"}},{"attributes":{},"insert":{"id":"r1zuusni9cfqi5yl4rrh7ncf3bm133wwws"}},{"attributes":{},"insert":{"id":"r1ruizo46r3q6ctlj4brqcqczn86fzcfq3"}},{"insert":{"id":"r1jitzwh43yc39m4dwcpehyvtym53qs3eo"}}],"zoneId":"rsectv8fn4uf3yq22j9qfggt72t64c9ayv","zoneType":"R"},"cs1mq851aq0tpzkn8tqaibbi4qs7uuvnpe":{"ops":[{"attributes":{"colWidth":"154"},"insert":{"id":"c1cvkrz7ke9jvut4bfyu0w9dilrow35u42"}},{"attributes":{"colWidth":"590"},"insert":{"id":"c1zg60rnu3iuith3fjn20zkb2133q063ej"}}],"zoneId":"cs1mq851aq0tpzkn8tqaibbi4qs7uuvnpe","zoneType":"C"},"xr1wy62r3stit94f89lzdvs2czz76744dlrxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42":{"ops":[{"attributes":{"bold":"true"},"insert":"限制"},{"insert":"\n"}],"zoneId":"xr1wy62r3stit94f89lzdvs2czz76744dlrxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42","zoneType":"Z"},"xr1wy62r3stit94f89lzdvs2czz76744dlrxc1zg60rnu3iuith3fjn20zkb2133q063ej":{"ops":[{"attributes":{"bold":"true"},"insert":"说明"},{"insert":"\n"}],"zoneId":"xr1wy62r3stit94f89lzdvs2czz76744dlrxc1zg60rnu3iuith3fjn20zkb2133q063ej","zoneType":"Z"},"xr1lckattw0m59vdv8dm7qhsm8jlm8m0sppxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"文件大小\n"}],"zoneId":"xr1lckattw0m59vdv8dm7qhsm8jlm8m0sppxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42","zoneType":"Z"},"xr1lckattw0m59vdv8dm7qhsm8jlm8m0sppxc1zg60rnu3iuith3fjn20zkb2133q063ej":{"ops":[{"attributes":{"lmkr":"1","align":"left"},"insert":"*"},{"insert":"该 API 允许上传的最大文件大小为 512 MB。然而，在与智能体对话时，实际可使用的文件大小取决于智能体的模型版本。\n"}],"zoneId":"xr1lckattw0m59vdv8dm7qhsm8jlm8m0sppxc1zg60rnu3iuith3fjn20zkb2133q063ej","zoneType":"Z"},"xr15fcffl38z9h3whp3covgncziqncikmtfxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42":{"ops":[{"insert":"上传方式\n"}],"zoneId":"xr15fcffl38z9h3whp3covgncziqncikmtfxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42","zoneType":"Z"},"xr15fcffl38z9h3whp3covgncziqncikmtfxc1zg60rnu3iuith3fjn20zkb2133q063ej":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"必须使用 multipart/form-data 方式上传文件。\n"}],"zoneId":"xr15fcffl38z9h3whp3covgncziqncikmtfxc1zg60rnu3iuith3fjn20zkb2133q063ej","zoneType":"Z"},"xr1zuusni9cfqi5yl4rrh7ncf3bm133wwwsxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42":{"ops":[{"insert":"有效期\n"}],"zoneId":"xr1zuusni9cfqi5yl4rrh7ncf3bm133wwwsxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42","zoneType":"Z"},"xr1zuusni9cfqi5yl4rrh7ncf3bm133wwwsxc1zg60rnu3iuith3fjn20zkb2133q063ej":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"普通上传的文件将保存在扣子编程服务端，有效期为 3 个月。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"若上传的文件被用作扣子头像，则永久有效。\n"}],"zoneId":"xr1zuusni9cfqi5yl4rrh7ncf3bm133wwwsxc1zg60rnu3iuith3fjn20zkb2133q063ej","zoneType":"Z"},"xr1ruizo46r3q6ctlj4brqcqczn86fzcfq3xc1cvkrz7ke9jvut4bfyu0w9dilrow35u42":{"ops":[{"insert":"使用限制\n"}],"zoneId":"xr1ruizo46r3q6ctlj4brqcqczn86fzcfq3xc1cvkrz7ke9jvut4bfyu0w9dilrow35u42","zoneType":"Z"},"xr1ruizo46r3q6ctlj4brqcqczn86fzcfq3xc1zg60rnu3iuith3fjn20zkb2133q063ej":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"上传到扣子编程的文件仅限本账号查看或使用。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"调用此接口上传文件只能获得文件的 "},{"attributes":{"bold":"true"},"insert":"file_id"},{"insert":"，如需获取文件的 URL，建议将文件上传到专业的存储工具中。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"不支持下载已上传的文件。用户仅可在对话、工作流、端插件、RTC 和 WebSocket 中通过 "},{"attributes":{"removeLink":"true","inlineCode":"true"},"insert":"file.id"},{"insert":" 访问和使用文件。\n"}],"zoneId":"xr1ruizo46r3q6ctlj4brqcqczn86fzcfq3xc1zg60rnu3iuith3fjn20zkb2133q063ej","zoneType":"Z"},"xr1jitzwh43yc39m4dwcpehyvtym53qs3eoxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42":{"ops":[{"insert":"API 流控\n"}],"zoneId":"xr1jitzwh43yc39m4dwcpehyvtym53qs3eoxc1cvkrz7ke9jvut4bfyu0w9dilrow35u42","zoneType":"Z"},"xr1jitzwh43yc39m4dwcpehyvtym53qs3eoxc1zg60rnu3iuith3fjn20zkb2133q063ej":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"个人版：10 QPS。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"企业版：20 QPS。\n"}],"zoneId":"xr1jitzwh43yc39m4dwcpehyvtym53qs3eoxc1zg60rnu3iuith3fjn20zkb2133q063ej","zoneType":"Z"},"rs916q7d5ndps2oz5o1yvp2z8nqb9drfcq":{"ops":[{"attributes":{"colWidth":"100"},"insert":{"id":"r1jeopi8ejybsetlp8unfgs730otmnlfgt"}},{"attributes":{"colWidth":"100"},"insert":{"id":"r1r9icq9w1fr7gsk59rgem75vn3sur3tu3"}},{"attributes":{},"insert":{"id":"r1aqbcg692np4zprhwdhmjiuzjzhr8z54i"}},{"attributes":{},"insert":{"id":"r1tbjfo5hgm2lduto6cnm6uf4hmv08u2p8"}},{"attributes":{},"insert":{"id":"r13070mlmwoms1bgc5gq26lmeqnyfo7h0u"}},{"attributes":{},"insert":{"id":"r1tmo7qnsb8tzboi29cpebfe11ai7dufhd"}},{"attributes":{},"insert":{"id":"r15acnhsr31mdqo8v290j22n1c3bnnlznd"}}],"zoneId":"rs916q7d5ndps2oz5o1yvp2z8nqb9drfcq","zoneType":"R"},"csbk97emfhmm7myb43qkolm0vkul3kw2sf":{"ops":[{"attributes":{"colWidth":"130"},"insert":{"id":"c1gb2mqy8sve0p2uecg0516lj9bu45ll78"}},{"attributes":{"colWidth":"627"},"insert":{"id":"c12w9bw3p8u03o233ezvzh7oeichmqzkio"}}],"zoneId":"csbk97emfhmm7myb43qkolm0vkul3kw2sf","zoneType":"C"},"xr1jeopi8ejybsetlp8unfgs730otmnlfgtxc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"attributes":{"bold":"true"},"insert":"文件类型"},{"insert":"\n"}],"zoneId":"xr1jeopi8ejybsetlp8unfgs730otmnlfgtxc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr1jeopi8ejybsetlp8unfgs730otmnlfgtxc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"attributes":{"bold":"true"},"insert":"支持的格式"},{"insert":"\n"}],"zoneId":"xr1jeopi8ejybsetlp8unfgs730otmnlfgtxc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"},"xr1r9icq9w1fr7gsk59rgem75vn3sur3tu3xc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"文档\n"}],"zoneId":"xr1r9icq9w1fr7gsk59rgem75vn3sur3tu3xc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr1r9icq9w1fr7gsk59rgem75vn3sur3tu3xc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"insert":"DOC、DOCX、XLS、XLSX、PPT、PPTX、PDF、Numbers、CSV\n"}],"zoneId":"xr1r9icq9w1fr7gsk59rgem75vn3sur3tu3xc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"},"xr1aqbcg692np4zprhwdhmjiuzjzhr8z54ixc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"insert":"文本文件\n"}],"zoneId":"xr1aqbcg692np4zprhwdhmjiuzjzhr8z54ixc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr1aqbcg692np4zprhwdhmjiuzjzhr8z54ixc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"insert":"CPP、PY、JAVA、C \n"}],"zoneId":"xr1aqbcg692np4zprhwdhmjiuzjzhr8z54ixc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"},"xr1tbjfo5hgm2lduto6cnm6uf4hmv08u2p8xc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"图片\n"}],"zoneId":"xr1tbjfo5hgm2lduto6cnm6uf4hmv08u2p8xc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr1tbjfo5hgm2lduto6cnm6uf4hmv08u2p8xc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"insert":"JPG、JPG2、PNG、GIF、WEBP、HEIC、HEIF、BMP、PCD、TIFF\n"}],"zoneId":"xr1tbjfo5hgm2lduto6cnm6uf4hmv08u2p8xc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"},"xr13070mlmwoms1bgc5gq26lmeqnyfo7h0uxc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"音频\n"}],"zoneId":"xr13070mlmwoms1bgc5gq26lmeqnyfo7h0uxc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr13070mlmwoms1bgc5gq26lmeqnyfo7h0uxc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"insert":"WAV、MP3、FLAC、M4A、AAC、OGG、WMA、MIDI\n"}],"zoneId":"xr13070mlmwoms1bgc5gq26lmeqnyfo7h0uxc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"},"xr1tmo7qnsb8tzboi29cpebfe11ai7dufhdxc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"insert":"视频\n"}],"zoneId":"xr1tmo7qnsb8tzboi29cpebfe11ai7dufhdxc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr1tmo7qnsb8tzboi29cpebfe11ai7dufhdxc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"insert":"MP4、AVI、MOV、3GP、3GPP、FLV、WEBM、WMV、RMVB、M4V、MKV \n"}],"zoneId":"xr1tmo7qnsb8tzboi29cpebfe11ai7dufhdxc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"},"xr15acnhsr31mdqo8v290j22n1c3bnnlzndxc1gb2mqy8sve0p2uecg0516lj9bu45ll78":{"ops":[{"insert":"压缩文件\n"}],"zoneId":"xr15acnhsr31mdqo8v290j22n1c3bnnlzndxc1gb2mqy8sve0p2uecg0516lj9bu45ll78","zoneType":"Z"},"xr15acnhsr31mdqo8v290j22n1c3bnnlzndxc12w9bw3p8u03o233ezvzh7oeichmqzkio":{"ops":[{"insert":"RAR、ZIP、7Z、GZ、GZIP、BZ2\n"}],"zoneId":"xr15acnhsr31mdqo8v290j22n1c3bnnlzndxc12w9bw3p8u03o233ezvzh7oeichmqzkio","zoneType":"Z"}}
        /// </summary>
        /// <param name="file">
        /// 需要上传的文件<br/>
        /// 支持上传的文件格式：文档：DOC、DOCX、XLS、XLSX、PPT、PPTX、PDF、Numbers、CSV<br/>
        /// 图片：JPG、JPG2、PNG、GIF、WEBP、HEIC、HEIF、BMP、PCD、TIFF<br/>
        /// 音频：WAV、MP3、FLAC、M4A、AAC、OGG、WMA、MIDI<br/>
        /// 视频：MP4、AVI、MOV、3GP、3GPP、FLV、WEBM、WMV、RMVB、M4V、MKV<br/>
        /// 文本文件：CPP、PY、JAVA、C<br/>
        /// 压缩包：RAR、ZIP、7Z、GZ、GZIP、BZ2<br/>
        /// 文件上传大小限制：每个文件最大 512 MB。<br/>
        /// 上传到扣子的文件仅限本账号查看或使用。<br/>
        /// 通过此接口上传的文件有效期为 3 个月。
        /// </param>
        /// <param name="filename">
        /// 需要上传的文件<br/>
        /// 支持上传的文件格式：文档：DOC、DOCX、XLS、XLSX、PPT、PPTX、PDF、Numbers、CSV<br/>
        /// 图片：JPG、JPG2、PNG、GIF、WEBP、HEIC、HEIF、BMP、PCD、TIFF<br/>
        /// 音频：WAV、MP3、FLAC、M4A、AAC、OGG、WMA、MIDI<br/>
        /// 视频：MP4、AVI、MOV、3GP、3GPP、FLV、WEBM、WMV、RMVB、M4V、MKV<br/>
        /// 文本文件：CPP、PY、JAVA、C<br/>
        /// 压缩包：RAR、ZIP、7Z、GZ、GZIP、BZ2<br/>
        /// 文件上传大小限制：每个文件最大 512 MB。<br/>
        /// 上传到扣子的文件仅限本账号查看或使用。<br/>
        /// 通过此接口上传的文件有效期为 3 个月。
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UploadFileOpenResponse> UploadFileOpenAsync(
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.UploadFileOpenRequest
            {
                File = file,
                Filename = filename,
            };

            return await UploadFileOpenAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}