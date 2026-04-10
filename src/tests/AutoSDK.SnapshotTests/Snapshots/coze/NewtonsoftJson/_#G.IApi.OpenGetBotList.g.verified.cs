//HintName: G.IApi.OpenGetBotList.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看智能体列表<br/>
        /// {"0":{"ops":[{"insert":"查看指定空间的智能体列表，包含草稿状态的智能体和已发布的智能体。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子个人版中，仅支持查询作为空间所有者的智能体。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子企业版中，可以查看指定空间下的所有智能体。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="publishStatus"></param>
        /// <param name="connectorId"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenGetBotListResponse> OpenGetBotListAsync(
            string workspaceId,
            global::G.OpenGetBotListPublishStatus? publishStatus = default,
            string? connectorId = default,
            int? pageNum = default,
            int? pageSize = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}