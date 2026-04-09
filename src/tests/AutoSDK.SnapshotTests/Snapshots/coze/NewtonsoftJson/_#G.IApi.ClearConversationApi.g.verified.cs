//HintName: G.IApi.ClearConversationApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 清除上下文<br/>
        /// 清除指定会话中的上下文。<br/>
        /// &lt;span id="3a1c8d70"&gt;&lt;/span&gt;<br/>
        /// ## 接口说明<br/>
        /// 在智能体对话场景中，上下文指模型在处理当前输入时所能参考的历史消息、对话记录，它决定了模型对当前任务的理解深度和连贯性，直接影响输出结果的准确性和相关性。多轮对话中，如果需要开启新的话题，可以调用此 API 清除上下文。清除上下文后，对话中的历史消息不会作为上下文被输入给模型，后续对话不再受之前历史消息的影响，避免信息干扰，确保对话的准确性和连贯性。<br/>
        /// 会话中的消息存储在上下文段落（section）中，每次调用此 API 清除上下文时，系统会自动删除旧的上下文段落，并创建新的上下文段落用于存储新的消息。再次发起对话时，新分区中的消息会作为新的上下文传递给模型参考。<br/>
        /// * 清除上下文 API 只是清空模型可见的消息历史，不会实际删除会话中的消息，通过[查看消息列表](https://www.coze.cn/open/docs/developer_guides/list_message)或[查看消息详情](https://www.coze.cn/open/docs/developer_guides/retrieve_message)等 API 仍能查看到消息内容。<br/>
        /// * 会话、对话、消息和上下文段落的术语解释请参见[基础概念](https://www.coze.cn/open/docs/developer_guides/coze_api_overview#fed4a54c)。<br/>
        /// ![图片](https://p9-arcosite.byteimg.com/tos-cn-i-goo7wpa0wc/e4b55816254c4446ae59bbca33ca8e1d~tplv-goo7wpa0wc-image.image)
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClearConversationApiResponse> ClearConversationApiAsync(
            string conversationId,

            object request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 清除上下文<br/>
        /// 清除指定会话中的上下文。<br/>
        /// &lt;span id="3a1c8d70"&gt;&lt;/span&gt;<br/>
        /// ## 接口说明<br/>
        /// 在智能体对话场景中，上下文指模型在处理当前输入时所能参考的历史消息、对话记录，它决定了模型对当前任务的理解深度和连贯性，直接影响输出结果的准确性和相关性。多轮对话中，如果需要开启新的话题，可以调用此 API 清除上下文。清除上下文后，对话中的历史消息不会作为上下文被输入给模型，后续对话不再受之前历史消息的影响，避免信息干扰，确保对话的准确性和连贯性。<br/>
        /// 会话中的消息存储在上下文段落（section）中，每次调用此 API 清除上下文时，系统会自动删除旧的上下文段落，并创建新的上下文段落用于存储新的消息。再次发起对话时，新分区中的消息会作为新的上下文传递给模型参考。<br/>
        /// * 清除上下文 API 只是清空模型可见的消息历史，不会实际删除会话中的消息，通过[查看消息列表](https://www.coze.cn/open/docs/developer_guides/list_message)或[查看消息详情](https://www.coze.cn/open/docs/developer_guides/retrieve_message)等 API 仍能查看到消息内容。<br/>
        /// * 会话、对话、消息和上下文段落的术语解释请参见[基础概念](https://www.coze.cn/open/docs/developer_guides/coze_api_overview#fed4a54c)。<br/>
        /// ![图片](https://p9-arcosite.byteimg.com/tos-cn-i-goo7wpa0wc/e4b55816254c4446ae59bbca33ca8e1d~tplv-goo7wpa0wc-image.image)
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClearConversationApiResponse> ClearConversationApiAsync(
            string conversationId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}