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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat", Required = global::Newtonsoft.Json.Required.Always)]
        public object Chat { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("escalated", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Escalated { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("soft_delete", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SoftDelete { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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