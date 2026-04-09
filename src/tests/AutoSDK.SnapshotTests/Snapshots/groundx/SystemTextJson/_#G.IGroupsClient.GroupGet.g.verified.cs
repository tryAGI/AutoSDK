//HintName: G.IGroupsClient.GroupGet.g.cs
#nullable enable

namespace G
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// get<br/>
        /// look up a specific group by its groupId.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GroupResponse> GroupGetAsync(
            int groupId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}