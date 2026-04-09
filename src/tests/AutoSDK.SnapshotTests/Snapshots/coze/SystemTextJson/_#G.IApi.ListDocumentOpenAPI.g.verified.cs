//HintName: G.IApi.ListDocumentOpenAPI.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看知识库文件列表<br/>
        /// {"0":{"ops":[{"insert":"调用接口查看指定扣子知识库的文件列表，即文档、表格或图像列表。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"RjvcRFKukW","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"RjvcRFKukW":{"ops":[{"insert":"仅支持通过本 API 查看扣子知识库中的文件列表，不支持查看火山知识库中的文件列表。查看火山知识库中的文件列表请参见"},{"attributes":{"hyperlink":"{\"href\":\"https://www.volcengine.com/docs/84313/1254621\",\"linkId\":\"4DILQISw2H\",\"newTab\":true}"},"insert":"查看火山知识库的文件列表"},{"insert":"。\n"}],"zoneId":"RjvcRFKukW","zoneType":"Z"}}
        /// </summary>
        /// <param name="agwJsConv"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListDocumentOpenAPIResponse> ListDocumentOpenAPIAsync(
            global::G.ListDocumentOpenAPIAgwJsConv agwJsConv,

            global::G.ListDocumentOpenAPIRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 查看知识库文件列表<br/>
        /// {"0":{"ops":[{"insert":"调用接口查看指定扣子知识库的文件列表，即文档、表格或图像列表。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"RjvcRFKukW","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"RjvcRFKukW":{"ops":[{"insert":"仅支持通过本 API 查看扣子知识库中的文件列表，不支持查看火山知识库中的文件列表。查看火山知识库中的文件列表请参见"},{"attributes":{"hyperlink":"{\"href\":\"https://www.volcengine.com/docs/84313/1254621\",\"linkId\":\"4DILQISw2H\",\"newTab\":true}"},"insert":"查看火山知识库的文件列表"},{"insert":"。\n"}],"zoneId":"RjvcRFKukW","zoneType":"Z"}}
        /// </summary>
        /// <param name="agwJsConv"></param>
        /// <param name="datasetId"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListDocumentOpenAPIResponse> ListDocumentOpenAPIAsync(
            global::G.ListDocumentOpenAPIAgwJsConv agwJsConv,
            string datasetId,
            int? page = default,
            int? size = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}