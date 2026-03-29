//HintName: G.Models.QuantizationSearchParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional parameters of the search
    /// </summary>
    public sealed partial class QuantizationSearchParams
    {
        /// <summary>
        /// If true, quantized vectors are ignored. Default is false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore")]
        public bool? Ignore { get; set; }

        /// <summary>
        /// If true, use original vectors to re-score top-k results. Might require more time in case if original vectors are stored on disk. If not set, qdrant decides automatically apply rescoring or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rescore")]
        public bool? Rescore { get; set; }

        /// <summary>
        /// Oversampling factor for quantization. Default is 1.0.<br/>
        /// Defines how many extra vectors should be preselected using quantized index, and then re-scored using original vectors.<br/>
        /// For example, if `oversampling` is 2.4 and `limit` is 100, then 240 vectors will be preselected using quantized index, and then top-100 will be returned after re-scoring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oversampling")]
        public double? Oversampling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationSearchParams" /> class.
        /// </summary>
        /// <param name="ignore">
        /// If true, quantized vectors are ignored. Default is false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="rescore">
        /// If true, use original vectors to re-score top-k results. Might require more time in case if original vectors are stored on disk. If not set, qdrant decides automatically apply rescoring or not.
        /// </param>
        /// <param name="oversampling">
        /// Oversampling factor for quantization. Default is 1.0.<br/>
        /// Defines how many extra vectors should be preselected using quantized index, and then re-scored using original vectors.<br/>
        /// For example, if `oversampling` is 2.4 and `limit` is 100, then 240 vectors will be preselected using quantized index, and then top-100 will be returned after re-scoring.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuantizationSearchParams(
            bool? ignore,
            bool? rescore,
            double? oversampling)
        {
            this.Ignore = ignore;
            this.Rescore = rescore;
            this.Oversampling = oversampling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizationSearchParams" /> class.
        /// </summary>
        public QuantizationSearchParams()
        {
        }
    }
}