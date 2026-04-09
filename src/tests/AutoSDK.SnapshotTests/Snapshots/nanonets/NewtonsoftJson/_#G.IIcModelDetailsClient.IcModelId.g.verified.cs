//HintName: G.IIcModelDetailsClient.IcModelId.g.cs
#nullable enable

namespace G
{
    public partial interface IIcModelDetailsClient
    {
        /// <summary>
        /// Get Model Details by ID<br/>
        /// Retrieve a specific model's details given its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/ImageCategorization/Model/?id=REPLACE_MODEL_ID");<br/>
        /// var request = new RestRequest(Method.GET);<br/>
        /// request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("[[.ApiKey]]:")));<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> IcModelIdAsync(
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}