//HintName: G.IApi.CreateMessageApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 创建消息<br/>
        /// 创建一条消息，并将其添加到指定的会话中。<br/>
        /// 会话、对话和消息的概念说明，可参考[基础概念](https://www.coze.cn/docs/developer_guides/coze_api_overview#4a288f73)。<br/>
        /// 消息在服务端的保存时长为 180 天，到期后自动删除。你也可以调用[删除消息](https://www.coze.cn/docs/developer_guides/delete_message)接口，手动从会话中删除消息。<br/>
        /// 你可以通过[查看消息列表](https://www.coze.cn/open/docs/developer_guides/list_message)查询指定会话（conversation）中的所有消息。
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateMessageApiResponse> CreateMessageApiAsync(
            string conversationId,

            global::G.CreateMessageApiRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 创建消息<br/>
        /// 创建一条消息，并将其添加到指定的会话中。<br/>
        /// 会话、对话和消息的概念说明，可参考[基础概念](https://www.coze.cn/docs/developer_guides/coze_api_overview#4a288f73)。<br/>
        /// 消息在服务端的保存时长为 180 天，到期后自动删除。你也可以调用[删除消息](https://www.coze.cn/docs/developer_guides/delete_message)接口，手动从会话中删除消息。<br/>
        /// 你可以通过[查看消息列表](https://www.coze.cn/open/docs/developer_guides/list_message)查询指定会话（conversation）中的所有消息。
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="content">
        /// 内容
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="metaData"></param>
        /// <param name="role">
        /// 已TODO 字段打平
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateMessageApiResponse> CreateMessageApiAsync(
            string conversationId,
            string content,
            global::G.CreateMessageApiRequestContentType contentType,
            global::G.CreateMessageApiRequestRole role,
            global::System.Collections.Generic.Dictionary<string, string>? metaData = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}