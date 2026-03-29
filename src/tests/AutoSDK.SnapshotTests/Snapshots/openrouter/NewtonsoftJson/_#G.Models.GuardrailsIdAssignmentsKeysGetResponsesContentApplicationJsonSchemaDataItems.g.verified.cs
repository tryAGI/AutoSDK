//HintName: G.Models.GuardrailsIdAssignmentsKeysGetResponsesContentApplicationJsonSchemaDataItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsIdAssignmentsKeysGetResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// Unique identifier for the assignment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Hash of the assigned API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyHash { get; set; } = default!;

        /// <summary>
        /// ID of the guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guardrail_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid GuardrailId { get; set; } = default!;

        /// <summary>
        /// Name of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyName { get; set; } = default!;

        /// <summary>
        /// Label of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_label", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyLabel { get; set; } = default!;

        /// <summary>
        /// User ID of who made the assignment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assigned_by")]
        public string? AssignedBy { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the assignment was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsIdAssignmentsKeysGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the assignment
        /// </param>
        /// <param name="keyHash">
        /// Hash of the assigned API key
        /// </param>
        /// <param name="guardrailId">
        /// ID of the guardrail
        /// </param>
        /// <param name="keyName">
        /// Name of the API key
        /// </param>
        /// <param name="keyLabel">
        /// Label of the API key
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the assignment was created
        /// </param>
        /// <param name="assignedBy">
        /// User ID of who made the assignment
        /// </param>
        public GuardrailsIdAssignmentsKeysGetResponsesContentApplicationJsonSchemaDataItems(
            global::System.Guid id,
            string keyHash,
            global::System.Guid guardrailId,
            string keyName,
            string keyLabel,
            string createdAt,
            string? assignedBy)
        {
            this.Id = id;
            this.KeyHash = keyHash ?? throw new global::System.ArgumentNullException(nameof(keyHash));
            this.GuardrailId = guardrailId;
            this.KeyName = keyName ?? throw new global::System.ArgumentNullException(nameof(keyName));
            this.KeyLabel = keyLabel ?? throw new global::System.ArgumentNullException(nameof(keyLabel));
            this.AssignedBy = assignedBy;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsIdAssignmentsKeysGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public GuardrailsIdAssignmentsKeysGetResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}