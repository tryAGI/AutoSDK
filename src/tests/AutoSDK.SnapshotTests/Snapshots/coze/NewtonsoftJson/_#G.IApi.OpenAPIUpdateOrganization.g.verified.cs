//HintName: G.IApi.OpenAPIUpdateOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 修改组织基本信息<br/>
        /// {"0":{"ops":[{"insert":"修改指定组织的基本信息，包括组织名称和描述。\n"},{"attributes":{"anchor":"253a2615","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：仅扣子企业旗舰版支持。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"组织的名称和描述需要符合内容安全规范，不得包含涉政、涉黄等违规内容，否则扣子编程会提示 4102 错误。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIUpdateOrganizationResponse> OpenAPIUpdateOrganizationAsync(
            string organizationId,

            global::G.OpenAPIUpdateOrganizationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 修改组织基本信息<br/>
        /// {"0":{"ops":[{"insert":"修改指定组织的基本信息，包括组织名称和描述。\n"},{"attributes":{"anchor":"253a2615","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：仅扣子企业旗舰版支持。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"组织的名称和描述需要符合内容安全规范，不得包含涉政、涉黄等违规内容，否则扣子编程会提示 4102 错误。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIUpdateOrganizationResponse> OpenAPIUpdateOrganizationAsync(
            string organizationId,
            string? description = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}