//HintName: G.Models.CohortFilterCallDurationFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated: use 'duration_ms' instead.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class CohortFilterCallDurationFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required double Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CohortFilterCallDurationFilterOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::G.CohortFilterCallDurationFilterOp Op { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortFilterCallDurationFilter" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="op"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CohortFilterCallDurationFilter(
            double value,
            global::G.CohortFilterCallDurationFilterOp op)
        {
            this.Value = value;
            this.Op = op;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortFilterCallDurationFilter" /> class.
        /// </summary>
        public CohortFilterCallDurationFilter()
        {
        }
    }
}