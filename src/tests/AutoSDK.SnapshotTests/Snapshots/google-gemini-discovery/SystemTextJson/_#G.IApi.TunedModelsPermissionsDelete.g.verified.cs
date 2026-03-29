//HintName: G.IApi.TunedModelsPermissionsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="permissionsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Empty> TunedModelsPermissionsDeleteAsync(
            string tunedModelsId,
            string permissionsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}