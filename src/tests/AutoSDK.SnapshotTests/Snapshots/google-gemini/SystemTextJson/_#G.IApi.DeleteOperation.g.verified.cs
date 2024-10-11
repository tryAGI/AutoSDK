//HintName: G.IApi.DeleteOperation.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the operation result. It does not cancel the operation. If the server doesn't support this method, it returns `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<object> DeleteOperationAsync(
            string operationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}