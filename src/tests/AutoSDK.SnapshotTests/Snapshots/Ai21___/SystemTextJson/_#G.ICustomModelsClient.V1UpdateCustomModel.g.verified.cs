//HintName: G.ICustomModelsClient.V1UpdateCustomModel.g.cs
#nullable enable

namespace G
{
    public partial interface ICustomModelsClient
    {
        /// <summary>
        /// Update Model
        /// </summary>
        /// <param name="customModelPid"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1UpdateCustomModelAsync(
            string customModelPid,
            global::G.CustomModelUpdateBody request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Model
        /// </summary>
        /// <param name="customModelPid"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="defaultEpoch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1UpdateCustomModelAsync(
            string customModelPid,
            int? requestStartTime = default,
            int? defaultEpoch = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}