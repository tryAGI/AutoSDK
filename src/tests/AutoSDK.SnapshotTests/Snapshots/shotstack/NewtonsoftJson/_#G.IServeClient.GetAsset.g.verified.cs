//HintName: G.IServeClient.GetAsset.g.cs
#nullable enable

namespace G
{
    public partial interface IServeClient
    {
        /// <summary>
        /// Get Asset<br/>
        /// The Serve API is used to interact with, and delete hosted assets including videos, images, audio files, <br/>
        /// thumbnails and poster images. Use this endpoint to fetch an asset by asset id. Note that an asset id is unique<br/>
        /// for each asset and different from the render id.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/serve/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> GetAssetAsync(
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}