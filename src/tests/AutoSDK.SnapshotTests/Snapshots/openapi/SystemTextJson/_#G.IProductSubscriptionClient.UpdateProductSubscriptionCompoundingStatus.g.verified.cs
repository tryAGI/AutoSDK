//HintName: G.IProductSubscriptionClient.UpdateProductSubscriptionCompoundingStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IProductSubscriptionClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateProductSubscriptionCompoundingStatusAsync(
            global::G.ProductSubscriptionForUpdateCompoundingStatusRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="id"></param>
        /// <param name="compoundingStatusEnumId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateProductSubscriptionCompoundingStatusAsync(
            string? currentCulture = default,
            long? id = default,
            int? compoundingStatusEnumId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}