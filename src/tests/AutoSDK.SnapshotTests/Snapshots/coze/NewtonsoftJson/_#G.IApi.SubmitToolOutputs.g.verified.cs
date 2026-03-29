//HintName: G.IApi.SubmitToolOutputs.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 提交工具执行结果<br/>
        /// {"0":{"ops":[{"insert":"调用此接口提交工具执行的结果。\n"},{"attributes":{"heading":"h2","anchor":"422f2e9b","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以将需要客户端执行的操作定义为插件，对话中如果触发这个插件，流式 event 响应信息会提示“conversation.chat.requires_action”，此时需要执行客户端的操作后，通过此接口提交插件执行后的结果。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"v2D2o9fWV1","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"v2D2o9fWV1":{"ops":[{"insert":"*","attributes":{"list":"bullet1","lmkr":"1"}},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/chat_v3\",\"linkId\":\"W80ifqcYZs\",\"newTab\":true}"},"insert":"发起对话"},{"insert":" API 时，"},{"attributes":{"inlineCode":"true"},"insert":"auto_save_history"},{"insert":" 参数需要设置为 "},{"attributes":{"inlineCode":"true"},"insert":"true"},{"insert":"，否则调用本 API 提交工具执行结果时会提示 5000 错误。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"仅触发了端插件的对话需要调用此接口提交执行结果。端插件是非扣子服务端执行的插件，需要开发者自行执行任务后提交结果，通常用于 IoT 等设备控制场景。详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/guides/use_local_plugin\",\"linkId\":\"BZmIXIYmwW\",\"newTab\":true}"},"insert":"通过 API 使用端插件"},{"insert":"。\n"}],"zoneId":"v2D2o9fWV1","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SubmitToolOutputsResponse> SubmitToolOutputsAsync(
            string conversationId,
            string chatId,

            global::G.SubmitToolOutputsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 提交工具执行结果<br/>
        /// {"0":{"ops":[{"insert":"调用此接口提交工具执行的结果。\n"},{"attributes":{"heading":"h2","anchor":"422f2e9b","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以将需要客户端执行的操作定义为插件，对话中如果触发这个插件，流式 event 响应信息会提示“conversation.chat.requires_action”，此时需要执行客户端的操作后，通过此接口提交插件执行后的结果。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"v2D2o9fWV1","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"v2D2o9fWV1":{"ops":[{"insert":"*","attributes":{"list":"bullet1","lmkr":"1"}},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/chat_v3\",\"linkId\":\"W80ifqcYZs\",\"newTab\":true}"},"insert":"发起对话"},{"insert":" API 时，"},{"attributes":{"inlineCode":"true"},"insert":"auto_save_history"},{"insert":" 参数需要设置为 "},{"attributes":{"inlineCode":"true"},"insert":"true"},{"insert":"，否则调用本 API 提交工具执行结果时会提示 5000 错误。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"仅触发了端插件的对话需要调用此接口提交执行结果。端插件是非扣子服务端执行的插件，需要开发者自行执行任务后提交结果，通常用于 IoT 等设备控制场景。详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/guides/use_local_plugin\",\"linkId\":\"BZmIXIYmwW\",\"newTab\":true}"},"insert":"通过 API 使用端插件"},{"insert":"。\n"}],"zoneId":"v2D2o9fWV1","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="chatId"></param>
        /// <param name="toolOutputs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SubmitToolOutputsResponse> SubmitToolOutputsAsync(
            string conversationId,
            string chatId,
            global::System.Collections.Generic.IList<global::G.ToolOutput> toolOutputs,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}