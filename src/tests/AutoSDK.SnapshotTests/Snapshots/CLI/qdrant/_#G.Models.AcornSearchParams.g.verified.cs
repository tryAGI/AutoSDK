//HintName: G.Models.AcornSearchParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ACORN-related search parameters
    /// </summary>
    public sealed partial class AcornSearchParams
    {
        /// <summary>
        /// If true, then ACORN may be used for the HNSW search based on filters selectivity. Improves search recall for searches with multiple low-selectivity payload filters, at cost of performance.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Maximum selectivity of filters to enable ACORN.<br/>
        /// If estimated filters selectivity is higher than this value, ACORN will not be used. Selectivity is estimated as: `estimated number of points satisfying the filters / total number of points`.<br/>
        /// 0.0 for never, 1.0 for always. Default is 0.4.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_selectivity")]
        public double? MaxSelectivity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcornSearchParams" /> class.
        /// </summary>
        /// <param name="enable">
        /// If true, then ACORN may be used for the HNSW search based on filters selectivity. Improves search recall for searches with multiple low-selectivity payload filters, at cost of performance.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxSelectivity">
        /// Maximum selectivity of filters to enable ACORN.<br/>
        /// If estimated filters selectivity is higher than this value, ACORN will not be used. Selectivity is estimated as: `estimated number of points satisfying the filters / total number of points`.<br/>
        /// 0.0 for never, 1.0 for always. Default is 0.4.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcornSearchParams(
            bool? enable,
            double? maxSelectivity)
        {
            this.Enable = enable;
            this.MaxSelectivity = maxSelectivity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcornSearchParams" /> class.
        /// </summary>
        public AcornSearchParams()
        {
        }
    }
}