//HintName: G.IAccountClient.AccountUpdateAccountPWPolicy.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// UpdateAccountPWPolicy.
        /// </summary>
        /// <param name="token"></param>
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
        global::System.Threading.Tasks.Task<global::G.AccountVO> AccountUpdateAccountPWPolicyAsync(
            string? token = default,
            global::System.Guid? accountId = default,
            bool? enforcePolicy = default,
            int? minLength = default,
            bool? requireChar = default,
            bool? requireUpper = default,
            bool? requireNumber = default,
            bool? requireSymbol = default,
            double? maxAgeInDays = default,
            bool? require2Auth = default,
            bool? relogin2Auth = default,
            int? idleTimeoutInMinutes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}