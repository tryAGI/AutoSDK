//HintName: G.Models.CustomChartPreviewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartPreviewRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomChartsRequestBase BucketInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomChartCreatePreview Chart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartPreviewRequest" /> class.
        /// </summary>
        /// <param name="bucketInfo"></param>
        /// <param name="chart"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartPreviewRequest(
            global::G.CustomChartsRequestBase bucketInfo,
            global::G.CustomChartCreatePreview chart)
        {
            this.BucketInfo = bucketInfo ?? throw new global::System.ArgumentNullException(nameof(bucketInfo));
            this.Chart = chart ?? throw new global::System.ArgumentNullException(nameof(chart));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartPreviewRequest" /> class.
        /// </summary>
        public CustomChartPreviewRequest()
        {
        }
    }
}