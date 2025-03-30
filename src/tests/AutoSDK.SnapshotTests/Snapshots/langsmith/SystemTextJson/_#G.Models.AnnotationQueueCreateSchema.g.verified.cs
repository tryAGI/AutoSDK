//HintName: G.Models.AnnotationQueueCreateSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AnnotationQueue schema.
    /// </summary>
    public sealed partial class AnnotationQueueCreateSchema
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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_dataset")]
        public global::System.Guid? DefaultDataset { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_reviewers_per_item")]
        public int? NumReviewersPerItem { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_reservations")]
        public bool? EnableReservations { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reservation_minutes")]
        public int? ReservationMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rubric_items")]
        public global::System.Collections.Generic.IList<global::G.AnnotationQueueRubricItemSchema>? RubricItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rubric_instructions")]
        public string? RubricInstructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? SessionIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueCreateSchema" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="defaultDataset"></param>
        /// <param name="numReviewersPerItem">
        /// Default Value: 1
        /// </param>
        /// <param name="enableReservations">
        /// Default Value: true
        /// </param>
        /// <param name="reservationMinutes">
        /// Default Value: 1
        /// </param>
        /// <param name="id"></param>
        /// <param name="rubricItems"></param>
        /// <param name="rubricInstructions"></param>
        /// <param name="sessionIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueCreateSchema(
            string name,
            string? description,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Guid? defaultDataset,
            int? numReviewersPerItem,
            bool? enableReservations,
            int? reservationMinutes,
            global::System.Guid? id,
            global::System.Collections.Generic.IList<global::G.AnnotationQueueRubricItemSchema>? rubricItems,
            string? rubricInstructions,
            global::System.Collections.Generic.IList<global::System.Guid>? sessionIds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DefaultDataset = defaultDataset;
            this.NumReviewersPerItem = numReviewersPerItem;
            this.EnableReservations = enableReservations;
            this.ReservationMinutes = reservationMinutes;
            this.Id = id;
            this.RubricItems = rubricItems;
            this.RubricInstructions = rubricInstructions;
            this.SessionIds = sessionIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueCreateSchema" /> class.
        /// </summary>
        public AnnotationQueueCreateSchema()
        {
        }
    }
}