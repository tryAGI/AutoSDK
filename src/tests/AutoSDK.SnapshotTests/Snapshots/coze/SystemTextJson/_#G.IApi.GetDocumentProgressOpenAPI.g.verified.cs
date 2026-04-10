//HintName: G.IApi.GetDocumentProgressOpenAPI.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看知识库文件上传进度<br/>
        /// {"0":{"ops":[{"insert":"调用此接口获取扣子知识库文件的上传进度。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"此接口支持查看所有类型知识库文件的上传进度，例如文本、图片、表格。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"支持批量查看多个文件的进度，多个文件必须位于同一个知识库中。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"该 API 仅支持查看扣子知识库中的文件上传进度，不支持查看火山知识库中的文件上传进度。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="agwJsConv"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetDocumentProgressOpenAPIResponse> GetDocumentProgressOpenAPIAsync(
            string datasetId,
            global::G.GetDocumentProgressOpenAPIAgwJsConv agwJsConv,

            global::G.GetDocumentProgressOpenAPIRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 查看知识库文件上传进度<br/>
        /// {"0":{"ops":[{"insert":"调用此接口获取扣子知识库文件的上传进度。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"此接口支持查看所有类型知识库文件的上传进度，例如文本、图片、表格。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"支持批量查看多个文件的进度，多个文件必须位于同一个知识库中。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"该 API 仅支持查看扣子知识库中的文件上传进度，不支持查看火山知识库中的文件上传进度。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="agwJsConv"></param>
        /// <param name="documentIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetDocumentProgressOpenAPIResponse> GetDocumentProgressOpenAPIAsync(
            string datasetId,
            global::G.GetDocumentProgressOpenAPIAgwJsConv agwJsConv,
            global::System.Collections.Generic.IList<string> documentIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}