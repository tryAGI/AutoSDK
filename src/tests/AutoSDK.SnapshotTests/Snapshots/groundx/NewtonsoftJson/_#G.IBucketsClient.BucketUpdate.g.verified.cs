//HintName: G.IBucketsClient.BucketUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// update<br/>
        /// Rename a bucket.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="bucketId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BucketUpdateResponse> BucketUpdateAsync(
            int bucketId,

            global::G.BucketUpdateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// update<br/>
        /// Rename a bucket.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="bucketId"></param>
        /// <param name="newName">
        /// The new name of the bucket being renamed.<br/>
        /// Example: your_bucket_name
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BucketUpdateResponse> BucketUpdateAsync(
            int bucketId,
            string newName,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}