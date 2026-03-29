//HintName: G.IServeClient.DeleteAsset.g.cs
#nullable enable

namespace G
{
    public partial interface IServeClient
    {
        /// <summary>
        /// Delete Asset<br/>
        /// Delete an asset by its asset id. If a render creates multiple assets, such as thumbnail and poster images,<br/>
        /// each asset must be deleted individually by the asset id.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/serve/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAssetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}