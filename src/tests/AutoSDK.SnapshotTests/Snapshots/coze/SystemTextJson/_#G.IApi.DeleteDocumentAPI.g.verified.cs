//HintName: G.IApi.DeleteDocumentAPI.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 删除知识库文件<br/>
        /// 调用此接口删除扣子知识库中的文本、图片、表格等文件，支持批量删除。<br/>
        /// * 仅知识库的所有者可以删除知识库文件。<br/>
        /// * 知识库分为扣子知识库和火山知识库，该 API 仅用于删除扣子知识库中的文件，不支持删除火山知识库中的文件，如果需要删除火山知识库中的文件，请参见[删除火山知识库文件](https://www.volcengine.com/docs/84313/1254608)。
        /// </summary>
        /// <param name="agwJsConv"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteDocumentAPIResponse> DeleteDocumentAPIAsync(
            global::G.DeleteDocumentAPIAgwJsConv agwJsConv,

            global::G.DeleteDocumentAPIRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 删除知识库文件<br/>
        /// 调用此接口删除扣子知识库中的文本、图片、表格等文件，支持批量删除。<br/>
        /// * 仅知识库的所有者可以删除知识库文件。<br/>
        /// * 知识库分为扣子知识库和火山知识库，该 API 仅用于删除扣子知识库中的文件，不支持删除火山知识库中的文件，如果需要删除火山知识库中的文件，请参见[删除火山知识库文件](https://www.volcengine.com/docs/84313/1254608)。
        /// </summary>
        /// <param name="agwJsConv"></param>
        /// <param name="documentIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteDocumentAPIResponse> DeleteDocumentAPIAsync(
            global::G.DeleteDocumentAPIAgwJsConv agwJsConv,
            global::System.Collections.Generic.IList<string> documentIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}