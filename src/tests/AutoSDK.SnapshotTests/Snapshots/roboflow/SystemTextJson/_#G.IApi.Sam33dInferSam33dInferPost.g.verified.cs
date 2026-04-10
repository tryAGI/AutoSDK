//HintName: G.IApi.Sam33dInferSam33dInferPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// SAM3 3D Object Generation<br/>
        /// Generate 3D meshes and Gaussian splatting from 2D images with mask prompts.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Sam33dInferSam33dInferPostAsync(

            global::G.Sam33dObjectsInferenceRequest request,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// SAM3 3D Object Generation<br/>
        /// Generate 3D meshes and Gaussian splatting from 2D images with mask prompts.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="id"></param>
        /// <param name="requestApiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="usageBillable">
        /// Default Value: true
        /// </param>
        /// <param name="start"></param>
        /// <param name="source"></param>
        /// <param name="sourceInfo"></param>
        /// <param name="disableModelMonitoring">
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The input image to be used for 3D generation.
        /// </param>
        /// <param name="maskInput">
        /// Mask input in any supported format: polygon [x1,y1,x2,y2,...], binary mask (base64), RLE dict, or list of these.
        /// </param>
        /// <param name="modelId">
        /// The model ID for SAM3_3D.<br/>
        /// Default Value: sam3-3d-objects
        /// </param>
        /// <param name="outputMeshes">
        /// SAM3 3D always outputs object gaussians, and can optionally output object meshes if output_meshes is True.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="outputScene">
        /// Output the combined scene reconstruction in addition to individual object reconstructions.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="withMeshPostprocess">
        /// Enable mesh postprocessing.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="withTextureBaking">
        /// Enable texture baking for meshes.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="useDistillations">
        /// Use the distilled versions of the model components.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> Sam33dInferSam33dInferPostAsync(
            string id,
            global::G.InferenceRequestImage image,
            object maskInput,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            string? requestApiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? modelId = default,
            bool? outputMeshes = default,
            bool? outputScene = default,
            bool? withMeshPostprocess = default,
            bool? withTextureBaking = default,
            bool? useDistillations = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}