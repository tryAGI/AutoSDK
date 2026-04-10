//HintName: G.IOrganizations2Client.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizations2Client
    {
        /// <summary>
        /// Get organization settings<br/>
        /// Retrieve the settings for a specific organization by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseOrganization> GetAsync(
            int id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}