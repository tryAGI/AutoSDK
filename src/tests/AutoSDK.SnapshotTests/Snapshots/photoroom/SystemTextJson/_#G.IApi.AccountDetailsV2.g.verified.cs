//HintName: G.IApi.AccountDetailsV2.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Account Details v2<br/>
        /// Get current account details, including remaining image edits and monthly quota
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AccountDetailsV2Response> AccountDetailsV2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}