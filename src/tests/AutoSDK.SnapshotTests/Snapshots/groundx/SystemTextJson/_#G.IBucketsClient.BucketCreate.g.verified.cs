//HintName: G.IBucketsClient.BucketCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// create<br/>
        /// Create a new bucket.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BucketResponse> BucketCreateAsync(

            global::G.BucketCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// create<br/>
        /// Create a new bucket.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="name">
        /// Example: your_bucket_name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BucketResponse> BucketCreateAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}