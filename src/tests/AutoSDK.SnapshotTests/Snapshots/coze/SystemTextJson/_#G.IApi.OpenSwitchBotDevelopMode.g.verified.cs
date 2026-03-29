//HintName: G.IApi.OpenSwitchBotDevelopMode.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 开启或关闭智能体多人协作<br/>
        /// {"0":{"ops":[{"attributes":{"anchor":"7c953f3d","heading":" ","description":"文档标题","lmkr":"1"},"insert":"*"},{"insert":"开启或关闭智能体多人协作模式。\n"},{"attributes":{"lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"开启多人协作后，你才能调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_bot_collaborator\",\"linkId\":\"MqdhrU6Xj0\"}"},"insert":"添加智能体的协作者"},{"insert":" API 为智能体添加协作者。\n"},{"attributes":{"anchor":"d8374fde","heading":"h2","lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"智能体所有者"},{"insert":"能开启或关闭智能体的多人协作模式。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"关闭智能体多人协作前，需要先调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/remove_bot_collaborator\",\"linkId\":\"P95JGTCPGu\"}"},"insert":"删除智能体协作者"},{"insert":" API 删除所有协作者。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenSwitchBotDevelopModeResponse> OpenSwitchBotDevelopModeAsync(
            string botId,

            global::G.OpenSwitchBotDevelopModeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 开启或关闭智能体多人协作<br/>
        /// {"0":{"ops":[{"attributes":{"anchor":"7c953f3d","heading":" ","description":"文档标题","lmkr":"1"},"insert":"*"},{"insert":"开启或关闭智能体多人协作模式。\n"},{"attributes":{"lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"开启多人协作后，你才能调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_bot_collaborator\",\"linkId\":\"MqdhrU6Xj0\"}"},"insert":"添加智能体的协作者"},{"insert":" API 为智能体添加协作者。\n"},{"attributes":{"anchor":"d8374fde","heading":"h2","lmkr":"1","description":"文档标题"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"不支持渠道类型 OAuth 应用。使用 OAuth JWT 应用和服务访问令牌时，只需要有对应权限点即可。其余认证方式，只有"},{"attributes":{"bold":"true"},"insert":"智能体所有者"},{"insert":"能开启或关闭智能体的多人协作模式。\n"},{"attributes":{"lmkr":"1","list":"bullet1","description":"文档标题"},"insert":"*"},{"insert":"关闭智能体多人协作前，需要先调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/remove_bot_collaborator\",\"linkId\":\"P95JGTCPGu\"}"},"insert":"删除智能体协作者"},{"insert":" API 删除所有协作者。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="collaborationMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenSwitchBotDevelopModeResponse> OpenSwitchBotDevelopModeAsync(
            string botId,
            global::G.OpenSwitchBotDevelopModeRequestCollaborationMode? collaborationMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}