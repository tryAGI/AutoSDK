//HintName: G.IApi.OpenAPIAddAppCollaborator.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 添加应用协作者<br/>
        /// {"0":{"ops":[{"insert":"添加低代码应用的协作者。\n"},{"attributes":{"anchor":"e2571006","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"套餐限制：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"每次请求只能添加一位协作者。如需添加多位，请依次发送请求。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"协作者只能是该工作空间的成员。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"应用的所有者和协作者"},{"insert":"能添加协作者。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"主账号内的所有子账号共享同一 API 的流控额度，单个 API 的流控限制为 5 QPS。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIAddAppCollaboratorResponse> OpenAPIAddAppCollaboratorAsync(
            string appId,

            global::G.OpenAPIAddAppCollaboratorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 添加应用协作者<br/>
        /// {"0":{"ops":[{"insert":"添加低代码应用的协作者。\n"},{"attributes":{"anchor":"e2571006","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"套餐限制：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"每次请求只能添加一位协作者。如需添加多位，请依次发送请求。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"协作者只能是该工作空间的成员。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"应用的所有者和协作者"},{"insert":"能添加协作者。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"主账号内的所有子账号共享同一 API 的流控额度，单个 API 的流控限制为 5 QPS。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="collaborators"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIAddAppCollaboratorResponse> OpenAPIAddAppCollaboratorAsync(
            string appId,
            global::System.Collections.Generic.IList<global::G.PropertiesCollaboratorsItems> collaborators,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}