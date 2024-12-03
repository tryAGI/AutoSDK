//HintName: G.ISegmentationClient.V1Segmentation.g.cs
#nullable enable

namespace G
{
    public partial interface ISegmentationClient
    {
        /// <summary>
        /// Segmentation
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentationResponse> V1SegmentationAsync(
            global::G.SegmentationBody request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Segmentation
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="sourceType">
        /// An enumeration.
        /// </param>
        /// <param name="source"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentationResponse> V1SegmentationAsync(
            global::G.DocumentType sourceType,
            string source,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}