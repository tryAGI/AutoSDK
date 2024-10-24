//HintName: G.ICustomModelsClient.V1GetCustomModels.g.cs
#nullable enable

namespace G
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Get Custom Models List
        /// </summary>
        /// <param name="includeMetadata">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1GetCustomModelsAsync(
            bool? includeMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}