//HintName: G.IAccountClient.UpdateAccountPWPolicy.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// UpdateAccountPWPolicy<br/>
        /// UpdateAccountPWPolicy
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AccountVO> UpdateAccountPWPolicyAsync(
            global::G.UpdateAccountPWPolicyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateAccountPWPolicy<br/>
        /// UpdateAccountPWPolicy
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="enforcePolicy"></param>
        /// <param name="minLength"></param>
        /// <param name="requireChar"></param>
        /// <param name="requireUpper"></param>
        /// <param name="requireNumber"></param>
        /// <param name="requireSymbol"></param>
        /// <param name="maxAgeInDays"></param>
        /// <param name="require2Auth"></param>
        /// <param name="relogin2Auth"></param>
        /// <param name="idleTimeoutInMinutes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AccountVO> UpdateAccountPWPolicyAsync(
            global::System.Guid accountId,
            bool enforcePolicy,
            int minLength,
            bool requireChar,
            bool requireUpper,
            bool requireNumber,
            bool requireSymbol,
            double maxAgeInDays,
            bool require2Auth,
            bool relogin2Auth,
            int idleTimeoutInMinutes,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}