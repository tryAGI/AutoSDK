//HintName: G.Models.PartialExperimentHypothesisRunToOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialExperimentHypothesisRunToOperator
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_request_id")]
        public global::G.PartialTextOperators? ResultRequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialExperimentHypothesisRunToOperator" /> class.
        /// </summary>
        /// <param name="resultRequestId">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialExperimentHypothesisRunToOperator(
            global::G.PartialTextOperators? resultRequestId)
        {
            this.ResultRequestId = resultRequestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialExperimentHypothesisRunToOperator" /> class.
        /// </summary>
        public PartialExperimentHypothesisRunToOperator()
        {
        }
    }
}