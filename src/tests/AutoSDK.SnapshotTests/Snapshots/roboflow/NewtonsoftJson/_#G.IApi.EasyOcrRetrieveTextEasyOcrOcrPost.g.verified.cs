//HintName: G.IApi.EasyOcrRetrieveTextEasyOcrOcrPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// EasyOCR OCR response<br/>
        /// Run the EasyOCR model to retrieve text in an image.
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
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.OCRInferenceResponse, global::System.Collections.Generic.IList<global::G.OCRInferenceResponse>>> EasyOcrRetrieveTextEasyOcrOcrPostAsync(

            global::G.EasyOCRInferenceRequest request,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// EasyOCR OCR response<br/>
        /// Run the EasyOCR model to retrieve text in an image.
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
        /// <param name="image"></param>
        /// <param name="easyOcrVersionId">
        /// Default Value: english_g2
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="languageCodes">
        /// Default Value: [en]
        /// </param>
        /// <param name="quantize">
        /// Quantized models are smaller and faster, but may be less accurate and won't work correctly on all hardware.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.OCRInferenceResponse, global::System.Collections.Generic.IList<global::G.OCRInferenceResponse>>> EasyOcrRetrieveTextEasyOcrOcrPostAsync(
            string id,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage> image,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            string? requestApiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? easyOcrVersionId = default,
            string? modelId = default,
            global::System.Collections.Generic.IList<string>? languageCodes = default,
            bool? quantize = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}