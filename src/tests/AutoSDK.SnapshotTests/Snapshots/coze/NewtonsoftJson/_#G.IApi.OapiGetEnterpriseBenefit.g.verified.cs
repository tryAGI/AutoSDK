//HintName: G.IApi.OapiGetEnterpriseBenefit.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查询套餐权益<br/>
        /// {"0":{"ops":[{"insert":"查询当前账号的套餐权益信息。\n"},{"attributes":{"anchor":"9dbdec35","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以通过本 API 查询当前账号的以下套餐权益信息：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"所属的套餐类型。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"扩容管理页面中 API 扩容的信息，包括套餐默认的 API QPS、扩容新增的 API QPS 额度，以及当前实际生效的 API QPS 额度。\n"},{"attributes":{"list":"indent1","text-indent":"true","lmkr":"1"},"insert":"*"},{"attributes":{"width":"400","height":"141.13924050632912","scale":"0.3528481012658228","image":"true","isPlugin":"true","uuid":"MaMnK43a","src":"https://p9-arcosite.byteimg.com/obj/tos-cn-i-goo7wpa0wc/720efb1da1e54938ae626248aebd08c3","loadingStatus":"success"},"insert":" "},{"insert":"\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"套餐权益内通过 MCP 方式调用付费插件的次数限制。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="benefitTypeList"></param>
        /// <param name="resourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OapiGetEnterpriseBenefitResponse> OapiGetEnterpriseBenefitAsync(
            global::System.Collections.Generic.IList<string>? benefitTypeList = default,
            string? resourceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}