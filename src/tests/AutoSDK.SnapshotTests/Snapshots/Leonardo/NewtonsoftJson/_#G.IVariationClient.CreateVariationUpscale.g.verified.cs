//HintName: G.IVariationClient.CreateVariationUpscale.g.cs
#nullable enable

namespace G
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Create upscale<br/>
        /// This endpoint will create an upscale for the provided image ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVariationUpscaleResponse> CreateVariationUpscaleAsync(
            global::G.CreateVariationUpscaleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create upscale<br/>
        /// This endpoint will create an upscale for the provided image ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVariationUpscaleResponse> CreateVariationUpscaleAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}