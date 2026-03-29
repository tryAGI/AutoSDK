//HintName: G.IApi.RetrieveMessageApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看消息详情<br/>
        /// 查看指定消息的详细信息。
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetrieveMessageApiResponse> RetrieveMessageApiAsync(
            string conversationId,
            string messageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}