//HintName: G.IApi.TunedModelsPermissionsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="permissionsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Permission> TunedModelsPermissionsGetAsync(
            string tunedModelsId,
            string permissionsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}