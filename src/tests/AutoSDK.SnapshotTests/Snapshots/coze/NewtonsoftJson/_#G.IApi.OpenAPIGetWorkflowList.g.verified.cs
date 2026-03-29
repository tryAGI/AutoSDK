//HintName: G.IApi.OpenAPIGetWorkflowList.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查询工作流列表<br/>
        /// {"0":{"ops":[{"insert":"查询指定工作空间中的工作流列表及其基本信息。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以查询某个工作空间中的所有工作流或对话流、某个应用关联的工作流或对话流。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="workflowMode"></param>
        /// <param name="appId"></param>
        /// <param name="publishStatus"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIGetWorkflowListResponse> OpenAPIGetWorkflowListAsync(
            string workspaceId,
            int pageNum,
            int? pageSize = default,
            global::G.OpenAPIWorkflowMode? workflowMode = default,
            string? appId = default,
            global::G.PublishStatus? publishStatus = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}