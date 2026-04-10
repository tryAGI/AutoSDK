//HintName: G.IApi.ChatSDK.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// websdk<br/>
        /// {"0":{"ops":[{"attributes":{"tags":"Q1RfVq"},"insert":"扣子"},{"insert":"Chat SDK 是一个 JavaScript 库，集成了"},{"attributes":{"tags":"Q1RfVq"},"insert":"扣子"},{"insert":" OpenAPI 的对话、文件上传等能力，便于开发者高效、便捷、快速地搭建一个聊天应用。集成"},{"attributes":{"tags":"Q1RfVq"},"insert":"扣子"},{"insert":" Chat SDK 之后，用户可通过网页悬浮窗方式与 AI 应用。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ChatSDKAsync(

            global::G.ChatSDKRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// websdk<br/>
        /// {"0":{"ops":[{"attributes":{"tags":"Q1RfVq"},"insert":"扣子"},{"insert":"Chat SDK 是一个 JavaScript 库，集成了"},{"attributes":{"tags":"Q1RfVq"},"insert":"扣子"},{"insert":" OpenAPI 的对话、文件上传等能力，便于开发者高效、便捷、快速地搭建一个聊天应用。集成"},{"attributes":{"tags":"Q1RfVq"},"insert":"扣子"},{"insert":" Chat SDK 之后，用户可通过网页悬浮窗方式与 AI 应用。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="auth"></param>
        /// <param name="config"></param>
        /// <param name="ui"></param>
        /// <param name="userInfo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ChatSDKAsync(
            global::G.ChatSDKRequestConfig config,
            global::G.ChatSDKRequestUi ui,
            global::G.ChatSDKRequestUserInfo userInfo,
            global::G.ChatSDKRequestAuth? auth = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}