//HintName: G.IIngestClient.GetUploadSignedUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IIngestClient
    {
        /// <summary>
        /// Direct Upload<br/>
        /// Request a signed URL to upload a file to. The response returns a signed URL that you use to upload the file to.<br/>
        /// The signed URL looks similar to:<br/>
        /// https://shotstack-ingest-api-stage-sources.s3.ap-southeast-2.amazonaws.com/5ca6hu7s9k/zzytey4v-32km-kq1z-aftr-3kcuqi0brad2/source?AWSAccessKeyId=ASIAWJV7UWDMGTZLHTXP&amp;Expires=1677209777&amp;Signature=PKR4dGDDdOuMTAQmDASzLGmLOeo%3D&amp;x-amz-acl=public-read&amp;x-amz-security-token=IQoJb3JpZ2luX2VjEGMaDmFwLX......56osBGByztm7WZdbmXzO09KR<br/>
        /// In a separate API call, use this signed URL to send a PUT request with the binary file. Using  cURL you can use<br/>
        /// a command like:<br/>
        ///     <br/>
        /// `curl -X PUT -T video.mp4 {data.attributes.url}`<br/>
        ///     <br/>
        /// Where **video.mp4** is the file you want to upload and **{data.attributes.url}** is the signed URL returned in<br/>
        /// the response. The request must be a PUT type.<br/>
        /// The SDK does not currently support the PUT request. You can use the SDK to make the request for the signed URL<br/>
        /// and then use cURL to make the PUT request.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/ingest/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadResponse> GetUploadSignedUrlAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}