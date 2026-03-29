//HintName: G.Models.ValueEntryExperimentItemBulkWriteView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class ValueEntryExperimentItemBulkWriteView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_name")]
        public string? CategoryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ValueEntryExperimentItemBulkWriteViewSourceJsonConverter))]
        public global::G.ValueEntryExperimentItemBulkWriteViewSource? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_type")]
        public string? SpanType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        public string? SpanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueEntryExperimentItemBulkWriteView" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="reason"></param>
        /// <param name="categoryName"></param>
        /// <param name="source"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="spanType"></param>
        /// <param name="spanId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValueEntryExperimentItemBulkWriteView(
            double? value,
            string? reason,
            string? categoryName,
            global::G.ValueEntryExperimentItemBulkWriteViewSource? source,
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
        /// Initializes a new instance of the <see cref="ValueEntryExperimentItemBulkWriteView" /> class.
        /// </summary>
        public ValueEntryExperimentItemBulkWriteView()
        {
        }
    }
}