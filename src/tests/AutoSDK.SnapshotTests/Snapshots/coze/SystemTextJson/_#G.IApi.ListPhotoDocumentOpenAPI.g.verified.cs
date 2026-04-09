//HintName: G.IApi.ListPhotoDocumentOpenAPI.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看知识库图片列表<br/>
        /// 调用此接口查看图片类知识库中图片的详细信息。<br/>
        /// 查看图片时，支持通过图片的标注进行筛选。<br/>
        /// &lt;span id="49ec5b56"&gt;&lt;/span&gt;<br/>
        /// ## 接口限制<br/>
        /// 此 API 仅支持查看扣子知识库中的图片详细信息，不适用于火山知识库。
        /// </summary>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="keyword"></param>
        /// <param name="hasCaption"></param>
        /// <param name="datasetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListPhotoDocumentOpenAPIResponse> ListPhotoDocumentOpenAPIAsync(
            string datasetId,
            int? pageNum = default,
            int? pageSize = default,
            string? keyword = default,
            bool? hasCaption = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}