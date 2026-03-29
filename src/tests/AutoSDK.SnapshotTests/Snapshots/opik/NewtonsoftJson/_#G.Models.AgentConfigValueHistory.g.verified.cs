//HintName: G.Models.AgentConfigValueHistory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfigValueHistory
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentConfigValueHistoryType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valid_from_blueprint_id")]
        public global::System.Guid? ValidFromBlueprintId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valid_to_blueprint_id")]
        public global::System.Guid? ValidToBlueprintId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigValueHistory" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="projectId">
        /// Included only in responses
        /// </param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        /// <param name="validFromBlueprintId">
        /// Included only in responses
        /// </param>
        /// <param name="validToBlueprintId">
        /// Included only in responses
        /// </param>
        public AgentConfigValueHistory(
            string key,
            global::G.AgentConfigValueHistoryType type,
            global::System.Guid? id,
            global::System.Guid? projectId,
            string? value,
            string? description,
            global::System.Guid? validFromBlueprintId,
            global::System.Guid? validToBlueprintId)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
            this.Type = type;
            this.Description = description;
            this.ValidFromBlueprintId = validFromBlueprintId;
            this.ValidToBlueprintId = validToBlueprintId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigValueHistory" /> class.
        /// </summary>
        public AgentConfigValueHistory()
        {
        }
    }
}