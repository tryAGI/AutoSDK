//HintName: G.IRetextureClient.CreateRetextureTask.g.cs
#nullable enable

namespace G
{
    public partial interface IRetextureClient
    {
        /// <summary>
        /// Create a Retexture task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateRetextureTaskAsync(

            global::G.RetextureRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Retexture task
        /// </summary>
        /// <param name="inputTaskId">
        /// ID of completed task
        /// </param>
        /// <param name="modelUrl">
        /// Public URL or data URI (.glb/.gltf/.obj/.fbx/.stl)
        /// </param>
        /// <param name="textStylePrompt">
        /// Text description for texture style
        /// </param>
        /// <param name="imageStyleUrl">
        /// URL or data URI (.jpg/.jpeg/.png) for style reference
        /// </param>
        /// <param name="aiModel">
        /// Default Value: latest
        /// </param>
        /// <param name="enableOriginalUv">
        /// Preserve existing UV mapping<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enablePbr">
        /// Default Value: false
        /// </param>
        /// <param name="removeLighting">
        /// Remove highlights/shadows (meshy-6/latest only)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="targetFormats"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateRetextureTaskAsync(
            string? inputTaskId = default,
            string? modelUrl = default,
            string? textStylePrompt = default,
            string? imageStyleUrl = default,
            global::G.AiModel? aiModel = default,
            bool? enableOriginalUv = default,
            bool? enablePbr = default,
            bool? removeLighting = default,
            global::System.Collections.Generic.IList<global::G.TargetFormat3D>? targetFormats = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}