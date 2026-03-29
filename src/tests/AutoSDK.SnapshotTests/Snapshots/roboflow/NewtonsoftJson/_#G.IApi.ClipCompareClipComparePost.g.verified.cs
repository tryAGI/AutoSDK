//HintName: G.IApi.ClipCompareClipComparePost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// CLIP Compare<br/>
        /// Run the Open AI CLIP model to compute similarity scores.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClipCompareResponse> ClipCompareClipComparePostAsync(

            global::G.ClipCompareRequest request,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// CLIP Compare<br/>
        /// Run the Open AI CLIP model to compute similarity scores.
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
        /// <param name="clipVersionId">
        /// The version ID of CLIP to be used for this request. Must be one of RN101, RN50, RN50x16, RN50x4, RN50x64, ViT-B-16, ViT-B-32, ViT-L-14-336px, and ViT-L-14.<br/>
        /// Default Value: ViT-B-16
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="subject">
        /// The type of image data provided, one of 'url' or 'base64'
        /// </param>
        /// <param name="subjectType">
        /// The type of subject, one of 'image' or 'text'<br/>
        /// Default Value: image
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="promptType">
        /// The type of prompt, one of 'image' or 'text'<br/>
        /// Default Value: text
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClipCompareResponse> ClipCompareClipComparePostAsync(
            string id,
            global::G.AnyOf<global::G.InferenceRequestImage, string> subject,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object> prompt,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            string? requestApiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? clipVersionId = default,
            string? modelId = default,
            string? subjectType = default,
            string? promptType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}