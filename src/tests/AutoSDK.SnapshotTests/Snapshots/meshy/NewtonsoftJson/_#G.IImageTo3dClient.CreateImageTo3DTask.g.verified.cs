//HintName: G.IImageTo3dClient.CreateImageTo3DTask.g.cs
#nullable enable

namespace G
{
    public partial interface IImageTo3dClient
    {
        /// <summary>
        /// Create an Image to 3D task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateImageTo3DTaskAsync(

            global::G.ImageTo3DRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Image to 3D task
        /// </summary>
        /// <param name="imageUrl">
        /// Public URL or base64 data URI (.jpg/.jpeg/.png)
        /// </param>
        /// <param name="modelType">
        /// Default Value: standard
        /// </param>
        /// <param name="aiModel">
        /// Default Value: latest
        /// </param>
        /// <param name="topology">
        /// Default Value: triangle
        /// </param>
        /// <param name="targetPolycount">
        /// Default Value: 30000
        /// </param>
        /// <param name="symmetryMode">
        /// Default Value: auto
        /// </param>
        /// <param name="shouldRemesh">
        /// Default Value: false
        /// </param>
        /// <param name="savePreRemeshedModel">
        /// Save pre-remesh GLB (requires should_remesh=true)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="shouldTexture">
        /// Default Value: true
        /// </param>
        /// <param name="enablePbr">
        /// Default Value: false
        /// </param>
        /// <param name="poseMode"></param>
        /// <param name="texturePrompt"></param>
        /// <param name="textureImageUrl">
        /// URL or base64 for texture reference
        /// </param>
        /// <param name="moderation">
        /// Default Value: false
        /// </param>
        /// <param name="imageEnhancement">
        /// Optimize input image (meshy-6/latest only)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="removeLighting">
        /// Remove highlights/shadows (meshy-6/latest only)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="targetFormats"></param>
        /// <param name="autoSize">
        /// Default Value: false
        /// </param>
        /// <param name="originAt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateImageTo3DTaskAsync(
            string imageUrl,
            global::G.ModelType? modelType = default,
            global::G.AiModel? aiModel = default,
            global::G.Topology? topology = default,
            int? targetPolycount = default,
            global::G.SymmetryMode? symmetryMode = default,
            bool? shouldRemesh = default,
            bool? savePreRemeshedModel = default,
            bool? shouldTexture = default,
            bool? enablePbr = default,
            global::G.PoseMode? poseMode = default,
            string? texturePrompt = default,
            string? textureImageUrl = default,
            bool? moderation = default,
            bool? imageEnhancement = default,
            bool? removeLighting = default,
            global::System.Collections.Generic.IList<global::G.TargetFormat3D>? targetFormats = default,
            bool? autoSize = default,
            global::G.OriginAt? originAt = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}