//HintName: G.Models.CohortSuccessfulCriteria.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CohortSuccessfulCriteria
    {
        /// <summary>
        /// Type of the filter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CohortSuccessfulCriteriaTypeJsonConverter))]
        public global::G.CohortSuccessfulCriteriaType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CohortSuccessfulCriteriaOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CohortSuccessfulCriteriaOp Op { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortSuccessfulCriteria" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="op"></param>
        /// <param name="type">
        /// Type of the filter
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CohortSuccessfulCriteria(
            double value,
            global::G.CohortSuccessfulCriteriaOp op,
            global::G.CohortSuccessfulCriteriaType? type)
        {
            this.Type = type;
            this.Value = value;
            this.Op = op;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortSuccessfulCriteria" /> class.
        /// </summary>
        public CohortSuccessfulCriteria()
        {
        }
    }
}