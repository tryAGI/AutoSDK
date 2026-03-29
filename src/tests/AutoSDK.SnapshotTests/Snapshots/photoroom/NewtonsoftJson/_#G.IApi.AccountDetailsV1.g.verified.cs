//HintName: G.IApi.AccountDetailsV1.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Account Details v1<br/>
        /// Get current account details, including remaining credits balance and monthly quota
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AccountDetailsV1Response> AccountDetailsV1Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}