//HintName: G.IApi.OpenAPIAddWorkflowCollaborator.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 添加工作流协作者<br/>
        /// {"0":{"ops":[{"insert":"添加工作流协作者。\n"},{"attributes":{"anchor":"fbed88b4","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"套餐限制：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"每次请求只能添加一位协作者。如需添加多位，请依次发送请求。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"协作者只能是该工作空间的成员。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"主账号内的所有子账号共享同一 API 的流控额度，单个 API 的流控限制为 5 QPS。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"工作流的所有者和协作者"},{"insert":"有权添加。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIAddWorkflowCollaboratorResponse> OpenAPIAddWorkflowCollaboratorAsync(
            string workflowId,

            global::G.OpenAPIAddWorkflowCollaboratorRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 添加工作流协作者<br/>
        /// {"0":{"ops":[{"insert":"添加工作流协作者。\n"},{"attributes":{"anchor":"fbed88b4","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"套餐限制：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"每次请求只能添加一位协作者。如需添加多位，请依次发送请求。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"协作者只能是该工作空间的成员。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"主账号内的所有子账号共享同一 API 的流控额度，单个 API 的流控限制为 5 QPS。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"工作流的所有者和协作者"},{"insert":"有权添加。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="collaborators"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIAddWorkflowCollaboratorResponse> OpenAPIAddWorkflowCollaboratorAsync(
            string workflowId,
            global::System.Collections.Generic.IList<global::G.PropertiesCollaboratorsItems> collaborators,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}