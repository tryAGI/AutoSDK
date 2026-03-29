//HintName: G.ITraceClient.LogCustomTraceLegacy.g.cs
#nullable enable

namespace G
{
    public partial interface ITraceClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task LogCustomTraceLegacyAsync(

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task LogCustomTraceLegacyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}