//HintName: G.Models.FeedbackScorePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aggregated feedback scores from all spans in this trace, averaged by score name<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class FeedbackScorePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_name")]
        public string? CategoryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FeedbackScorePublicSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FeedbackScorePublicSource Source { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_by_author")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ValueEntryPublic>? ValueByAuthor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackScorePublic" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="source"></param>
        /// <param name="categoryName"></param>
        /// <param name="reason"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="valueByAuthor">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackScorePublic(
            string name,
            double value,
            global::G.FeedbackScorePublicSource source,
            string? categoryName,
            string? reason,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            string? createdBy,
            string? lastUpdatedBy,
            global::System.Collections.Generic.Dictionary<string, global::G.ValueEntryPublic>? valueByAuthor)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CategoryName = categoryName;
            this.Value = value;
            this.Reason = reason;
            this.Source = source;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedBy = lastUpdatedBy;
            this.ValueByAuthor = valueByAuthor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackScorePublic" /> class.
        /// </summary>
        public FeedbackScorePublic()
        {
        }
    }
}