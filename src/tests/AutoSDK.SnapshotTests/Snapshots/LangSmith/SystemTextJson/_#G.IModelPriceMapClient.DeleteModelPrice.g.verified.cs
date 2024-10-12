//HintName: G.IModelPriceMapClient.DeleteModelPrice.g.cs
#nullable enable

namespace G
{
    public partial interface IModelPriceMapClient
    {
        /// <summary>
        /// Delete Model Price
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteModelPriceAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}