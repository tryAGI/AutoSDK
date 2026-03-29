//HintName: G.IDistributedClient.ListShardKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// List shard keys
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListShardKeysResponse> ListShardKeysAsync(
            string collectionName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}