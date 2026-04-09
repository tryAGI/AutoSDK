//HintName: G.IApi.OpenListBotVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看智能体版本列表<br/>
        /// {"0":{"ops":[{"attributes":{"heading":" ","anchor":"fb1c6378","description":"文档标题","lmkr":"1"},"insert":"*"},{"insert":"查看智能体版本列表。\n"},{"attributes":{"anchor":"2de8c7c4","heading":"h2","lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"查询某个智能体的版本列表，支持查询已发布版本或未发布版本的版本号、版本创建者信息、创建时间等。\n"},{"attributes":{"lmkr":"1","description":"文档标题","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"扣子个人版中，仅支持查询作为空间所有者的智能体。 \n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"扣子企业版中，可以查看企业下的所有智能体。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="publishStatus"></param>
        /// <param name="connectorId"></param>
        /// <param name="botId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenListBotVersionsResponse> OpenListBotVersionsAsync(
            string botId,
            int? pageNum = default,
            int? pageSize = default,
            global::G.OpenListBotVersionsPublishStatus? publishStatus = default,
            string? connectorId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}