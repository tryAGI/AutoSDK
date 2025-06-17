//HintName: G.Models.UpdateFinetunedModelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFinetunedModelRequest
    {
        /// <summary>
        /// Timestamp for the completed fine-tuning.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Creation timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// User ID of the creator.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// Deprecated: Timestamp for the latest request to this fine-tuned model.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used")]
        public global::System.DateTime? LastUsed { get; set; }

        /// <summary>
        /// FinetunedModel name (e.g. `foobar`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Organization ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// The configuration used for fine-tuning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Settings Settings { get; set; }

        /// <summary>
        /// The possible stages of a fine-tuned model life-cycle.<br/>
        ///  - STATUS_UNSPECIFIED: Unspecified status.<br/>
        ///  - STATUS_FINETUNING: The fine-tuned model is being fine-tuned.<br/>
        ///  - STATUS_DEPLOYING_API: Deprecated: The fine-tuned model is being deployed.<br/>
        ///  - STATUS_READY: The fine-tuned model is ready to receive requests.<br/>
        ///  - STATUS_FAILED: The fine-tuned model failed.<br/>
        ///  - STATUS_DELETED: The fine-tuned model was deleted.<br/>
        ///  - STATUS_TEMPORARILY_OFFLINE: Deprecated: The fine-tuned model is temporarily unavailable.<br/>
        ///  - STATUS_PAUSED: Deprecated: The fine-tuned model is paused (Vanilla only).<br/>
        ///  - STATUS_QUEUED: The fine-tuned model is queued for training.<br/>
        /// Default Value: STATUS_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StatusJsonConverter))]
        public global::G.Status? Status { get; set; }

        /// <summary>
        /// Latest update timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFinetunedModelRequest" /> class.
        /// </summary>
        /// <param name="completedAt">
        /// Timestamp for the completed fine-tuning.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creatorId">
        /// User ID of the creator.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastUsed">
        /// Deprecated: Timestamp for the latest request to this fine-tuned model.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// FinetunedModel name (e.g. `foobar`).
        /// </param>
        /// <param name="organizationId">
        /// Organization ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="settings">
        /// The configuration used for fine-tuning.
        /// </param>
        /// <param name="status">
        /// The possible stages of a fine-tuned model life-cycle.<br/>
        ///  - STATUS_UNSPECIFIED: Unspecified status.<br/>
        ///  - STATUS_FINETUNING: The fine-tuned model is being fine-tuned.<br/>
        ///  - STATUS_DEPLOYING_API: Deprecated: The fine-tuned model is being deployed.<br/>
        ///  - STATUS_READY: The fine-tuned model is ready to receive requests.<br/>
        ///  - STATUS_FAILED: The fine-tuned model failed.<br/>
        ///  - STATUS_DELETED: The fine-tuned model was deleted.<br/>
        ///  - STATUS_TEMPORARILY_OFFLINE: Deprecated: The fine-tuned model is temporarily unavailable.<br/>
        ///  - STATUS_PAUSED: Deprecated: The fine-tuned model is paused (Vanilla only).<br/>
        ///  - STATUS_QUEUED: The fine-tuned model is queued for training.<br/>
        /// Default Value: STATUS_UNSPECIFIED
        /// </param>
        /// <param name="updatedAt">
        /// Latest update timestamp.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFinetunedModelRequest(
            string name,
            global::G.Settings settings,
            global::System.DateTime? completedAt,
            global::System.DateTime? createdAt,
            string? creatorId,
            global::System.DateTime? lastUsed,
            string? organizationId,
            global::G.Status? status,
            global::System.DateTime? updatedAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.CreatorId = creatorId;
            this.LastUsed = lastUsed;
            this.OrganizationId = organizationId;
            this.Status = status;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFinetunedModelRequest" /> class.
        /// </summary>
        public UpdateFinetunedModelRequest()
        {
        }
    }
}