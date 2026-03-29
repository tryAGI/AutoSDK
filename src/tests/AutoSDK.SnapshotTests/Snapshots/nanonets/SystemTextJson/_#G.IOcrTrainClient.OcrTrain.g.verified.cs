//HintName: G.IOcrTrainClient.OcrTrain.g.cs
#nullable enable

namespace G
{
    public partial interface IOcrTrainClient
    {
        /// <summary>
        /// Train Model<br/>
        /// Train a model after uploading files to the model.<br/>
        /// The same end point is to be used to re-train a model after uploading more files to improve the model.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/OCR/Model/{{model_id}}/Train/");<br/>
        /// var request = new RestRequest(Method.POST);<br/>
        /// request.AddHeader("authorization", "Basic [[.ApiKey]]");<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> OcrTrainAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}