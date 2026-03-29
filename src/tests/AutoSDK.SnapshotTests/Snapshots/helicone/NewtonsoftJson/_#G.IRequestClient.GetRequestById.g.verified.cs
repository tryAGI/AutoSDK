//HintName: G.IRequestClient.GetRequestById.g.cs
#nullable enable

namespace G
{
    public partial interface IRequestClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="includeBody">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultHeliconeRequestString> GetRequestByIdAsync(
            string requestId,
            bool? includeBody = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}