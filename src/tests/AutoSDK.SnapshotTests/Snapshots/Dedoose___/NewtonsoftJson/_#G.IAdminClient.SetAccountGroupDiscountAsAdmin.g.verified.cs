//HintName: G.IAdminClient.SetAccountGroupDiscountAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// SetAccountGroupDiscount<br/>
        /// SetAccountGroupDiscount
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetAccountGroupDiscountAsAdminAsync(
            global::G.SetAccountGroupDiscountRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// SetAccountGroupDiscount<br/>
        /// SetAccountGroupDiscount
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetAccountGroupDiscountAsAdminAsync(
            global::System.Guid accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}