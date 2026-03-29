//HintName: G.IApi.CreateVirtualTryOn.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create virtual try-on task<br/>
        /// Generate a virtual try-on image by placing garments on a person image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateVirtualTryOnAsync(

            global::G.CreateVirtualTryOnRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create virtual try-on task<br/>
        /// Generate a virtual try-on image by placing garments on a person image.
        /// </summary>
        /// <param name="modelName">
        /// Model to use for virtual try-on.<br/>
        /// Default Value: kolors-virtual-try-on-v1-5
        /// </param>
        /// <param name="personImageUrl">
        /// URL of the person image.
        /// </param>
        /// <param name="clothImageUrls">
        /// Array of garment image URLs. 1-5 items.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateVirtualTryOnAsync(
            string personImageUrl,
            global::System.Collections.Generic.IList<string> clothImageUrls,
            global::G.CreateVirtualTryOnRequestModelName? modelName = default,
            string? callbackUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}