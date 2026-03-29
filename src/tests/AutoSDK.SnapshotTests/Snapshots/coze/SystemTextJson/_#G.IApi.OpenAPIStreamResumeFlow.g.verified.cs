//HintName: G.IApi.OpenAPIStreamResumeFlow.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 恢复运行工作流（流式响应）<br/>
        /// {"0":{"ops":[{"insert":"流式恢复运行已中断的工作流。\n"},{"attributes":{"anchor":"72087735","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明\n"},{"insert":"执行包含问答节点的工作流时，智能体会以指定问题向用户提问，并等待用户回答。此时工作流为中断状态，开发者需要调用此接口回答问题，并恢复运行工作流。如果用户的响应和智能体预期提取的信息不匹配，例如缺少必选的字段，或字段数据类型不一致，工作流会再次中断并追问。如果询问 3 次仍未收到符合预期的回复，则判定为工作流执行失败。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"7RIQlXCuBM\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":"和"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"gwYYTY5Gfa\"}"},"insert":"恢复运行工作流"},{"insert":" 的区别如下：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run\",\"linkId\":\"xa14LowCgk\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"API，中断恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"THtKh3T2Jj\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":" API，该 API 通过流式返回执行结果。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"nU83ymXL6E\"}"},"insert":"执行工作流"},{"insert":" API，中断恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"Ult0p3pfqX\"}"},"insert":"恢复运行工作流"},{"insert":"  API，该 API 支持同步运行或异步运行返回执行结果。\n"},{"attributes":{"anchor":"3ab9d3c3","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"最多调用此接口恢复运行 3 次，如果第三次恢复运行时智能体仍未收到符合预期的回复，则判定为工作流执行失败。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"恢复运行后，index 和节点 index 都会重置。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"恢复运行工作流也会产生 token 消耗，且与"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run\",\"linkId\":\"dC3l54XV5l\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"时消耗的 token 数量相同。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIStreamResumeFlowResponse> OpenAPIStreamResumeFlowAsync(

            global::G.OpenAPIStreamResumeFlowRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 恢复运行工作流（流式响应）<br/>
        /// {"0":{"ops":[{"insert":"流式恢复运行已中断的工作流。\n"},{"attributes":{"anchor":"72087735","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明\n"},{"insert":"执行包含问答节点的工作流时，智能体会以指定问题向用户提问，并等待用户回答。此时工作流为中断状态，开发者需要调用此接口回答问题，并恢复运行工作流。如果用户的响应和智能体预期提取的信息不匹配，例如缺少必选的字段，或字段数据类型不一致，工作流会再次中断并追问。如果询问 3 次仍未收到符合预期的回复，则判定为工作流执行失败。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"7RIQlXCuBM\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":"和"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"gwYYTY5Gfa\"}"},"insert":"恢复运行工作流"},{"insert":" 的区别如下：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run\",\"linkId\":\"xa14LowCgk\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"API，中断恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"THtKh3T2Jj\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":" API，该 API 通过流式返回执行结果。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"nU83ymXL6E\"}"},"insert":"执行工作流"},{"insert":" API，中断恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"Ult0p3pfqX\"}"},"insert":"恢复运行工作流"},{"insert":"  API，该 API 支持同步运行或异步运行返回执行结果。\n"},{"attributes":{"anchor":"3ab9d3c3","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"最多调用此接口恢复运行 3 次，如果第三次恢复运行时智能体仍未收到符合预期的回复，则判定为工作流执行失败。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"恢复运行后，index 和节点 index 都会重置。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"恢复运行工作流也会产生 token 消耗，且与"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run\",\"linkId\":\"dC3l54XV5l\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"时消耗的 token 数量相同。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="eventId">
        /// 工作流执行中断事件 ID
        /// </param>
        /// <param name="interruptType">
        /// 中断类型
        /// </param>
        /// <param name="resumeData">
        /// 恢复执行时，用户对智能体指定问题的回复
        /// </param>
        /// <param name="workflowId">
        /// 待执行的 Workflow ID，此工作流应已发布
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIStreamResumeFlowResponse> OpenAPIStreamResumeFlowAsync(
            string eventId,
            int interruptType,
            string resumeData,
            string workflowId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}