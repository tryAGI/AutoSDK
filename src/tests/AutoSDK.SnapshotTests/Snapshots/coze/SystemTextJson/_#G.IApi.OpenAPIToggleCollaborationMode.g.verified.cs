//HintName: G.IApi.OpenAPIToggleCollaborationMode.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 开启或关闭工作流多人协作<br/>
        /// {"0":{"ops":[{"insert":"开启或关闭工作流、对话流多人协作。\n"},{"attributes":{"lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"开启多人协作后，你才能调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_workflow_collaborator\",\"linkId\":\"yvb8JbaxI6\"}"},"insert":"添加工作流的协作者"},{"insert":" API 为工作流添加协作者。\n"},{"attributes":{"anchor":"eb5222a1","heading":"h2","lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"只有资源库中的工作流和对话流支持添加多人协作，扣子应用中的工作流不支持开启多人协作模式，否则会报 4000 错误。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"工作流所有者"},{"insert":"能开启或关闭工作流的多人协作模式。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"关闭工作流多人协作前，需要先调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/remove_workflow_collaborator\",\"linkId\":\"y7iKM9RXOS\"}"},"insert":"删除工作流协作者"},{"insert":" API 删除所有协作者。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIToggleCollaborationModeResponse> OpenAPIToggleCollaborationModeAsync(
            string workflowId,

            global::G.OpenAPIToggleCollaborationModeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 开启或关闭工作流多人协作<br/>
        /// {"0":{"ops":[{"insert":"开启或关闭工作流、对话流多人协作。\n"},{"attributes":{"lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"开启多人协作后，你才能调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_workflow_collaborator\",\"linkId\":\"yvb8JbaxI6\"}"},"insert":"添加工作流的协作者"},{"insert":" API 为工作流添加协作者。\n"},{"attributes":{"anchor":"eb5222a1","heading":"h2","lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"只有资源库中的工作流和对话流支持添加多人协作，扣子应用中的工作流不支持开启多人协作模式，否则会报 4000 错误。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"工作流所有者"},{"insert":"能开启或关闭工作流的多人协作模式。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"关闭工作流多人协作前，需要先调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/remove_workflow_collaborator\",\"linkId\":\"y7iKM9RXOS\"}"},"insert":"删除工作流协作者"},{"insert":" API 删除所有协作者。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="collaborationMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIToggleCollaborationModeResponse> OpenAPIToggleCollaborationModeAsync(
            string workflowId,
            global::G.OpenAPIToggleCollaborationModeRequestCollaborationMode? collaborationMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}