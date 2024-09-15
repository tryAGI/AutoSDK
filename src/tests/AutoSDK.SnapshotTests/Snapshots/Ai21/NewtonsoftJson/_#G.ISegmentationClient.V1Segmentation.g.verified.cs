//HintName: G.ISegmentationClient.V1Segmentation.g.cs
#nullable enable

namespace G
{
    public partial interface ISegmentationClient
    {
        /// <summary>
        /// Segmentation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentationResponse> V1SegmentationAsync(
            global::G.SegmentationBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Segmentation
        /// </summary>
        /// <param name="sourceType">
        /// An enumeration.
        /// </param>
        /// <param name="source"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SegmentationResponse> V1SegmentationAsync(
            global::G.DocumentType sourceType,
            string source,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}