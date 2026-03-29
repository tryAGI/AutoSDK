//HintName: G.IConfigsClient.DeleteConfig.g.cs
#nullable enable

namespace G
{
    public partial interface IConfigsClient
    {
        /// <summary>
        /// Delete an EVI config
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteConfigAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}