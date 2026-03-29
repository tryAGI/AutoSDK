//HintName: G.IApi.OpenGetProjectList.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看应用列表<br/>
        /// {"0":{"ops":[{"insert":"查看指定工作空间的应用列表。\n"},{"attributes":{"anchor":"6438c6a8","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"查看指定工作空间的应用列表，包含草稿状态的应用和已发布的应用。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子个人版中，你只能查询你作为工作空间所有者的应用。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子企业版中，你可以查看指定工作空间下的所有应用。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="publishStatus"></param>
        /// <param name="connectorId"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenGetProjectListResponse> OpenGetProjectListAsync(
            string workspaceId,
            global::G.OpenGetProjectListPublishStatus? publishStatus = default,
            string? connectorId = default,
            int? pageNum = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}