//HintName: G.IApi.OpenRemoveSpaceMember.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 批量移除空间中的用户<br/>
        /// {"0":{"ops":[{"insert":"批量移除空间中的用户。\n"},{"attributes":{"anchor":"3011aa0f","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"调用本 API 将用户从指定的工作空间中移除。只能移除空间管理员或成员，不支持移除空间所有者。批量移除用户时，你可以在返回结果中查看移除失败的用户以及具体原因。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenRemoveSpaceMemberResponse> OpenRemoveSpaceMemberAsync(
            string workspaceId,

            global::G.OpenRemoveSpaceMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 批量移除空间中的用户<br/>
        /// {"0":{"ops":[{"insert":"批量移除空间中的用户。\n"},{"attributes":{"anchor":"3011aa0f","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"调用本 API 将用户从指定的工作空间中移除。只能移除空间管理员或成员，不支持移除空间所有者。批量移除用户时，你可以在返回结果中查看移除失败的用户以及具体原因。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="userIds">
        /// 要移除的成员，数量最多5
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenRemoveSpaceMemberResponse> OpenRemoveSpaceMemberAsync(
            string workspaceId,
            global::System.Collections.Generic.IList<string> userIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}