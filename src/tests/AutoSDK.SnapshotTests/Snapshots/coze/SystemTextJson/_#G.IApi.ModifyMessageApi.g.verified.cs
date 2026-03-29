//HintName: G.IApi.ModifyMessageApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 修改消息<br/>
        /// 修改一条消息，支持修改消息内容、附加内容和消息类型。
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModifyMessageApiResponse> ModifyMessageApiAsync(
            string conversationId,
            string messageId,

            global::G.ModifyMessageApiRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 修改消息<br/>
        /// 修改一条消息，支持修改消息内容、附加内容和消息类型。
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="content">
        /// 内容
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="metaData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModifyMessageApiResponse> ModifyMessageApiAsync(
            string conversationId,
            string messageId,
            string? content = default,
            global::G.ModifyMessageApiRequestContentType? contentType = default,
            global::System.Collections.Generic.Dictionary<string, string>? metaData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}