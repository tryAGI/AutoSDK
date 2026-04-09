//HintName: G.IApi.OpenAPIAddEnterpriseMember.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 添加企业成员<br/>
        /// {"0":{"ops":[{"insert":"添加员工到企业。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"在火山引擎创建用户后，"},{"attributes":{"bold":"true"},"insert":"默认会自动将用户添加至企业"},{"insert":"，若未成功添加，你可以调用本 API 将用户添加至企业。火山引擎创建用户的具体方法请参见"},{"insert":"成员管理","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/create_coze_user\",\"linkId\":\"jV1h6CJAd7\"}"}},{"insert":"。\n"},{"attributes":{"anchor":"c1f43b73","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"本 API 仅支持添加员工（火山子用户），不支持添加外部成员（访客）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"添加成员总数不能超过企业标准版权益中的成员数量上限（100 个成员），否则会提示 777074011错误。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"UteVasdpeJ","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"UteVasdpeJ":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"每次请求只能添加一位成员。如需添加多位，请依次发送请求。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"该 API 不支持并发请求。\n"}],"zoneId":"UteVasdpeJ","zoneType":"Z"}}
        /// </summary>
        /// <param name="enterpriseId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIAddEnterpriseMemberResponse> OpenAPIAddEnterpriseMemberAsync(
            string enterpriseId,

            global::G.OpenAPIAddEnterpriseMemberRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 添加企业成员<br/>
        /// {"0":{"ops":[{"insert":"添加员工到企业。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"在火山引擎创建用户后，"},{"attributes":{"bold":"true"},"insert":"默认会自动将用户添加至企业"},{"insert":"，若未成功添加，你可以调用本 API 将用户添加至企业。火山引擎创建用户的具体方法请参见"},{"insert":"成员管理","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/create_coze_user\",\"linkId\":\"jV1h6CJAd7\"}"}},{"insert":"。\n"},{"attributes":{"anchor":"c1f43b73","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"本 API 仅支持添加员工（火山子用户），不支持添加外部成员（访客）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"添加成员总数不能超过企业标准版权益中的成员数量上限（100 个成员），否则会提示 777074011错误。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"UteVasdpeJ","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"UteVasdpeJ":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"每次请求只能添加一位成员。如需添加多位，请依次发送请求。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"该 API 不支持并发请求。\n"}],"zoneId":"UteVasdpeJ","zoneType":"Z"}}
        /// </summary>
        /// <param name="enterpriseId"></param>
        /// <param name="users"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIAddEnterpriseMemberResponse> OpenAPIAddEnterpriseMemberAsync(
            string enterpriseId,
            global::System.Collections.Generic.IList<global::G.PropertiesUsersItems>? users = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}