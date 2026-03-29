//HintName: G.IApi.RetrieveChatOpen.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看对话详情<br/>
        /// {"0":{"ops":[{"insert":"查看对话的详细信息。\n"},{"insert":"在非流式会话场景中，调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/chat_v3\",\"linkId\":\"Srm1CAE3gC\",\"newTab\":true}"},"insert":"发起对话"},{"insert":"接口后，可以先轮询此 API 确认本轮对话已结束（status=completed），再调用接口"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/list_chat_messages\",\"linkId\":\"FZ93xQaX3Y\",\"newTab\":true}"},"insert":"查看对话消息详情"},{"insert":"查看本轮对话的模型回复。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"SCJjubfZPl","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"SCJjubfZPl":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"仅在对话开启了保存历史记录（auto_save_history=true）后，可通过此接口查看对话的详细信息。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"建议一个对话每秒轮询一次。\n"}],"zoneId":"SCJjubfZPl","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="chatId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetrieveChatOpenResponse> RetrieveChatOpenAsync(
            string conversationId,
            string chatId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}