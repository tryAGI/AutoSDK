//HintName: G.IScimClient.ScimGetResourceTypes.g.cs
#nullable enable

namespace G
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get SCIM Resource Types (requires organization-scoped API key)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResourceTypesResponse> ScimGetResourceTypesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}