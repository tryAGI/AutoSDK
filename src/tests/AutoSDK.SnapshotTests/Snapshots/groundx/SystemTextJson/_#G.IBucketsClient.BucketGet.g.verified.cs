//HintName: G.IBucketsClient.BucketGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// get<br/>
        /// Look up a specific bucket by its bucketId.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="bucketId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BucketResponse> BucketGetAsync(
            int bucketId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}