//HintName: G.IApi.OpenAPIResumeFlow.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 恢复运行工作流<br/>
        /// {"0":{"ops":[{"insert":"恢复运行工作流。\n"},{"attributes":{"anchor":"842ac83e","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"当调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"6f6CoqUUHd\"}"},"insert":"执行工作流"},{"insert":" API 执行包含问答节点、输入节点的工作流时，智能体会以指定问题向用户提问，并等待用户回答。此时工作流为中断状态，开发者需要调用此 API 回答问题，并恢复运行工作流。如果问答节点勾选了"},{"insert":"从回复中提取字段","attributes":{"bold":"true"}},{"insert":"，当用户的响应和智能体预期提取的信息不匹配，例如缺少必选的字段，或字段数据类型不一致，工作流会再次中断并追问。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"如果"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"BPbGLtCrny\"}"},"insert":"执行工作流"},{"insert":"  API 为同步运行，则恢复运行工作流也为同步运行。如果"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"dChke0kicF\"}"},"insert":"执行工作流"},{"insert":"  API 为异步运行，则恢复运行工作流也为异步运行，你还需要调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_history\",\"linkId\":\"UNm30zYvKE\"}"},"insert":"查询异步执行结果"},{"insert":" API 查询执行结果。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"gRM2p506FE\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":"和"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"ZHAYDn2Ils\"}"},"insert":"恢复运行工作流"},{"insert":" 的区别如下：\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run\",\"linkId\":\"NPczb8G6jJ\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"API 时工作流中断，恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"M7UplYm5nn\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":" API，该 API 通过流式返回执行结果。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"WoLg8TlFAC\"}"},"insert":"执行工作流"},{"insert":" API 时工作流中断，恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"vaT8ww0Xv8\"}"},"insert":"恢复运行工作流"},{"insert":"  API，该 API 支持同步运行或异步运行返回执行结果。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIResumeFlowResponse> OpenAPIResumeFlowAsync(

            global::G.OpenAPIResumeFlowRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 恢复运行工作流<br/>
        /// {"0":{"ops":[{"insert":"恢复运行工作流。\n"},{"attributes":{"anchor":"842ac83e","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"当调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"6f6CoqUUHd\"}"},"insert":"执行工作流"},{"insert":" API 执行包含问答节点、输入节点的工作流时，智能体会以指定问题向用户提问，并等待用户回答。此时工作流为中断状态，开发者需要调用此 API 回答问题，并恢复运行工作流。如果问答节点勾选了"},{"insert":"从回复中提取字段","attributes":{"bold":"true"}},{"insert":"，当用户的响应和智能体预期提取的信息不匹配，例如缺少必选的字段，或字段数据类型不一致，工作流会再次中断并追问。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"如果"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"BPbGLtCrny\"}"},"insert":"执行工作流"},{"insert":"  API 为同步运行，则恢复运行工作流也为同步运行。如果"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"dChke0kicF\"}"},"insert":"执行工作流"},{"insert":"  API 为异步运行，则恢复运行工作流也为异步运行，你还需要调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_history\",\"linkId\":\"UNm30zYvKE\"}"},"insert":"查询异步执行结果"},{"insert":" API 查询执行结果。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"gRM2p506FE\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":"和"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"ZHAYDn2Ils\"}"},"insert":"恢复运行工作流"},{"insert":" 的区别如下：\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/workflow_stream_run\",\"linkId\":\"NPczb8G6jJ\",\"newTab\":true}"},"insert":"执行工作流（流式响应）"},{"insert":"API 时工作流中断，恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_resume\",\"linkId\":\"M7UplYm5nn\"}"},"insert":"恢复运行工作流（流式响应）"},{"insert":" API，该 API 通过流式返回执行结果。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"如果调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"WoLg8TlFAC\"}"},"insert":"执行工作流"},{"insert":" API 时工作流中断，恢复时需要使用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"vaT8ww0Xv8\"}"},"insert":"恢复运行工作流"},{"insert":"  API，该 API 支持同步运行或异步运行返回执行结果。\n"}],"zoneId":"0","zoneType":"Z"}}
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
        global::System.Threading.Tasks.Task<global::G.OpenAPIResumeFlowResponse> OpenAPIResumeFlowAsync(
            string eventId,
            int interruptType,
            string resumeData,
            string workflowId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}