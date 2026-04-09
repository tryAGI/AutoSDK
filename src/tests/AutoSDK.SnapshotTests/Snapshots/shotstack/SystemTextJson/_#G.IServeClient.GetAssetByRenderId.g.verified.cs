//HintName: G.IServeClient.GetAssetByRenderId.g.cs
#nullable enable

namespace G
{
    public partial interface IServeClient
    {
        /// <summary>
        /// Get Asset by Render ID<br/>
        /// A render may generate more than one file, such as a video, thumbnail and poster image. When the assets are<br/>
        /// created the only known id is the render id returned by the original [render request](#render-video), status <br/>
        /// request or webhook. This endpoint lets you look up one or more assets by the render id.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/serve/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetRenderResponse> GetAssetByRenderIdAsync(
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}