//HintName: G.IApi.CorporaPermissionsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="permissionsId"></param>
        /// <param name="corporaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Permission> CorporaPermissionsGetAsync(
            string permissionsId,
            string corporaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}