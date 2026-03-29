//HintName: G.IProviderResourcesClient.ProviderResourceControllerGetProviderResourcesPaginated.g.cs
#nullable enable

namespace G
{
    public partial interface IProviderResourcesClient
    {
        /// <summary>
        /// List Provider Resources
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="resourceName"></param>
        /// <param name="id"></param>
        /// <param name="resourceId"></param>
        /// <param name="page"></param>
        /// <param name="sortOrder"></param>
        /// <param name="limit"></param>
        /// <param name="createdAtGt"></param>
        /// <param name="createdAtLt"></param>
        /// <param name="createdAtGe"></param>
        /// <param name="createdAtLe"></param>
        /// <param name="updatedAtGt"></param>
        /// <param name="updatedAtLt"></param>
        /// <param name="updatedAtGe"></param>
        /// <param name="updatedAtLe"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProviderResourcePaginatedResponse> ProviderResourceControllerGetProviderResourcesPaginatedAsync(
            global::G.ProviderResourceControllerGetProviderResourcesPaginatedProvider provider,
            global::G.ProviderResourceControllerGetProviderResourcesPaginatedResourceName resourceName,
            string? id = default,
            string? resourceId = default,
            double? page = default,
            global::G.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder? sortOrder = default,
            double? limit = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? createdAtGe = default,
            global::System.DateTime? createdAtLe = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLt = default,
            global::System.DateTime? updatedAtGe = default,
            global::System.DateTime? updatedAtLe = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}