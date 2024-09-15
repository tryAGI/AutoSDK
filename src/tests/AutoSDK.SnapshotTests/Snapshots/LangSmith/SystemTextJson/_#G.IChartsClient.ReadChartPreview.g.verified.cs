//HintName: G.IChartsClient.ReadChartPreview.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Read Chart Preview<br/>
        /// Get a preview for a chart without actually creating it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SingleCustomChartResponseBase> ReadChartPreviewAsync(
            global::G.CustomChartPreviewRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Read Chart Preview<br/>
        /// Get a preview for a chart without actually creating it.
        /// </summary>
        /// <param name="bucketInfo"></param>
        /// <param name="chart"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SingleCustomChartResponseBase> ReadChartPreviewAsync(
            global::G.CustomChartsRequestBase bucketInfo,
            global::G.CustomChartCreatePreview chart,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}