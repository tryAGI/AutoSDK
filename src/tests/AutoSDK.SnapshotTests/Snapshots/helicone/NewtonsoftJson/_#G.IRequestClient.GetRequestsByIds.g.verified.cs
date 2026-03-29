//HintName: G.IRequestClient.GetRequestsByIds.g.cs
#nullable enable

namespace G
{
    public partial interface IRequestClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultHeliconeRequestArrayString> GetRequestsByIdsAsync(

            global::G.GetRequestsByIdsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultHeliconeRequestArrayString> GetRequestsByIdsAsync(
            global::System.Collections.Generic.IList<string> requestIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}