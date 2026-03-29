//HintName: G.IApi.OpenAPIGetWorkflowRunHistory.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查询工作流异步执行结果<br/>
        /// {"0":{"ops":[{"insert":"工作流异步运行后，查看执行结果。\n"},{"attributes":{"anchor":"382d8a84","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_run\",\"linkId\":\"pzq5RT59ic\",\"newTab\":true}"},"insert":"执行工作流"},{"insert":"或"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/resume_workflow\",\"linkId\":\"DWpq7HpwCu\"}"},"insert":"恢复运行工作流"},{"insert":" API 时，如果选择异步运行工作流，响应信息中会返回 execute_id，开发者可以通过本 API 查询指定事件的执行结果。\n"},{"attributes":{"anchor":"c74dc548","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"限制说明\n"},{"attributes":{"lmkr":"1","ol-id":"4isg3TOi","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"本 API 的流控限制请参见 "},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/coze_api_overview\",\"linkId\":\"cI3Eawsei6\",\"newTab\":true}"},"insert":"API 介绍"},{"insert":"。\n"},{"attributes":{"list":"bullet1","lmkr":"1","start":"2","origin-start":"2"},"insert":"*"},{"insert":"工作流的"},{"attributes":{"bold":"true"},"insert":"输出节点"},{"insert":"的输出数据最多保存 24 小时，"},{"attributes":{"bold":"true"},"insert":"结束节点"},{"insert":"为 7 天。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"2","origin-start":"2"},"insert":"*"},{"insert":"输出节点的输出内容超过 1MB 时，无法保证返回内容的完整性。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="executeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIGetWorkflowRunHistoryResponse> OpenAPIGetWorkflowRunHistoryAsync(
            string workflowId,
            string executeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}