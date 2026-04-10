//HintName: G.IApi.OpenAPICreateOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 创建组织<br/>
        /// {"0":{"ops":[{"insert":"在指定的企业中创建组织。\n"},{"attributes":{"anchor":"21653605","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业旗舰版。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"数量限制"},{"insert":"：一个企业中最多存在 20 个组织。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="enterpriseId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPICreateOrganizationResponse> OpenAPICreateOrganizationAsync(
            string enterpriseId,

            global::G.OpenAPICreateOrganizationRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 创建组织<br/>
        /// {"0":{"ops":[{"insert":"在指定的企业中创建组织。\n"},{"attributes":{"anchor":"21653605","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业旗舰版。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"数量限制"},{"insert":"：一个企业中最多存在 20 个组织。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="enterpriseId"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="superAdminUserId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPICreateOrganizationResponse> OpenAPICreateOrganizationAsync(
            string enterpriseId,
            string name,
            string superAdminUserId,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}