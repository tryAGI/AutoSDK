//HintName: G.Models.KpiCardRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KpiCardRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.KpiCardRequestEntityTypeJsonConverter))]
        public global::G.KpiCardRequestEntityType EntityType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public string? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval_start", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime IntervalStart { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval_end", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime IntervalEnd { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KpiCardRequest" /> class.
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="filters"></param>
        public KpiCardRequest(
            global::G.KpiCardRequestEntityType entityType,
            global::System.DateTime intervalStart,
            global::System.DateTime intervalEnd,
            string? filters)
        {
            this.EntityType = entityType;
            this.Filters = filters;
            this.IntervalStart = intervalStart;
            this.IntervalEnd = intervalEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KpiCardRequest" /> class.
        /// </summary>
        public KpiCardRequest()
        {
        }
    }
}