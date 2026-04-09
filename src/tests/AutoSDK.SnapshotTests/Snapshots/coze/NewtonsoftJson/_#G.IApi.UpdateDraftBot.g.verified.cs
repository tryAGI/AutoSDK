//HintName: G.IApi.UpdateDraftBot.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 更新智能体<br/>
        /// {"0":{"ops":[{"insert":"更新智能体的配置。\n"},{"insert":"通过此 API 可更新通过扣子编程或 API 方式创建的所有智能体。通过 API 方式修改智能体除了智能体名称和描述、头像、人设与回复逻辑及开场白之外，还支持为智能体绑定知识库和插件。\n"},{"attributes":{"anchor":"a7f3d685","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"不支持通过 API 绑定火山知识库，只能绑定扣子知识库。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateDraftBotResponse> UpdateDraftBotAsync(

            global::G.UpdateDraftBotRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 更新智能体<br/>
        /// {"0":{"ops":[{"insert":"更新智能体的配置。\n"},{"insert":"通过此 API 可更新通过扣子编程或 API 方式创建的所有智能体。通过 API 方式修改智能体除了智能体名称和描述、头像、人设与回复逻辑及开场白之外，还支持为智能体绑定知识库和插件。\n"},{"attributes":{"anchor":"a7f3d685","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"不支持通过 API 绑定火山知识库，只能绑定扣子知识库。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="description"></param>
        /// <param name="iconFileId"></param>
        /// <param name="knowledge"></param>
        /// <param name="mediaConfig"></param>
        /// <param name="modelInfoConfig"></param>
        /// <param name="name"></param>
        /// <param name="onboardingInfo"></param>
        /// <param name="pluginIdList"></param>
        /// <param name="promptInfo"></param>
        /// <param name="suggestReplyInfo"></param>
        /// <param name="workflowIdList"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateDraftBotResponse> UpdateDraftBotAsync(
            string botId,
            string? description = default,
            string? iconFileId = default,
            global::G.PropertiesKnowledge? knowledge = default,
            global::G.PropertiesMediaConfig? mediaConfig = default,
            global::G.PropertiesModelInfoConfig? modelInfoConfig = default,
            string? name = default,
            global::G.PropertiesOnboardingInfo? onboardingInfo = default,
            global::G.PropertiesPluginIdList? pluginIdList = default,
            global::G.PropertiesPromptInfo? promptInfo = default,
            global::G.PropertiesSuggestReplyInfo? suggestReplyInfo = default,
            global::G.PropertiesWorkflowIdList? workflowIdList = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}