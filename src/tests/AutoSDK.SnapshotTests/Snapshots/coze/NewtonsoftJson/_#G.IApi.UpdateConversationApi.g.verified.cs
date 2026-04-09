//HintName: G.IApi.UpdateConversationApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 更新会话名称<br/>
        /// {"0":{"ops":[{"insert":"会话创建者可以更新指定会话的会话名，以便更好地识别和管理会话。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"在创建会话时，扣子会默认将用户发送的第一个消息内容作为会话名称。用户也可以根据会话的实际内容或主题对会话名称进行更新，从而更直观地区分不同的会话，提升管理效率。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateConversationApiResponse> UpdateConversationApiAsync(
            string conversationId,

            global::G.UpdateConversationApiRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 更新会话名称<br/>
        /// {"0":{"ops":[{"insert":"会话创建者可以更新指定会话的会话名，以便更好地识别和管理会话。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"在创建会话时，扣子会默认将用户发送的第一个消息内容作为会话名称。用户也可以根据会话的实际内容或主题对会话名称进行更新，从而更直观地区分不同的会话，提升管理效率。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateConversationApiResponse> UpdateConversationApiAsync(
            string conversationId,
            string name,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}