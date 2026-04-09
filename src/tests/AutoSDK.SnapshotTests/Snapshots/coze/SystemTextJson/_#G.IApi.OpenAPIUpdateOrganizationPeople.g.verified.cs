//HintName: G.IApi.OpenAPIUpdateOrganizationPeople.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 修改组织成员的角色<br/>
        /// {"0":{"ops":[{"insert":"修改组织成员的角色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"组织成员角色包括组织超级管理员、组织管理员、组织成员和访客。你可以通过本 API 修改组织成员的角色。\n"},{"attributes":{"anchor":"28ae56c4","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"企业外部用户的角色只能是访客，不支持修改。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"企业员工的角色不能设置为访客。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"组织管理员不能将其他人设为组织超级管理员，只有组织超级管理员创建的访问令牌能设置其他人为组织超级管理员。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIUpdateOrganizationPeopleResponse> OpenAPIUpdateOrganizationPeopleAsync(
            string organizationId,
            string userId,

            global::G.OpenAPIUpdateOrganizationPeopleRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 修改组织成员的角色<br/>
        /// {"0":{"ops":[{"insert":"修改组织成员的角色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"组织成员角色包括组织超级管理员、组织管理员、组织成员和访客。你可以通过本 API 修改组织成员的角色。\n"},{"attributes":{"anchor":"28ae56c4","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"企业外部用户的角色只能是访客，不支持修改。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"企业员工的角色不能设置为访客。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"组织管理员不能将其他人设为组织超级管理员，只有组织超级管理员创建的访问令牌能设置其他人为组织超级管理员。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="organizationRoleType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIUpdateOrganizationPeopleResponse> OpenAPIUpdateOrganizationPeopleAsync(
            string organizationId,
            string userId,
            global::G.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType organizationRoleType,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}