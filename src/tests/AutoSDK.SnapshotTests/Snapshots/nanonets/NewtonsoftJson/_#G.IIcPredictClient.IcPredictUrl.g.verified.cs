//HintName: G.IIcPredictClient.IcPredictUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IIcPredictClient
    {
        /// <summary>
        /// Prediction for Image URLs<br/>
        /// Given image URL(s), extract data as per the label(s) specified in the model.<br/>
        /// Multiple image URLs per request are allowed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/ImageCategorization/LabelUrls/");<br/>
        /// var request = new RestRequest(Method.POST);<br/>
        /// request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("[[.ApiKey]]:")));<br/>
        /// request.AddHeader("accept", "application/x-www-form-urlencoded");<br/>
        /// request.AddParameter("modelId", "REPLACE_MODEL_ID");<br/>
        /// request.AddParameter("urls", "https://nanonets.s3-us-west-2.amazonaws.com/test-images/test1.jpg");<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> IcPredictUrlAsync(

            global::G.IcPredictUrlRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prediction for Image URLs<br/>
        /// Given image URL(s), extract data as per the label(s) specified in the model.<br/>
        /// Multiple image URLs per request are allowed.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model on which the operation is to be performed.<br/>
        /// It can be found in the model settings.<br/>
        /// &lt;br /&gt;<br/>
        /// **Eg**: `0a0aa000-0000-0a0-aa00-000a0000000a`
        /// </param>
        /// <param name="urls">
        /// Array of URLs of the training files.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG and/or PDF
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> IcPredictUrlAsync(
            string modelId,
            string urls,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}