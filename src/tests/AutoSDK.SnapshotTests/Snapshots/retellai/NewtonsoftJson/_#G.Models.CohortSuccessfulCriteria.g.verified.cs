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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CohortSuccessfulCriteriaTypeJsonConverter))]
        public global::G.CohortSuccessfulCriteriaType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CohortSuccessfulCriteriaOpJsonConverter))]
        public global::G.CohortSuccessfulCriteriaOp Op { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortSuccessfulCriteria" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="op"></param>
        /// <param name="type">
        /// Type of the filter
        /// </param>
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