//HintName: G.IOcrModelDetailsClient.OcrModelId.g.cs
#nullable enable

namespace G
{
    public partial interface IOcrModelDetailsClient
    {
        /// <summary>
        /// Get Model Details by ID<br/>
        /// Retrieve a specific model's details given its ID.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/OCR/Model/" + {{model_id}});<br/>
        /// var request = new RestRequest(Method.GET);<br/>
        /// request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("[[.ApiKey]]:")));<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> OcrModelIdAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}