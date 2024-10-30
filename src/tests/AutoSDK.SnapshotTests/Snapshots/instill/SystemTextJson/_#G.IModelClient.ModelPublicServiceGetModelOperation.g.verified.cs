//HintName: G.IModelClient.ModelPublicServiceGetModelOperation.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get the details of a long-running operation<br/>
        /// This method allows requesters to request the status and outcome of<br/>
        /// long-running operations in a model, such as trigger.
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetModelOperationResponse> ModelPublicServiceGetModelOperationAsync(
            string operationId,
            global::G.ModelPublicServiceGetModelOperationView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}