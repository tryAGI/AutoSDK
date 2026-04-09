//HintName: G.IApi.CreateDraftBot.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 创建智能体<br/>
        /// {"0":{"ops":[{"insert":"创建一个新的智能体。\n"},{"insert":"创建的智能体为未发布的草稿状态，创建后可以在扣子编程智能体列表中查看智能体。调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/publish_bot\",\"linkId\":\"06yargEEv7\"}"},"insert":"发布智能体"},{"insert":" API 发布智能体后，才能通过"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/bots_list_draft_published\",\"linkId\":\"uR4W8XpOAf\"}"},"insert":"查看智能体列表"},{"insert":"或"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/get_metadata_draft_published\",\"linkId\":\"0ghPnfB7hN\"}"},"insert":"查看智能体配置"},{"insert":" API 查看此智能体。\n"},{"insert":"通过 API 方式创建智能体时，支持为智能体设置所在空间、智能体名称和描述、头像、人设与回复逻辑及开场白。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDraftBotResponse> CreateDraftBotAsync(

            global::G.CreateDraftBotRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 创建智能体<br/>
        /// {"0":{"ops":[{"insert":"创建一个新的智能体。\n"},{"insert":"创建的智能体为未发布的草稿状态，创建后可以在扣子编程智能体列表中查看智能体。调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/publish_bot\",\"linkId\":\"06yargEEv7\"}"},"insert":"发布智能体"},{"insert":" API 发布智能体后，才能通过"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/bots_list_draft_published\",\"linkId\":\"uR4W8XpOAf\"}"},"insert":"查看智能体列表"},{"insert":"或"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/get_metadata_draft_published\",\"linkId\":\"0ghPnfB7hN\"}"},"insert":"查看智能体配置"},{"insert":" API 查看此智能体。\n"},{"insert":"通过 API 方式创建智能体时，支持为智能体设置所在空间、智能体名称和描述、头像、人设与回复逻辑及开场白。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="description"></param>
        /// <param name="iconFileId">
        /// 头像文件id
        /// </param>
        /// <param name="mediaConfig"></param>
        /// <param name="modelInfoConfig"></param>
        /// <param name="name"></param>
        /// <param name="onboardingInfo"></param>
        /// <param name="pluginIdList"></param>
        /// <param name="promptInfo"></param>
        /// <param name="spaceId"></param>
        /// <param name="suggestReplyInfo"></param>
        /// <param name="workflowIdList"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDraftBotResponse> CreateDraftBotAsync(
            string name,
            string spaceId,
            string? description = default,
            string? iconFileId = default,
            global::G.PropertiesMediaConfig? mediaConfig = default,
            global::G.PropertiesModelInfoConfig? modelInfoConfig = default,
            global::G.PropertiesOnboardingInfo? onboardingInfo = default,
            global::G.PropertiesPluginIdList? pluginIdList = default,
            global::G.PropertiesPromptInfo? promptInfo = default,
            global::G.PropertiesSuggestReplyInfo? suggestReplyInfo = default,
            global::G.PropertiesWorkflowIdList? workflowIdList = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}