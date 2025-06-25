//HintName: G.IApi.GetTunedModelOperation.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result at intervals as recommended by the API service.
        /// </summary>
        /// <param name="tunedModelId"></param>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Operation> GetTunedModelOperationAsync(
            string tunedModelId,
            string operationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}