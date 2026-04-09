//HintName: G.IApi.OpenAPIUpdateEnterpriseMember.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 修改企业员工的角色<br/>
        /// {"0":{"ops":[{"insert":"修改企业员工的角色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"企业员工角色包括企业管理员和企业普通成员，你可以通过本 API 修改企业员工的角色。\n"},{"attributes":{"anchor":"5fb118b3","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"不能修改访客的角色。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="enterpriseId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIUpdateEnterpriseMemberResponse> OpenAPIUpdateEnterpriseMemberAsync(
            string enterpriseId,
            string userId,

            global::G.OpenAPIUpdateEnterpriseMemberRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 修改企业员工的角色<br/>
        /// {"0":{"ops":[{"insert":"修改企业员工的角色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"企业员工角色包括企业管理员和企业普通成员，你可以通过本 API 修改企业员工的角色。\n"},{"attributes":{"anchor":"5fb118b3","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"不能修改访客的角色。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="enterpriseId"></param>
        /// <param name="userId"></param>
        /// <param name="role"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIUpdateEnterpriseMemberResponse> OpenAPIUpdateEnterpriseMemberAsync(
            string enterpriseId,
            string userId,
            global::G.OpenAPIUpdateEnterpriseMemberRequestRole role,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}