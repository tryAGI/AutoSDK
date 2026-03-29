//HintName: G.IOcrPredictClient.OcrPredictFile.g.cs
#nullable enable

namespace G
{
    public partial interface IOcrPredictClient
    {
        /// <summary>
        /// Prediction for Image File<br/>
        /// Given an image file, extract data as per the label(s) specified in the model.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/OCR/Model/{{model_id}}/LabelFile/");<br/>
        /// var request = new RestRequest(Method.POST);<br/>
        /// request.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("[[.ApiKey]]:")));<br/>
        /// request.AddHeader("Accept", "multipart/form-data");<br/>
        /// request.AddFile("file", "REPLACE_IMAGE_PATH.jpg");<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> OcrPredictFileAsync(
            string modelId,

            global::G.OcrPredictFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prediction for Image File<br/>
        /// Given an image file, extract data as per the label(s) specified in the model.
        /// </summary>
        /// <param name="modelId"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OcrPredictFileAsync(
            string modelId,
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}