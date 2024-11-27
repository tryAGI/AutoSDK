//HintName: G.IAdminClient.SetAccountStudentDiscountAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// SetAccountStudentDiscount<br/>
        /// SetAccountStudentDiscount
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetAccountStudentDiscountAsAdminAsync(
            global::G.SetAccountStudentDiscountRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// SetAccountStudentDiscount<br/>
        /// SetAccountStudentDiscount
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetAccountStudentDiscountAsAdminAsync(
            global::System.Guid accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}