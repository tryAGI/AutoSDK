//HintName: G.IDubbingClient.CreateDubbing.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Create a dubbing project from an uploaded video asset<br/>
        /// Use this endpoint to create a dubbing project from an uploaded video asset.<br/>
        /// ---<br/>
        /// ## 🚧 Beta Feature: sourceVideoUrl<br/>
        /// Creating a dubbing project using `sourceVideoUrl` is currently in **beta** and only available to selected workspaces.<br/>
        /// **Important:**<br/>
        /// - Using this option without access will return a `403 Forbidden` error<br/>
        /// - Contact support to request access to this beta feature<br/>
        /// - Currently only S3 signed URLs are supported (using other URLs will return a `501` error)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDubbingProjectApiResponseSuccess> CreateDubbingAsync(

            global::G.OneOf<global::G.CreateDubbingProjectApiRequestFromSourceAssetId, global::G.CreateDubbingProjectApiRequestFromSourceVideoUrl?> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a dubbing project from an uploaded video asset<br/>
        /// Use this endpoint to create a dubbing project from an uploaded video asset.<br/>
        /// ---<br/>
        /// ## 🚧 Beta Feature: sourceVideoUrl<br/>
        /// Creating a dubbing project using `sourceVideoUrl` is currently in **beta** and only available to selected workspaces.<br/>
        /// **Important:**<br/>
        /// - Using this option without access will return a `403 Forbidden` error<br/>
        /// - Contact support to request access to this beta feature<br/>
        /// - Currently only S3 signed URLs are supported (using other URLs will return a `501` error)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDubbingProjectApiResponseSuccess> CreateDubbingAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}