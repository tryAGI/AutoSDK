//HintName: G.IApi.OpenAPIRemoveAppCollaborator.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 删除应用协作者<br/>
        /// {"0":{"ops":[{"insert":"删除扣子应用的协作者。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"删除协作者时，扣子会将该协作者创建的工作流、插件等资源转移给应用的所有者。\n"},{"attributes":{"anchor":"3dc926e4","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"主账号内的所有子账号共享同一 API 的流控额度，单个 API 的流控限制为 5 QPS。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"每次请求只能删除一位协作者。如需删除多位，请依次发送请求。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"使用个人访问令牌时，只有应用的所有者和协作者有权删除。使用 OAuth 应用和服务访问令牌时，只需要有对应权限点即可。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIRemoveAppCollaboratorResponse> OpenAPIRemoveAppCollaboratorAsync(
            string appId,
            string userId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 删除应用协作者<br/>
        /// {"0":{"ops":[{"insert":"删除扣子应用的协作者。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"删除协作者时，扣子会将该协作者创建的工作流、插件等资源转移给应用的所有者。\n"},{"attributes":{"anchor":"3dc926e4","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"主账号内的所有子账号共享同一 API 的流控额度，单个 API 的流控限制为 5 QPS。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"每次请求只能删除一位协作者。如需删除多位，请依次发送请求。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"使用个人访问令牌时，只有应用的所有者和协作者有权删除。使用 OAuth 应用和服务访问令牌时，只需要有对应权限点即可。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIRemoveAppCollaboratorResponse> OpenAPIRemoveAppCollaboratorAsync(
            string appId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}