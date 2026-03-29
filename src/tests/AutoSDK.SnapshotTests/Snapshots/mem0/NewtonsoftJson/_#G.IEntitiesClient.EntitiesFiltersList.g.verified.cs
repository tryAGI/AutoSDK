//HintName: G.IEntitiesClient.EntitiesFiltersList.g.cs
#nullable enable

namespace G
{
    public partial interface IEntitiesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task EntitiesFiltersListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}