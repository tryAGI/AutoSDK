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
        /// FinetunedModel name (e.g. `foobar`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// User ID of the creator.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// Organization ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// FinetunedModel settings such as dataset, hyperparameters...
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Settings Settings { get; set; } = default!;

        /// <summary>
        /// Current stage in the life-cycle of the fine-tuned model.<br/>
        /// Default Value: STATUS_UNSPECIFIED<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.Status? Status { get; set; }

        /// <summary>
        /// Creation timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Latest update timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Timestamp for the completed fine-tuning.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Deprecated: Timestamp for the latest request to this fine-tuned model.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_used")]
        public global::System.DateTime? LastUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFinetunedModelRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// FinetunedModel name (e.g. `foobar`).
        /// </param>
        /// <param name="creatorId">
        /// User ID of the creator.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="organizationId">
        /// Organization ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="settings">
        /// FinetunedModel settings such as dataset, hyperparameters...
        /// </param>
        /// <param name="status">
        /// Current stage in the life-cycle of the fine-tuned model.<br/>
        /// Default Value: STATUS_UNSPECIFIED<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Latest update timestamp.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="completedAt">
        /// Timestamp for the completed fine-tuning.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastUsed">
        /// Deprecated: Timestamp for the latest request to this fine-tuned model.<br/>
        /// Included only in responses
        /// </param>
        public UpdateFinetunedModelRequest(
            string name,
            global::G.Settings settings,
            string? creatorId,
            string? organizationId,
            global::G.Status? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? completedAt,
            global::System.DateTime? lastUsed)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.CreatorId = creatorId;
            this.OrganizationId = organizationId;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CompletedAt = completedAt;
            this.LastUsed = lastUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFinetunedModelRequest" /> class.
        /// </summary>
        public UpdateFinetunedModelRequest()
        {
        }
    }
}