//HintName: G.IApi.ListDatasetOpenAPI.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看知识库列表<br/>
        /// {"0":{"ops":[{"insert":"调用此接口查看指定空间资源库下的全部知识库。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此接口可查看工作空间下，空间资源库中的全部知识库，包括扣子知识库和火山知识库，无论知识库是否归本人所有。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"Nmd2TWIy1I","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"Nmd2TWIy1I":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"暂不支持通过 API 查看扣子应用中的知识库。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"暂不支持通过该 API 查看火山知识库中的文件列表等详细信息。\n"}],"zoneId":"Nmd2TWIy1I","zoneType":"Z"}}
        /// </summary>
        /// <param name="spaceId"></param>
        /// <param name="name"></param>
        /// <param name="formatType"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListDatasetOpenAPIResponse> ListDatasetOpenAPIAsync(
            string spaceId,
            string? name = default,
            int? formatType = default,
            int? pageNum = default,
            int? pageSize = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}