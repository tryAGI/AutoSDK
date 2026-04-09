//HintName: G.IOcrUploadClient.OcrUploadUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IOcrUploadClient
    {
        /// <summary>
        /// Upload Training Images by URLs<br/>
        /// Upload training images to a model using image URLs.<br/>
        /// Multiple images can be uploaded in the same request by adding more URLs in the `urls` array.<br/>
        /// On successful upload, model information along with the total number of images per category will be received.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/OCR/Model/REPLACE_MODEL_ID/UploadUrls/");<br/>
        /// var request = new RestRequest(Method.POST);<br/>
        /// request.AddHeader("authorization", "Basic [[.ApiKey]]");<br/>
        /// request.AddHeader("Content-Type", ""application/json"");<br/>
        /// request.AddParameter("undefined", " {"data": [{"filename":"https://nanonets.s3-us-west-2.amazonaws.com/test-images/test1.jpg", "object": [{"name":"category1", "ocr_text": "text inside the bounding box", "bndbox": {"xmin": 1,"ymin": 1,"xmax": 100, "ymax": 100}}, {"name":"category2", "ocr_text": "text inside the bounding box", "bndbox": {"xmin": 1,"ymin": 1,"xmax": 100, "ymax": 100}}]}], "urls": ["https://nanonets.s3-us-west-2.amazonaws.com/test-images/test1.jpg"]}", ParameterType.RequestBody);<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> OcrUploadUrlAsync(
            string contentType,
            string modelId,

            global::G.OcrUploadUrlRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Training Images by URLs<br/>
        /// Upload training images to a model using image URLs.<br/>
        /// Multiple images can be uploaded in the same request by adding more URLs in the `urls` array.<br/>
        /// On successful upload, model information along with the total number of images per category will be received.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="modelId"></param>
        /// <param name="urls">
        /// Array of URLs of the training files.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG and/or PDF
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OcrUploadUrlAsync(
            string contentType,
            string modelId,
            string urls,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}