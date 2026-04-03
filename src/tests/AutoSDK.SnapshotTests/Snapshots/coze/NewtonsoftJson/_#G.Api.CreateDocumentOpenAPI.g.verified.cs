//HintName: G.Api.CreateDocumentOpenAPI.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCreateDocumentOpenAPIArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.CreateDocumentOpenAPIAgwJsConv agwJsConv,
            global::G.CreateDocumentOpenAPIRequest request);
        partial void PrepareCreateDocumentOpenAPIRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateDocumentOpenAPIAgwJsConv agwJsConv,
            global::G.CreateDocumentOpenAPIRequest request);
        partial void ProcessCreateDocumentOpenAPIResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateDocumentOpenAPIResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 创建知识库文件<br/>
        /// {"0":{"ops":[{"insert":"调用此 API 向指定的扣子知识库上传文件。\n"},{"attributes":{"anchor":"98341a4b","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"通过此 API，你可以向文本或图片知识库中上传文件。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"本 API 仅适用于扣子知识库的文件上传操作，不适用于火山知识库上传文件。火山知识库上传文件请参见"},{"attributes":{"hyperlink":"{\"href\":\"https://www.volcengine.com/docs/84313/1254624\",\"linkId\":\"nwIG0qd6lI\",\"newTab\":true}"},"insert":"火山知识库上传文件"},{"insert":"。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"上传图片到图片知识库时，可以通过 "},{"attributes":{"inlineCode":"true"},"insert":"caption_type"},{"insert":" 参数设置系统标注或手动标注，如果选择手动标注，还需要调用 "},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/update_image_caption\",\"linkId\":\"9Ojvpm5hi4\",\"newTab\":true}"},"insert":"更新知识库图片描述"},{"insert":" API 手动设置标注。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"支持的上传方式如下：\n"},{"attributes":{"aceTable":"rsd6pf4e7jlkkueamsg0chhrkfh0zw61ct csm4bl1h543fs3ryuzg34hqvffm53wo9t9"},"insert":"*"},{"insert":"\n"},{"attributes":{"anchor":"bb27a01d","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"注意事项\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"每次最多可上传 10 个文件。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"必须上传和知识库类型匹配的文件，例如 txt 等文档类型的文件只能上传到文档知识库中，不可上传到表格知识库中。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"每个请求只能选择一种上传方式，不支持同时上传在线网页和本地文档。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"仅知识库的所有者可以向知识库中上传文件。\n"}],"zoneId":"0","zoneType":"Z"},"rsd6pf4e7jlkkueamsg0chhrkfh0zw61ct":{"ops":[{"attributes":{"rowHeight":"41","colWidth":"100"},"insert":{"id":"r1helnjg5ek6ynpvfw4bf7s8sb35f3lq95"}},{"attributes":{"colWidth":"100"},"insert":{"id":"r195snj5ys7r4vvhjk9ek5iyojb4yuuhmn"}},{"insert":{"id":"r11sgc7qsefsh0ggohc2e1ycjy166iy47a"}},{"insert":{"id":"r17vnaj3nbkh0wohs7ry98y6psjfjzeoiw"}}],"zoneId":"rsd6pf4e7jlkkueamsg0chhrkfh0zw61ct","zoneType":"R"},"csm4bl1h543fs3ryuzg34hqvffm53wo9t9":{"ops":[{"attributes":{"colWidth":"198"},"insert":{"id":"c1ggle7q1kc516kdso15r2l0um5inia397"}},{"attributes":{"colWidth":"224"},"insert":{"id":"c10dwdgufunpaigjtn587mu134w8mw228y"}},{"attributes":{"colWidth":"232"},"insert":{"id":"c16l59p6ekstr1h83yfn5qyeyphqtohi94"}}],"zoneId":"csm4bl1h543fs3ryuzg34hqvffm53wo9t9","zoneType":"C"},"xr1helnjg5ek6ynpvfw4bf7s8sb35f3lq95xc1ggle7q1kc516kdso15r2l0um5inia397":{"ops":[{"attributes":{"bold":"true"},"insert":"上传方式"},{"insert":"\n"}],"zoneId":"xr1helnjg5ek6ynpvfw4bf7s8sb35f3lq95xc1ggle7q1kc516kdso15r2l0um5inia397","zoneType":"Z"},"xr1helnjg5ek6ynpvfw4bf7s8sb35f3lq95xc10dwdgufunpaigjtn587mu134w8mw228y":{"ops":[{"attributes":{"bold":"true"},"insert":"文本知识库"},{"insert":"\n"}],"zoneId":"xr1helnjg5ek6ynpvfw4bf7s8sb35f3lq95xc10dwdgufunpaigjtn587mu134w8mw228y","zoneType":"Z"},"xr1helnjg5ek6ynpvfw4bf7s8sb35f3lq95xc16l59p6ekstr1h83yfn5qyeyphqtohi94":{"ops":[{"attributes":{"bold":"true"},"insert":"图片知识库"},{"insert":"\n"}],"zoneId":"xr1helnjg5ek6ynpvfw4bf7s8sb35f3lq95xc16l59p6ekstr1h83yfn5qyeyphqtohi94","zoneType":"Z"},"xr195snj5ys7r4vvhjk9ek5iyojb4yuuhmnxc1ggle7q1kc516kdso15r2l0um5inia397":{"ops":[{"insert":"通过 Base 64 上传本地文件\n"}],"zoneId":"xr195snj5ys7r4vvhjk9ek5iyojb4yuuhmnxc1ggle7q1kc516kdso15r2l0um5inia397","zoneType":"Z"},"xr195snj5ys7r4vvhjk9ek5iyojb4yuuhmnxc10dwdgufunpaigjtn587mu134w8mw228y":{"ops":[{"insert":"✅\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"格式支持 pdf、txt、doc、docx 类型。\n"}],"zoneId":"xr195snj5ys7r4vvhjk9ek5iyojb4yuuhmnxc10dwdgufunpaigjtn587mu134w8mw228y","zoneType":"Z"},"xr195snj5ys7r4vvhjk9ek5iyojb4yuuhmnxc16l59p6ekstr1h83yfn5qyeyphqtohi94":{"ops":[{"insert":"❌\n"}],"zoneId":"xr195snj5ys7r4vvhjk9ek5iyojb4yuuhmnxc16l59p6ekstr1h83yfn5qyeyphqtohi94","zoneType":"Z"},"xr11sgc7qsefsh0ggohc2e1ycjy166iy47axc1ggle7q1kc516kdso15r2l0um5inia397":{"ops":[{"insert":"上传在线网页\n"}],"zoneId":"xr11sgc7qsefsh0ggohc2e1ycjy166iy47axc1ggle7q1kc516kdso15r2l0um5inia397","zoneType":"Z"},"xr11sgc7qsefsh0ggohc2e1ycjy166iy47axc10dwdgufunpaigjtn587mu134w8mw228y":{"ops":[{"insert":"✅\n"}],"zoneId":"xr11sgc7qsefsh0ggohc2e1ycjy166iy47axc10dwdgufunpaigjtn587mu134w8mw228y","zoneType":"Z"},"xr11sgc7qsefsh0ggohc2e1ycjy166iy47axc16l59p6ekstr1h83yfn5qyeyphqtohi94":{"ops":[{"insert":"❌\n"}],"zoneId":"xr11sgc7qsefsh0ggohc2e1ycjy166iy47axc16l59p6ekstr1h83yfn5qyeyphqtohi94","zoneType":"Z"},"xr17vnaj3nbkh0wohs7ry98y6psjfjzeoiwxc1ggle7q1kc516kdso15r2l0um5inia397":{"ops":[{"insert":"通过 "},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/upload_files\",\"linkId\":\"i84iZctMyc\",\"newTab\":true}"},"insert":"上传文件"},{"insert":" 上传\n"}],"zoneId":"xr17vnaj3nbkh0wohs7ry98y6psjfjzeoiwxc1ggle7q1kc516kdso15r2l0um5inia397","zoneType":"Z"},"xr17vnaj3nbkh0wohs7ry98y6psjfjzeoiwxc10dwdgufunpaigjtn587mu134w8mw228y":{"ops":[{"insert":"❌\n"}],"zoneId":"xr17vnaj3nbkh0wohs7ry98y6psjfjzeoiwxc10dwdgufunpaigjtn587mu134w8mw228y","zoneType":"Z"},"xr17vnaj3nbkh0wohs7ry98y6psjfjzeoiwxc16l59p6ekstr1h83yfn5qyeyphqtohi94":{"ops":[{"insert":"✅\n"}],"zoneId":"xr17vnaj3nbkh0wohs7ry98y6psjfjzeoiwxc16l59p6ekstr1h83yfn5qyeyphqtohi94","zoneType":"Z"}}
        /// </summary>
        /// <param name="agwJsConv"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateDocumentOpenAPIResponse> CreateDocumentOpenAPIAsync(
            global::G.CreateDocumentOpenAPIAgwJsConv agwJsConv,

            global::G.CreateDocumentOpenAPIRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateDocumentOpenAPIArguments(
                httpClient: HttpClient,
                agwJsConv: ref agwJsConv,
                request: request);

            var agwJsConvValue = agwJsConv switch
            {
                global::G.CreateDocumentOpenAPIAgwJsConv.Str => "str",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/open_api/knowledge/document/create",
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

            __httpRequest.Headers.TryAddWithoutValidation("Agw-Js-Conv", agwJsConv.ToValueString());

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateDocumentOpenAPIRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agwJsConv: agwJsConv,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateDocumentOpenAPIResponse(
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
                ProcessCreateDocumentOpenAPIResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateDocumentOpenAPIResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateDocumentOpenAPIResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 创建知识库文件<br/>
        /// {"0":{"ops":[{"insert":"调用此 API 向指定的扣子知识库上传文件。\n"},{"attributes":{"anchor":"98341a4b","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"通过此 API，你可以向文本或图片知识库中上传文件。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"本 API 仅适用于扣子知识库的文件上传操作，不适用于火山知识库上传文件。火山知识库上传文件请参见"},{"attributes":{"hyperlink":"{\"href\":\"https://www.volcengine.com/docs/84313/1254624\",\"linkId\":\"nwIG0qd6lI\",\"newTab\":true}"},"insert":"火山知识库上传文件"},{"insert":"。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"上传图片到图片知识库时，可以通过 "},{"attributes":{"inlineCode":"true"},"insert":"caption_type"},{"insert":" 参数设置系统标注或手动标注，如果选择手动标注，还需要调用 "},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/update_image_caption\",\"linkId\":\"9Ojvpm5hi4\",\"newTab\":true}"},"insert":"更新知识库图片描述"},{"insert":" API 手动设置标注。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"支持的上传方式如下：\n"},{"attributes":{"aceTable":"rsd6pf4e7jlkkueamsg0chhrkfh0zw61ct csm4bl1h543fs3ryuzg34hqvffm53wo9t9"},"insert":"*"},{"insert":"\n"},{"attributes":{"anchor":"bb27a01d","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"注意事项\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"每次最多可上传 10 个文件。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"必须上传和知识库类型匹配的文件，例如 txt 等文档类型的文件只能上传到文档知识库中，不可上传到表格知识库中。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"每个请求只能选择一种上传方式，不支持同时上传在线网页和本地文档。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"仅知识库的所有者可以向知识库中上传文件。\n"}],"zoneId":"0","zoneType":"Z"},"rsd6pf4e7jlkkueamsg0chhrkfh0zw61ct":{"ops":[{"attributes":{"rowHeight":"41","colWidth":"100"},"insert":{"id":"r1helnjg5ek6ynpvfw4bf7s8sb35f3lq95"}},{"attributes":{"colWidth":"100"},"insert":{"id":"r195snj5ys7r4vvhjk9ek5iyojb4yuuhmn"}},{"insert":{"id":"r11sgc7qsefsh0ggohc2e1ycjy166iy47a"}},{"insert":{"id":"r17vnaj3nbkh0wohs7ry98y6psjfjzeoiw"}}],"zoneId":"rsd6pf4e7jlkkueamsg0chhrkfh0zw61ct","zoneType":"R"},"csm4bl1h543fs3ryuzg34hqvffm53wo9t9":{"ops":[{"attributes":{"colWidth":"198"},"insert":{"id":"c1ggle7q1kc516kdso15r2l0um5inia397"}},{"attributes":{"colWidth":"224"},"insert":{"id":"c10dwdgufunpaigjtn587mu134w8mw228y"}},{"attributes":{"colWidth":"232"},"insert":{"id":"c16l59p6ekstr1h83yfn5qyeyphqtohi94"}}],"zoneId":"csm4bl1h543fs3ryuzg34hqvffm53wo9t9","zoneType":"C"},"xr1helnjg5ek6ynpvfw4bf7s8sb35f3lq95xc1ggle7q1kc516kdso15r2l0um5inia397":{"ops":[{"attributes":{"bold":"true"},"insert":"上传方式"},{"insert":"\n"}],"zoneId":"xr1helnjg5ek6ynpvfw4bf7s8sb35f3lq95xc1ggle7q1kc516kdso15r2l0um5inia397","zoneType":"Z"},"xr1helnjg5ek6ynpvfw4bf7s8sb35f3lq95xc10dwdgufunpaigjtn587mu134w8mw228y":{"ops":[{"attributes":{"bold":"true"},"insert":"文本知识库"},{"insert":"\n"}],"zoneId":"xr1helnjg5ek6ynpvfw4bf7s8sb35f3lq95xc10dwdgufunpaigjtn587mu134w8mw228y","zoneType":"Z"},"xr1helnjg5ek6ynpvfw4bf7s8sb35f3lq95xc16l59p6ekstr1h83yfn5qyeyphqtohi94":{"ops":[{"attributes":{"bold":"true"},"insert":"图片知识库"},{"insert":"\n"}],"zoneId":"xr1helnjg5ek6ynpvfw4bf7s8sb35f3lq95xc16l59p6ekstr1h83yfn5qyeyphqtohi94","zoneType":"Z"},"xr195snj5ys7r4vvhjk9ek5iyojb4yuuhmnxc1ggle7q1kc516kdso15r2l0um5inia397":{"ops":[{"insert":"通过 Base 64 上传本地文件\n"}],"zoneId":"xr195snj5ys7r4vvhjk9ek5iyojb4yuuhmnxc1ggle7q1kc516kdso15r2l0um5inia397","zoneType":"Z"},"xr195snj5ys7r4vvhjk9ek5iyojb4yuuhmnxc10dwdgufunpaigjtn587mu134w8mw228y":{"ops":[{"insert":"✅\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"格式支持 pdf、txt、doc、docx 类型。\n"}],"zoneId":"xr195snj5ys7r4vvhjk9ek5iyojb4yuuhmnxc10dwdgufunpaigjtn587mu134w8mw228y","zoneType":"Z"},"xr195snj5ys7r4vvhjk9ek5iyojb4yuuhmnxc16l59p6ekstr1h83yfn5qyeyphqtohi94":{"ops":[{"insert":"❌\n"}],"zoneId":"xr195snj5ys7r4vvhjk9ek5iyojb4yuuhmnxc16l59p6ekstr1h83yfn5qyeyphqtohi94","zoneType":"Z"},"xr11sgc7qsefsh0ggohc2e1ycjy166iy47axc1ggle7q1kc516kdso15r2l0um5inia397":{"ops":[{"insert":"上传在线网页\n"}],"zoneId":"xr11sgc7qsefsh0ggohc2e1ycjy166iy47axc1ggle7q1kc516kdso15r2l0um5inia397","zoneType":"Z"},"xr11sgc7qsefsh0ggohc2e1ycjy166iy47axc10dwdgufunpaigjtn587mu134w8mw228y":{"ops":[{"insert":"✅\n"}],"zoneId":"xr11sgc7qsefsh0ggohc2e1ycjy166iy47axc10dwdgufunpaigjtn587mu134w8mw228y","zoneType":"Z"},"xr11sgc7qsefsh0ggohc2e1ycjy166iy47axc16l59p6ekstr1h83yfn5qyeyphqtohi94":{"ops":[{"insert":"❌\n"}],"zoneId":"xr11sgc7qsefsh0ggohc2e1ycjy166iy47axc16l59p6ekstr1h83yfn5qyeyphqtohi94","zoneType":"Z"},"xr17vnaj3nbkh0wohs7ry98y6psjfjzeoiwxc1ggle7q1kc516kdso15r2l0um5inia397":{"ops":[{"insert":"通过 "},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/upload_files\",\"linkId\":\"i84iZctMyc\",\"newTab\":true}"},"insert":"上传文件"},{"insert":" 上传\n"}],"zoneId":"xr17vnaj3nbkh0wohs7ry98y6psjfjzeoiwxc1ggle7q1kc516kdso15r2l0um5inia397","zoneType":"Z"},"xr17vnaj3nbkh0wohs7ry98y6psjfjzeoiwxc10dwdgufunpaigjtn587mu134w8mw228y":{"ops":[{"insert":"❌\n"}],"zoneId":"xr17vnaj3nbkh0wohs7ry98y6psjfjzeoiwxc10dwdgufunpaigjtn587mu134w8mw228y","zoneType":"Z"},"xr17vnaj3nbkh0wohs7ry98y6psjfjzeoiwxc16l59p6ekstr1h83yfn5qyeyphqtohi94":{"ops":[{"insert":"✅\n"}],"zoneId":"xr17vnaj3nbkh0wohs7ry98y6psjfjzeoiwxc16l59p6ekstr1h83yfn5qyeyphqtohi94","zoneType":"Z"}}
        /// </summary>
        /// <param name="agwJsConv"></param>
        /// <param name="chunkStrategy"></param>
        /// <param name="datasetId"></param>
        /// <param name="documentBases">
        /// 表格类型一次只能创建一个待创建的文档信息
        /// </param>
        /// <param name="formatType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateDocumentOpenAPIResponse> CreateDocumentOpenAPIAsync(
            global::G.CreateDocumentOpenAPIAgwJsConv agwJsConv,
            global::G.ChunkStrategy chunkStrategy,
            string datasetId,
            global::System.Collections.Generic.IList<global::G.DocumentBase> documentBases,
            int formatType,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateDocumentOpenAPIRequest
            {
                ChunkStrategy = chunkStrategy,
                DatasetId = datasetId,
                DocumentBases = documentBases,
                FormatType = formatType,
            };

            return await CreateDocumentOpenAPIAsync(
                agwJsConv: agwJsConv,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}