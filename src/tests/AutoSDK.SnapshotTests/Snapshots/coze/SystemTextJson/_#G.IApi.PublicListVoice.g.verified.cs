//HintName: G.IApi.PublicListVoice.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看音色列表<br/>
        /// {"0":{"ops":[{"insert":"查看可用的音色列表，包括系统预置音色和自定义音色。\n"},{"attributes":{"anchor":"c9dcf919","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"调用此 API 可查看当前扣子用户可使用的音色列表，包括：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"系统预置音色：扣子平台提供的默认音色。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"自定义音色：当前扣子用户通过"},{"attributes":{"bold":"true"},"insert":"复刻音色"},{"insert":" API 复刻的音色、当前账号加入的所有工作空间中其他扣子用户复刻的音色。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="filterSystemVoice"></param>
        /// <param name="modelType"></param>
        /// <param name="voiceState"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PublicListVoiceResponse> PublicListVoiceAsync(
            bool? filterSystemVoice = default,
            string? modelType = default,
            global::G.OpenAPIVoiceState? voiceState = default,
            int? pageNum = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}