//HintName: G.IUserClient.V2UserRemainingQuota.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// v2/user/remaining_quota<br/>
        /// v2/user/remaining_quota
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V2UserRemainingQuotaAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}