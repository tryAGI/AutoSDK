//HintName: G.IOcrUploadClient.OcrUploadFile.g.cs
#nullable enable

namespace G
{
    public partial interface IOcrUploadClient
    {
        /// <summary>
        /// Upload Training Images by File<br/>
        /// Upload a training image to the specified model using a locally stored file.<br/>
        /// On successful upload, model information along with the total number of images per category will be received.<br/>
        /// &lt;br /&gt;<br/>
        /// &lt;br /&gt;<br/>
        /// **NOTE**: Batch file uploads are not supported by this end point.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/OCR/UploadFile/");<br/>
        /// var request = new RestRequest(Method.POST);<br/>
        /// request.AddHeader("Authorization", "Basic [[.ApiKey]]");<br/>
        /// request.AddHeader("Accept", "multipart/form-data");<br/>
        /// request.AddParameter("data", "[{\"filename\":\"REPLACE_IMAGE_FILENAME.jpg\", \"object\": [{\"name\":\"category1\", \"ocr_text\":\"text inside the bounding box\", \"bndbox\": {\"xmin\": 1,\"ymin\": 1,\"xmax\": 100, \"ymax\": 100}}]}]");<br/>
        /// request.AddFile("file", "REPLACE_IMAGE_PATH.jpg");<br/>
        /// IRestResponse response = client.Execute(request);"
        /// </remarks>
        global::System.Threading.Tasks.Task<string> OcrUploadFileAsync(
            string modelId,

            global::G.OcrUploadFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Training Images by File<br/>
        /// Upload a training image to the specified model using a locally stored file.<br/>
        /// On successful upload, model information along with the total number of images per category will be received.<br/>
        /// &lt;br /&gt;<br/>
        /// &lt;br /&gt;<br/>
        /// **NOTE**: Batch file uploads are not supported by this end point.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="data">
        /// The name of the file to be uploaded.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: `"data": "[{"filename": "filename.ext"}]"`.<br/>
        /// &lt;br /&gt;<br/>
        /// **NOTE**: The `filename` must be the same as the uploaded file name.
        /// </param>
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
        global::System.Threading.Tasks.Task<string> OcrUploadFileAsync(
            string modelId,
            string data,
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}