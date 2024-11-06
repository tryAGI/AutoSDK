//HintName: G.ICustomModelsClient.V1DeleteCustomModel.g.cs
#nullable enable

namespace G
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Delete Model
        /// </summary>
        /// <param name="modelPid"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1DeleteCustomModelAsync(
            string modelPid,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}