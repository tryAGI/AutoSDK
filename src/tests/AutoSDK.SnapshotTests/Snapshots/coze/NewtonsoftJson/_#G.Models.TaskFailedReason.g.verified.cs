//HintName: G.Models.TaskFailedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskFailedReason
    {
        /// <summary>
        /// 实体id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// 实体名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_name")]
        public string? EntityName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type")]
        public global::G.TaskEntityType? EntityType { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_reason")]
        public string? FailedReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskFailedReason" /> class.
        /// </summary>
        /// <param name="entityId">
        /// 实体id
        /// </param>
        /// <param name="entityName">
        /// 实体名称
        /// </param>
        /// <param name="entityType"></param>
        /// <param name="failedReason">
        /// 失败原因
        /// </param>
        public TaskFailedReason(
            string? entityId,
            string? entityName,
            global::G.TaskEntityType? entityType,
            string? failedReason)
        {
            this.EntityId = entityId;
            this.EntityName = entityName;
            this.EntityType = entityType;
            this.FailedReason = failedReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskFailedReason" /> class.
        /// </summary>
        public TaskFailedReason()
        {
        }
    }
}