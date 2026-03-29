//HintName: G.Models.ValueEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class ValueEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public double? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category_name")]
        public string? CategoryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.ValueEntrySource? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_type")]
        public string? SpanType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_id")]
        public string? SpanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueEntry" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="reason"></param>
        /// <param name="categoryName"></param>
        /// <param name="source"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="spanType"></param>
        /// <param name="spanId"></param>
        public ValueEntry(
            double? value,
            string? reason,
            string? categoryName,
            global::G.ValueEntrySource? source,
            global::System.DateTime? lastUpdatedAt,
            string? spanType,
            string? spanId)
        {
            this.Value = value;
            this.Reason = reason;
            this.CategoryName = categoryName;
            this.Source = source;
            this.LastUpdatedAt = lastUpdatedAt;
            this.SpanType = spanType;
            this.SpanId = spanId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueEntry" /> class.
        /// </summary>
        public ValueEntry()
        {
        }
    }
}