//HintName: G.IApi.CorporaPermissionsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="permissionsId"></param>
        /// <param name="corporaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Empty> CorporaPermissionsDeleteAsync(
            string permissionsId,
            string corporaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}