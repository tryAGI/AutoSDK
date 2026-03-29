//HintName: G.IApi.CreateConversationApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 创建会话<br/>
        /// {"0":{"ops":[{"insert":"创建一个会话。\n"},{"attributes":{"anchor":"1cb6ef34","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"insert":"会话是智能体和用户之间的基于一个或多个主题的问答交互，一个会话包含一条或多条消息。创建会话时，扣子会同时在会话中创建一个空白的上下文片段，用于存储某个主题的消息。后续发起对话时，上下文片段中的消息是模型可见的消息历史。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以在创建会话时同步写入消息，或者创建会话后另外调用 "},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/create_message\",\"linkId\":\"hLSw6DHlqH\"}"},"insert":"创建消息 API"},{"insert":" 写入消息。消息默认写入到最新的一个上下文片段中，对话时将作为上下文传递给模型。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"会话、对话、消息和上下文片段的概念说明，可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/coze_api_overview#4a288f73\",\"linkId\":\"M21F2iMUtU\",\"newTab\":true}"},"insert":"基础概念"},{"insert":"。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"如果需要将不同业务侧用户的会话互相隔离，请参见"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/session_isolation\",\"linkId\":\"BEUGfANcqg\",\"newTab\":true}"},"insert":"如何实现会话隔离"},{"insert":"。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateConversationApiResponse> CreateConversationApiAsync(

            global::G.CreateConversationApiRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 创建会话<br/>
        /// {"0":{"ops":[{"insert":"创建一个会话。\n"},{"attributes":{"anchor":"1cb6ef34","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"insert":"会话是智能体和用户之间的基于一个或多个主题的问答交互，一个会话包含一条或多条消息。创建会话时，扣子会同时在会话中创建一个空白的上下文片段，用于存储某个主题的消息。后续发起对话时，上下文片段中的消息是模型可见的消息历史。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以在创建会话时同步写入消息，或者创建会话后另外调用 "},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/create_message\",\"linkId\":\"hLSw6DHlqH\"}"},"insert":"创建消息 API"},{"insert":" 写入消息。消息默认写入到最新的一个上下文片段中，对话时将作为上下文传递给模型。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"会话、对话、消息和上下文片段的概念说明，可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/coze_api_overview#4a288f73\",\"linkId\":\"M21F2iMUtU\",\"newTab\":true}"},"insert":"基础概念"},{"insert":"。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"如果需要将不同业务侧用户的会话互相隔离，请参见"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/session_isolation\",\"linkId\":\"BEUGfANcqg\",\"newTab\":true}"},"insert":"如何实现会话隔离"},{"insert":"。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="connectorId"></param>
        /// <param name="messages">
        /// 校验最多16个
        /// </param>
        /// <param name="metaData"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateConversationApiResponse> CreateConversationApiAsync(
            string? botId = default,
            string? connectorId = default,
            global::System.Collections.Generic.IList<global::G.EnterMessage1>? messages = default,
            global::System.Collections.Generic.Dictionary<string, string>? metaData = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}