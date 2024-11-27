//HintName: G.IResourceClient.IsResourceVideoConversionComplete.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// IsResourceVideoConversionComplete<br/>
        /// IsResourceVideoConversionComplete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> IsResourceVideoConversionCompleteAsync(
            global::G.IsResourceVideoConversionCompleteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// IsResourceVideoConversionComplete<br/>
        /// IsResourceVideoConversionComplete
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> IsResourceVideoConversionCompleteAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}