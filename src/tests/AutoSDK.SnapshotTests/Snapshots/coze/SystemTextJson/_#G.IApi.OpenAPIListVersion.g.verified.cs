//HintName: G.IApi.OpenAPIListVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查询工作流的版本列表<br/>
        /// {"0":{"ops":[{"insert":"查询工作流的版本列表。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以通过本 API 查询某个工作流的所有历史版本记录，包括版本号、版本描述、操作者和发布时间等。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="publishStatus"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="includeInputOutput"></param>
        /// <param name="workflowId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIListVersionResponse> OpenAPIListVersionAsync(
            string workflowId,
            global::G.PublishStatus? publishStatus = default,
            int? pageSize = default,
            string? pageToken = default,
            bool? includeInputOutput = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}