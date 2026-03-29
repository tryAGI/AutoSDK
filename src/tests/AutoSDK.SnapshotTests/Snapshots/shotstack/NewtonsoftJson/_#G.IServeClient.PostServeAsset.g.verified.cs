//HintName: G.IServeClient.PostServeAsset.g.cs
#nullable enable

namespace G
{
    public partial interface IServeClient
    {
        /// <summary>
        /// Transfer Asset<br/>
        /// Transfer a file from any publicly available URL to one or more Serve API<br/>
        /// [destinations](#tocs_destinations).<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/serve/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TransferResponse> PostServeAssetAsync(

            global::G.Transfer request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer Asset<br/>
        /// Transfer a file from any publicly available URL to one or more Serve API<br/>
        /// [destinations](#tocs_destinations).<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/serve/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="url">
        /// The file URL to fetch and transfer.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/video.mp4
        /// </param>
        /// <param name="id">
        /// An identifier for the asset which must be provided by the client. The identifier does not need to be unique.<br/>
        /// Example: 018e8937-5015-75ee-aab6-03f214981133
        /// </param>
        /// <param name="destinations">
        /// Specify the storage locations and hosting services to send the file to.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TransferResponse> PostServeAssetAsync(
            string url,
            string id,
            global::System.Collections.Generic.IList<global::G.Destinations> destinations,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}