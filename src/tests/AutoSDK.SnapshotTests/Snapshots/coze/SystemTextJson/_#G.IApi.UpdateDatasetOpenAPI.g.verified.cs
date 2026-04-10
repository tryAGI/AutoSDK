//HintName: G.IApi.UpdateDatasetOpenAPI.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 修改知识库信息<br/>
        /// 调用此接口修改扣子知识库信息。<br/>
        /// * 此接口会全量刷新知识库的 name、file_id 和 description 配置，如果未设置这些参数，参数将恢复默认配置。<br/>
        /// * 知识库分为扣子知识库和火山知识库，该 API 仅用于修改扣子知识库，不支持修改火山知识库，如果需要修改火山知识库的信息，请参见[修改火山知识库信息 API 文档](https://whttps://www.volcengine.com/docs/84313/1254592)。<br/>
        /// * 仅支持修改本人为所有者的知识库信息，包括知识库名称、图标、描述等信息。<br/>
        /// * 如需修改知识库图标，需要先调用 API [上传文件](https://www.coze.cn/docs/developer_guides/upload_files)，将图片文件上传至扣子平台。
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateDatasetOpenAPIResponse> UpdateDatasetOpenAPIAsync(
            string datasetId,

            global::G.UpdateDatasetOpenAPIRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 修改知识库信息<br/>
        /// 调用此接口修改扣子知识库信息。<br/>
        /// * 此接口会全量刷新知识库的 name、file_id 和 description 配置，如果未设置这些参数，参数将恢复默认配置。<br/>
        /// * 知识库分为扣子知识库和火山知识库，该 API 仅用于修改扣子知识库，不支持修改火山知识库，如果需要修改火山知识库的信息，请参见[修改火山知识库信息 API 文档](https://whttps://www.volcengine.com/docs/84313/1254592)。<br/>
        /// * 仅支持修改本人为所有者的知识库信息，包括知识库名称、图标、描述等信息。<br/>
        /// * 如需修改知识库图标，需要先调用 API [上传文件](https://www.coze.cn/docs/developer_guides/upload_files)，将图片文件上传至扣子平台。
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="description"></param>
        /// <param name="fileId"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateDatasetOpenAPIResponse> UpdateDatasetOpenAPIAsync(
            string datasetId,
            string name,
            string? description = default,
            string? fileId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}