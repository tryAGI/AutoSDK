//HintName: G.IProvidersClient.DeleteProvidersBySlug.g.cs
#nullable enable

namespace G
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Delete a Provider
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteProvidersBySlugAsync(
            string slug,
            string? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}