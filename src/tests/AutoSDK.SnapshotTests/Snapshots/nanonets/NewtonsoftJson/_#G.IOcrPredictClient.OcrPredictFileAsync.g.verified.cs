//HintName: G.IOcrPredictClient.OcrPredictFileAsync.g.cs
#nullable enable

namespace G
{
    public partial interface IOcrPredictClient
    {
        /// <summary>
        /// Async Prediction for Image File<br/>
        /// Given an image file, extract data as per the label(s) specified in the model, &lt;u&gt;asynchronously&lt;/u&gt;.<br/>
        /// This end point will send back a response as soon as the file has been uploaded, with a file ID. To retrieve the extracted data from the uploaded file, please use this file ID and hit the [Get Prediction File by ID](#operation/ocr/predict/id) end point.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="async"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/OCR/Model/{{model_id}}/LabelFile/?async=true");<br/>
        /// var request = new RestRequest(Method.POST);<br/>
        /// request.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("[[.ApiKey]]:")));<br/>
        /// request.AddHeader("Accept", "multipart/form-data");<br/>
        /// request.AddFile("file", "REPLACE_IMAGE_PATH.jpg");<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> OcrPredictFileAsyncAsync(
            string modelId,
            bool async,

            global::G.OcrPredictFileAsyncRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Async Prediction for Image File<br/>
        /// Given an image file, extract data as per the label(s) specified in the model, &lt;u&gt;asynchronously&lt;/u&gt;.<br/>
        /// This end point will send back a response as soon as the file has been uploaded, with a file ID. To retrieve the extracted data from the uploaded file, please use this file ID and hit the [Get Prediction File by ID](#operation/ocr/predict/id) end point.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="async"></param>
        /// <param name="file">
        /// The file to be uploaded.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG or PDF
        /// </param>
        /// <param name="filename">
        /// The file to be uploaded.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG or PDF
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OcrPredictFileAsyncAsync(
            string modelId,
            bool async,
            byte[] file,
            string filename,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}