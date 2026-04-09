//HintName: G.IApi.OpenUpdateSpace.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 修改工作空间基本信息<br/>
        /// {"0":{"ops":[{"insert":"修改指定工作空间的基本信息，包括空间名称和描述。\n"},{"attributes":{"anchor":"b16d77c7","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"个人空间"},{"insert":"不支持修改空间基本信息。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"工作空间的名称和描述需要符合内容安全规范，不得包含涉政、涉黄等违规内容，否则扣子会提示 4014 错误。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenUpdateSpaceResponse> OpenUpdateSpaceAsync(
            string workspaceId,

            global::G.OpenUpdateSpaceRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 修改工作空间基本信息<br/>
        /// {"0":{"ops":[{"insert":"修改指定工作空间的基本信息，包括空间名称和描述。\n"},{"attributes":{"anchor":"b16d77c7","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"个人空间"},{"insert":"不支持修改空间基本信息。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"工作空间的名称和描述需要符合内容安全规范，不得包含涉政、涉黄等违规内容，否则扣子会提示 4014 错误。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenUpdateSpaceResponse> OpenUpdateSpaceAsync(
            string workspaceId,
            string? description = default,
            string? name = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}