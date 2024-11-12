//HintName: G.IModelPriceMapClient.ReadModelPriceMap.g.cs
#nullable enable

namespace G
{
    public partial interface IModelPriceMapClient
    {
        /// <summary>
        /// Read Model Price Map
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReadModelPriceMapAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}