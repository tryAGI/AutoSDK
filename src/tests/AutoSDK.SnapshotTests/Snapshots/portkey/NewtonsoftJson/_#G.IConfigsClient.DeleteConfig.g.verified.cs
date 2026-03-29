//HintName: G.IConfigsClient.DeleteConfig.g.cs
#nullable enable

namespace G
{
    public partial interface IConfigsClient
    {
        /// <summary>
        /// Delete a config
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteConfigAsync(
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}