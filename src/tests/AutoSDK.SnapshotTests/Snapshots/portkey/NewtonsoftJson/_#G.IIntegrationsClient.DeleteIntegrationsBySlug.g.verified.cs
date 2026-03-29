//HintName: G.IIntegrationsClient.DeleteIntegrationsBySlug.g.cs
#nullable enable

namespace G
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Delete a Integration
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteIntegrationsBySlugAsync(
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}