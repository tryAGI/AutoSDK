//HintName: G.IMetadataClient.MetadataGetUser.g.cs
#nullable enable

namespace G
{
    public partial interface IMetadataClient
    {
        /// <summary>
        /// Get current user information<br/>
        /// Retrieve information about the current authenticated user including email, name, organization, and current project.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MetadataGetUserResponse> MetadataGetUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}