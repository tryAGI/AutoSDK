//HintName: G.IApi.ListMessageApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看消息列表<br/>
        /// 查看指定会话的消息列表。<br/>
        /// **查看消息列表** API 与**查看对话消息详情** API 的区别在于：<br/>
        /// * **查看消息列表** API 用于查询指定会话（conversation）中的消息记录，不仅包括开发者在会话中手动插入的每一条消息和用户发送的 Query，也包括调用**发起对话** API 得到的 type=answer 的智能体回复，但不包括 type=function_call、tool_response 和 follow-up 类型的对话中间态消息。<br/>
        /// * **查看对话消息详情** API 通常用于非流式对话场景中，查看某次对话（chat）中 type=answer 的智能体回复及 type=function_call、tool_response 和 follow-up 类型类型的对话中间态消息。不包括用户发送的 Query。<br/>
        /// 消息在服务端的保存时长为180天，期满后，消息将自动从会话的消息记录中删除。
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListMessageApiResponse> ListMessageApiAsync(
            string conversationId,

            global::G.ListMessageApiRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 查看消息列表<br/>
        /// 查看指定会话的消息列表。<br/>
        /// **查看消息列表** API 与**查看对话消息详情** API 的区别在于：<br/>
        /// * **查看消息列表** API 用于查询指定会话（conversation）中的消息记录，不仅包括开发者在会话中手动插入的每一条消息和用户发送的 Query，也包括调用**发起对话** API 得到的 type=answer 的智能体回复，但不包括 type=function_call、tool_response 和 follow-up 类型的对话中间态消息。<br/>
        /// * **查看对话消息详情** API 通常用于非流式对话场景中，查看某次对话（chat）中 type=answer 的智能体回复及 type=function_call、tool_response 和 follow-up 类型类型的对话中间态消息。不包括用户发送的 Query。<br/>
        /// 消息在服务端的保存时长为180天，期满后，消息将自动从会话的消息记录中删除。
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="afterId">
        /// 后序消息游标ID  已TODO str
        /// </param>
        /// <param name="beforeId">
        /// 前序消息游标ID  已TODO str
        /// </param>
        /// <param name="chatId">
        /// 运行id
        /// </param>
        /// <param name="limit">
        /// 每页限制条数  TODO 限制50条
        /// </param>
        /// <param name="order">
        /// 查询顺序  desc倒序 asc正序 TODO 默认倒序
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListMessageApiResponse> ListMessageApiAsync(
            string conversationId,
            string? afterId = default,
            string? beforeId = default,
            string? chatId = default,
            int? limit = default,
            global::G.ListMessageApiRequestOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}