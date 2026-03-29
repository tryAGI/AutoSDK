//HintName: G.IIcUploadClient.IcUploadUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IIcUploadClient
    {
        /// <summary>
        /// Upload Training Images by URLs<br/>
        /// Upload training images to a model using image URLs.<br/>
        /// Multiple images can be uploaded in the same request by adding more URLs in the `urls` array.<br/>
        /// On successful upload, model information along with the total number of images per category will be received.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// var client = new RestClient("https://app.nanonets.com/api/v2/ImageCategorization/UploadUrls/");<br/>
        /// var request = new RestRequest(Method.POST);<br/>
        /// request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("[[.ApiKey]]:")));<br/>
        /// request.AddHeader("accept", "application/x-www-form-urlencoded");<br/>
        /// request.AddParameter("modelId", "REPLACE_MODEL_ID");<br/>
        /// request.AddParameter("category", "category1");<br/>
        /// request.AddParameter("urls", "https://nanonets.s3-us-west-2.amazonaws.com/test-images/test1.jpg");<br/>
        /// IRestResponse response = client.Execute(request);
        /// </remarks>
        global::System.Threading.Tasks.Task<string> IcUploadUrlAsync(

            global::G.IcUploadUrlRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Training Images by URLs<br/>
        /// Upload training images to a model using image URLs.<br/>
        /// Multiple images can be uploaded in the same request by adding more URLs in the `urls` array.<br/>
        /// On successful upload, model information along with the total number of images per category will be received.
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
        /// <param name="urls">
        /// Array of URLs of the training files.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG and/or PDF
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> IcUploadUrlAsync(
            string modelId,
            string category,
            string urls,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}