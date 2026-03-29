//HintName: G.IIcUploadClient.IcUploadFile.g.cs
#nullable enable

namespace G
{
    public partial interface IIcUploadClient
    {
        /// <summary>
        /// Upload Training Images by File<br/>
        /// Upload a training image to the specified model using a locally stored file.<br/>
        /// On successful upload, model information along with the total number of images per category will be received.<br/>
        /// &lt;br /&gt;<br/>
        /// **NOTE**: Batch file uploads are not supported by this end point.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/ImageCategorization/UploadFile/");<br/>
        /// var request = new RestRequest(Method.POST);<br/>
        /// request.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("[[.ApiKey]]:")));<br/>
        /// request.AddHeader("Accept", "multipart/form-data");<br/>
        /// request.AddParameter("modelId", "REPLACE_MODEL_ID");<br/>
        /// request.AddParameter("category", "category1");<br/>
        /// request.AddFile("file", "REPLACE_IMAGE_PATH.jpg");<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> IcUploadFileAsync(

            global::G.IcUploadFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Training Images by File<br/>
        /// Upload a training image to the specified model using a locally stored file.<br/>
        /// On successful upload, model information along with the total number of images per category will be received.<br/>
        /// &lt;br /&gt;<br/>
        /// **NOTE**: Batch file uploads are not supported by this end point.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model on which the operation is to be performed.<br/>
        /// It can be found in the model settings.<br/>
        /// &lt;br /&gt;<br/>
        /// **Eg**: `0a0aa000-0000-0a0-aa00-000a0000000a`
        /// </param>
        /// <param name="category">
        /// TBD
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
        global::System.Threading.Tasks.Task<string> IcUploadFileAsync(
            string modelId,
            string category,
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}