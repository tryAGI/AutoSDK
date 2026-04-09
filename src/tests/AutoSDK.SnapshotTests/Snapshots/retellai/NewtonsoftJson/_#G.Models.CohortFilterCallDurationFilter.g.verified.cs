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
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CohortFilterCallDurationFilterOpJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.CohortFilterCallDurationFilterOp Op { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortFilterCallDurationFilter" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="op"></param>
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