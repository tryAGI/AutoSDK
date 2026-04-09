//HintName: G.IApi.OpenCopyTaskInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查询资源复制的结果<br/>
        /// {"0":{"ops":[{"insert":"查询资源复制的结果。\n"},{"attributes":{"anchor":"d18b55a4","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/copy_resource_task\",\"linkId\":\"qGphY2RMjP\"}"},"insert":"复制资源"},{"insert":" API 时，以下场景中 API 为异步执行，响应信息中会返回 task_id，开发者可以通过本 API 查询指定事件的执行结果。\n"},{"insert":"*","attributes":{"list":"bullet1","lmkr":"1"}},{"insert":"同工作空间复制扣子应用、工作流。\n"},{"insert":"*","attributes":{"list":"bullet1","lmkr":"1"}},{"insert":"跨工作空间复制智能体、扣子应用、工作流。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenCopyTaskInfoResponse> OpenCopyTaskInfoAsync(
            string taskId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}