//HintName: G.IOcrPredictClient.OcrPredictGetFile.g.cs
#nullable enable

namespace G
{
    public partial interface IOcrPredictClient
    {
        /// <summary>
        /// Get All Prediction Files<br/>
        /// Retrieve the files that have been processed by the prediction end points.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="startDayInterval"></param>
        /// <param name="currentBatchDay"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/Inferences/Model/{{model_id}}/ImageLevelInferences?start_day_interval={start_day}&amp;current_batch_day={end_day}");<br/>
        /// var request = new RestRequest(Method.GET);<br/>
        /// request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("[[.ApiKey]]:")));<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> OcrPredictGetFileAsync(
            string modelId,
            int startDayInterval,
            int currentBatchDay,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}