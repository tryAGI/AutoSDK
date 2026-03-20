//HintName: G.IPublicClient.GetToolDefJsonSchema.g.cs
#nullable enable

namespace G
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Get Tool Def Json Schema
        /// </summary>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetToolDefJsonSchemaAsync(
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}