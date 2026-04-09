//HintName: G.IDubbingClient.PutDubbingByDubbingProjectId.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Add locales to a a dubbing project (original imported video)<br/>
        /// Add the passed target locales to a dubbing project (original imported video). If a target locale is already added, it will be skipped.
        /// </summary>
        /// <param name="dubbingProjectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddLocalesToDubbingProjectResponse> PutDubbingByDubbingProjectIdAsync(
            global::System.Guid dubbingProjectId,

            global::G.AddLocalesToDubbingProjectRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add locales to a a dubbing project (original imported video)<br/>
        /// Add the passed target locales to a dubbing project (original imported video). If a target locale is already added, it will be skipped.
        /// </summary>
        /// <param name="dubbingProjectId"></param>
        /// <param name="targetLanguages">
        /// The languages to dub the source media asset to.<br/>
        /// Example: [es-ES, fr-FR]
        /// </param>
        /// <param name="lipsyncEnabled">
        /// Whether to enable lipsync for the dubbed video.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="videoDuration">
        /// The duration of the video to create.<br/>
        /// Default Value: adaptive<br/>
        /// Example: adaptive
        /// </param>
        /// <param name="visibility">
        /// The visibility of the dubbed video.<br/>
        /// Default Value: private<br/>
        /// Example: private
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddLocalesToDubbingProjectResponse> PutDubbingByDubbingProjectIdAsync(
            global::System.Guid dubbingProjectId,
            global::System.Collections.Generic.IList<global::G.DubbingOutputLanguage> targetLanguages,
            bool? lipsyncEnabled = default,
            global::G.AddLocalesToDubbingProjectRequestVideoDuration? videoDuration = default,
            global::G.AddLocalesToDubbingProjectRequestVisibility? visibility = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}