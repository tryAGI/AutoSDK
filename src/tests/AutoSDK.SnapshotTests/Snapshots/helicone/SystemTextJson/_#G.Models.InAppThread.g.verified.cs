//HintName: G.Models.InAppThread.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppThread
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Chat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("escalated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Escalated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_delete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SoftDelete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppThread" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="chat"></param>
        /// <param name="userId"></param>
        /// <param name="orgId"></param>
        /// <param name="createdAt"></param>
        /// <param name="escalated"></param>
        /// <param name="metadata"></param>
        /// <param name="updatedAt"></param>
        /// <param name="softDelete"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppThread(
            string id,
            object chat,
            string userId,
            string orgId,
            global::System.DateTime createdAt,
            bool escalated,
            object metadata,
            global::System.DateTime updatedAt,
            bool softDelete)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Chat = chat ?? throw new global::System.ArgumentNullException(nameof(chat));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.Escalated = escalated;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.UpdatedAt = updatedAt;
            this.SoftDelete = softDelete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppThread" /> class.
        /// </summary>
        public InAppThread()
        {
        }
    }
}