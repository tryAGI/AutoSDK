//HintName: G.IGroupsClient.GroupRemoveBucket.g.cs
#nullable enable

namespace G
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// removeBucket<br/>
        /// remove a bucket from a group. Buckets and groups can be associated many to many, this removes one bucket to group association without disturbing others.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="bucketId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MessageResponse> GroupRemoveBucketAsync(
            int groupId,
            int bucketId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}