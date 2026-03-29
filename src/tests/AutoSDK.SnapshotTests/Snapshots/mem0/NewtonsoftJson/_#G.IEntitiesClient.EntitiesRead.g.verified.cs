//HintName: G.IEntitiesClient.EntitiesRead.g.cs
#nullable enable

namespace G
{
    public partial interface IEntitiesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task EntitiesReadAsync(
            global::G.EntitiesReadEntityType entityType,
            string entityId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}