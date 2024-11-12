//HintName: G.IApi.ListTunedModelOperations.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method, it returns `UNIMPLEMENTED`.
        /// </summary>
        /// <param name="tunedModelId"></param>
        /// <param name="pageSize"></param>
        /// <param name="filter"></param>
        /// <param name="pageToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListOperationsResponse> ListTunedModelOperationsAsync(
            string tunedModelId,
            int? pageSize = default,
            string? filter = default,
            string? pageToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}