//HintName: G.IPublicClient.GetMessageJsonSchema.g.cs
#nullable enable

namespace G
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Get Message Json Schema
        /// </summary>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetMessageJsonSchemaAsync(
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}