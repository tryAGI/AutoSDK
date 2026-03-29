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
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.KpiCardRequestEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.KpiCardRequestEntityType EntityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public string? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime IntervalStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime IntervalEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KpiCardRequest" /> class.
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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