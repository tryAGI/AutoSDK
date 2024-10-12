//HintName: G.ICustomModelsClient.V1GetCustomModel.g.cs
#nullable enable

namespace G
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Get Custom Model
        /// </summary>
        /// <param name="customModelPid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1GetCustomModelAsync(
            string customModelPid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}