//HintName: G.Models.GuardrailsAssignmentsKeysGetResponsesContentApplicationJsonSchemaDataItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsAssignmentsKeysGetResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// Unique identifier for the assignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Hash of the assigned API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyHash { get; set; }

        /// <summary>
        /// ID of the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GuardrailId { get; set; }

        /// <summary>
        /// Name of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyName { get; set; }

        /// <summary>
        /// Label of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyLabel { get; set; }

        /// <summary>
        /// User ID of who made the assignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_by")]
        public string? AssignedBy { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the assignment was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsAssignmentsKeysGetResponsesContentApplicationJsonSchemaDataItems" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailsAssignmentsKeysGetResponsesContentApplicationJsonSchemaDataItems(
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
        /// Initializes a new instance of the <see cref="GuardrailsAssignmentsKeysGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public GuardrailsAssignmentsKeysGetResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}