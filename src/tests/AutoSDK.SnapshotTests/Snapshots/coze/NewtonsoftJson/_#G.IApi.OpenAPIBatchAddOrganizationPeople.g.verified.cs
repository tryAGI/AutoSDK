//HintName: G.IApi.OpenAPIBatchAddOrganizationPeople.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 添加组织成员<br/>
        /// {"0":{"ops":[{"insert":"添加组织成员。\n"},{"attributes":{"anchor":"11ed8408","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"用户加入企业时将自动加入默认组织。"},{"insert":"创建组织","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_organization_people\",\"linkId\":\"nodD3vENEW\"}"}},{"insert":"后，你可以调用本 API 将员工和访客加入对应组织。\n"},{"attributes":{"anchor":"4387678e","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"用户加入组织前，需先将其添加至对应企业，具体请参见"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_enterprise_member\",\"linkId\":\"pz7Z6Qp5gO\"}"},"insert":"添加企业成员"},{"insert":"。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"访客加入组织后，组织角色只能是访客。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"2TogSUFtr5","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"2TogSUFtr5":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"每次请求只能添加一位成员。如需添加多位，请依次发送请求。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"该 API 不支持并发请求。\n"}],"zoneId":"2TogSUFtr5","zoneType":"Z"}}
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIBatchAddOrganizationPeopleResponse> OpenAPIBatchAddOrganizationPeopleAsync(
            string organizationId,

            global::G.OpenAPIBatchAddOrganizationPeopleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 添加组织成员<br/>
        /// {"0":{"ops":[{"insert":"添加组织成员。\n"},{"attributes":{"anchor":"11ed8408","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"用户加入企业时将自动加入默认组织。"},{"insert":"创建组织","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_organization_people\",\"linkId\":\"nodD3vENEW\"}"}},{"insert":"后，你可以调用本 API 将员工和访客加入对应组织。\n"},{"attributes":{"anchor":"4387678e","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"用户加入组织前，需先将其添加至对应企业，具体请参见"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_enterprise_member\",\"linkId\":\"pz7Z6Qp5gO\"}"},"insert":"添加企业成员"},{"insert":"。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"访客加入组织后，组织角色只能是访客。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"2TogSUFtr5","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"2TogSUFtr5":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"每次请求只能添加一位成员。如需添加多位，请依次发送请求。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"该 API 不支持并发请求。\n"}],"zoneId":"2TogSUFtr5","zoneType":"Z"}}
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="organizationPeople"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIBatchAddOrganizationPeopleResponse> OpenAPIBatchAddOrganizationPeopleAsync(
            string organizationId,
            global::System.Collections.Generic.IList<global::G.PropertiesOrganizationPeopleItems> organizationPeople,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}