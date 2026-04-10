//HintName: G.IOcrPredictClient.OcrPredictUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IOcrPredictClient
    {
        /// <summary>
        /// Prediction for Image URLs<br/>
        /// Given image URL(s), extract data as per the label(s) specified in the model.<br/>
        /// Multiple image URLs per request are allowed.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/OCR/Model/{{model_id}}/LabelUrls/");<br/>
        /// var request = new RestRequest(Method.POST);<br/>
        /// request.AddHeader("authorization", "Basic [[.ApiKey]]");<br/>
        /// request.AddHeader("accept", "application/x-www-form-urlencoded");<br/>
        /// request.AddParameter("urls", "https://nanonets.s3-us-west-2.amazonaws.com/test-images/test1.jpg");<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> OcrPredictUrlAsync(
            string modelId,

            global::G.OcrPredictUrlRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prediction for Image URLs<br/>
        /// Given image URL(s), extract data as per the label(s) specified in the model.<br/>
        /// Multiple image URLs per request are allowed.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="urls">
        /// Array of URLs of the training files.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG and/or PDF
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OcrPredictUrlAsync(
            string modelId,
            string urls,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}