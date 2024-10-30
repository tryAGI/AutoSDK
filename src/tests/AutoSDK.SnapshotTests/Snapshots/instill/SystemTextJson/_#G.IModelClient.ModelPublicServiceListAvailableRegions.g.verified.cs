//HintName: G.IModelClient.ModelPublicServiceListAvailableRegions.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List available regions<br/>
        /// Returns a paginated list of available regions.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListAvailableRegionsResponse> ModelPublicServiceListAvailableRegionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}