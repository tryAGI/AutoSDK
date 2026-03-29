//HintName: G.IOcrPredictClient.OcrPredictUrlAsync.g.cs
#nullable enable

namespace G
{
    public partial interface IOcrPredictClient
    {
        /// <summary>
        /// Async Prediction for Image URLs<br/>
        /// Given image URL(s), extract data as per the label(s) specified in the model, &lt;u&gt;asynchronously&lt;/u&gt;.<br/>
        /// This end point will send back a response as soon as the file has been uploaded, with a file ID. To retrieve the extracted data from the uploaded file, please use this file ID and hit the [Get Prediction File by ID](#operation/ocr/predict/id) end point.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="async"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/OCR/Model/{{model_id}}/LabelUrls/?async=true");<br/>
        /// var request = new RestRequest(Method.POST);<br/>
        /// request.AddHeader("authorization", "Basic [[.ApiKey]]");<br/>
        /// request.AddHeader("accept", "application/x-www-form-urlencoded");<br/>
        /// request.AddParameter("urls", "https://nanonets.s3-us-west-2.amazonaws.com/test-images/test1.jpg");<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> OcrPredictUrlAsyncAsync(
            string modelId,
            bool async,

            global::G.OcrPredictUrlAsyncRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Async Prediction for Image URLs<br/>
        /// Given image URL(s), extract data as per the label(s) specified in the model, &lt;u&gt;asynchronously&lt;/u&gt;.<br/>
        /// This end point will send back a response as soon as the file has been uploaded, with a file ID. To retrieve the extracted data from the uploaded file, please use this file ID and hit the [Get Prediction File by ID](#operation/ocr/predict/id) end point.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="async"></param>
        /// <param name="urls">
        /// Array of URLs of the training files.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG and/or PDF
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OcrPredictUrlAsyncAsync(
            string modelId,
            bool async,
            string urls,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}