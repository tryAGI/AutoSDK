//HintName: G.Models.NumericalFeedbackDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NumericalFeedbackDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Max { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Min { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericalFeedbackDetail" /> class.
        /// </summary>
        /// <param name="max"></param>
        /// <param name="min"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumericalFeedbackDetail(
            double max,
            double min)
        {
            this.Max = max;
            this.Min = min;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericalFeedbackDetail" /> class.
        /// </summary>
        public NumericalFeedbackDetail()
        {
        }
    }
}