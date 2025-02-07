//HintName: G.Models.AnnotationQueueRunUpdateSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationQueueRunUpdateSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_reviewed_time")]
        public global::System.DateTime? LastReviewedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        public global::System.DateTime? AddedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueRunUpdateSchema" /> class.
        /// </summary>
        /// <param name="lastReviewedTime"></param>
        /// <param name="addedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueRunUpdateSchema(
            global::System.DateTime? lastReviewedTime,
            global::System.DateTime? addedAt)
        {
            this.LastReviewedTime = lastReviewedTime;
            this.AddedAt = addedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueRunUpdateSchema" /> class.
        /// </summary>
        public AnnotationQueueRunUpdateSchema()
        {
        }
    }
}