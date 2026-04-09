//HintName: G.IApi.OapiListBillDownloadTask.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查询账单文件<br/>
        /// {"0":{"ops":[{"insert":"查询账单文件。\n"},{"attributes":{"anchor":"2d01b5db","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"当你"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/create_bill_task\",\"linkId\":\"pAHHSsKZtz\",\"newTab\":true}"},"insert":"导出设备账单"},{"insert":"后，可以通过本 API 查询账单文件，获取对应账单文件的 URL 链接，以便下载或查看已导出的账单数据。你可以通过账单文件"},{"attributes":{"ai-gen":"true"},"insert":"查看"},{"insert":"智能硬件"},{"attributes":{"ai-gen":"true"},"insert":"设备"},{"insert":"的用量明细，包括：语音识别 ASR 的音频时长、语音合成 TTS 的字符数、语音合成 TTS 的对话次数、RTC 通话时长、金额等信息。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"rqWkuyzvAI","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"},{"attributes":{"anchor":"77ca1ca6","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"账单下载链接的有效期为 7 天，过期后需要调用"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/create_bill_task\",\"linkId\":\"pAHHSsKZtz\",\"newTab\":true}"},"insert":"导出设备账单"},{"insert":" API 重新导出账单。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"只有当任务状态为 "},{"attributes":{"inlineCode":"true"},"insert":"succeed"},{"insert":" 时，才会返回账单的下载链接。\n"}],"zoneId":"0","zoneType":"Z"},"rqWkuyzvAI":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"仅扣子企业旗舰版的超级管理员和管理员可以调用该 API。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"调用此 API 之前，需要确保企业下的设备已成功上报了设备信息，设备信息的配置方法可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/dev_how_to_guides/deviceInfo\",\"linkId\":\"fUZq1jGycG\",\"newTab\":true}"},"insert":"设置设备信息"},{"insert":"。\n"}],"zoneId":"rqWkuyzvAI","zoneType":"Z"}}
        /// </summary>
        /// <param name="taskIds"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OapiListBillDownloadTaskResponse> OapiListBillDownloadTaskAsync(
            global::System.Collections.Generic.IList<string>? taskIds = default,
            int? pageNum = default,
            int? pageSize = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}