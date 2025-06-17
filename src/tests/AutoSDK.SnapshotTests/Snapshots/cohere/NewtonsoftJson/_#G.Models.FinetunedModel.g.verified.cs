//HintName: G.Models.FinetunedModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This resource represents a fine-tuned model.
    /// </summary>
    public sealed partial class FinetunedModel
    {
        /// <summary>
        /// read-only. Timestamp for the completed fine-tuning.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// read-only. Creation timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// read-only. User ID of the creator.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// read-only. FinetunedModel ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// read-only. Deprecated: Timestamp for the latest request to this fine-tuned model.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_used")]
        public global::System.DateTime? LastUsed { get; set; }

        /// <summary>
        /// FinetunedModel name (e.g. `foobar`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// read-only. Organization ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// The configuration used for fine-tuning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Settings Settings { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.Status? Status { get; set; }

        /// <summary>
        /// read-only. Latest update timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetunedModel" /> class.
        /// </summary>
        /// <param name="completedAt">
        /// read-only. Timestamp for the completed fine-tuning.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// read-only. Creation timestamp.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creatorId">
        /// read-only. User ID of the creator.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// read-only. FinetunedModel ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastUsed">
        /// read-only. Deprecated: Timestamp for the latest request to this fine-tuned model.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// FinetunedModel name (e.g. `foobar`).
        /// </param>
        /// <param name="organizationId">
        /// read-only. Organization ID.<br/>
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
        /// read-only. Latest update timestamp.<br/>
        /// Included only in responses
        /// </param>
        public FinetunedModel(
            string name,
            global::G.Settings settings,
            global::System.DateTime? completedAt,
            global::System.DateTime? createdAt,
            string? creatorId,
            string? id,
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
            this.Id = id;
            this.LastUsed = lastUsed;
            this.OrganizationId = organizationId;
            this.Status = status;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetunedModel" /> class.
        /// </summary>
        public FinetunedModel()
        {
        }
    }
}