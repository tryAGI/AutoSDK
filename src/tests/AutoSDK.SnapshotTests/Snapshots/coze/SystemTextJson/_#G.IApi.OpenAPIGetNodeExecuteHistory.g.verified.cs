//HintName: G.IApi.OpenAPIGetNodeExecuteHistory.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查询输出节点的执行结果<br/>
        /// {"0":{"ops":[{"insert":"查询输出节点的执行结果。\n"},{"attributes":{"anchor":"bd698b7c","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"通过 "},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_history\",\"linkId\":\"GQHoddqp0g\",\"newTab\":true}"},"insert":"查询工作流异步执行结果"},{"insert":" API 查询工作流执行结果时，如果工作流输出节点的输出内容超过 1MB，查询工作流异步执行结果 API 无法返回完整的输出节点内容。需要调用本 API，根据工作流的执行 ID 以及"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/workflow_history\",\"linkId\":\"GQHoddqp0g\",\"newTab\":true}"},"insert":"查询工作流异步执行结果"},{"insert":" API 返回的节点执行 UUID，逐一查询每个节点的输出内容。\n"},{"attributes":{"anchor":"3df0f7dc","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","ol-id":"52EEXQDp","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"本 API 的流控限制请参见 "},{"insert":"API 介绍","attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/coze_api_overview\",\"linkId\":\"cI3Eawsei6\",\"newTab\":true}"}},{"insert":"。\n"},{"attributes":{"list":"bullet1","lmkr":"1","start":"2","origin-start":"2"},"insert":"*"},{"insert":"输出节点的输出数据最多保存 24 小时。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"2","origin-start":"2"},"insert":"*"},{"insert":"仅支持查询输出节点的执行结果，不支持查询结束节点的执行结果。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"2","origin-start":"2"},"insert":"*"},{"insert":"输出节点的输出内容超过1MB 时，无法保证返回内容的完整性。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="executeId"></param>
        /// <param name="nodeExecuteUuid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIGetNodeExecuteHistoryResponse> OpenAPIGetNodeExecuteHistoryAsync(
            string workflowId,
            string executeId,
            string nodeExecuteUuid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}