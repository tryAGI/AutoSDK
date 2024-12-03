//HintName: G.Models.IdentityAnnotationQueueRunStatusCreateSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identity annotation queue run status create schema.
    /// </summary>
    public sealed partial class IdentityAnnotationQueueRunStatusCreateSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_added_at")]
        public global::System.DateTime? OverrideAddedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityAnnotationQueueRunStatusCreateSchema" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="overrideAddedAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public IdentityAnnotationQueueRunStatusCreateSchema(
            string? status,
            global::System.DateTime? overrideAddedAt)
        {
            this.Status = status;
            this.OverrideAddedAt = overrideAddedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityAnnotationQueueRunStatusCreateSchema" /> class.
        /// </summary>
        public IdentityAnnotationQueueRunStatusCreateSchema()
        {
        }
    }
}