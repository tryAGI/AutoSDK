//HintName: G.Models.AgentConfigValuePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfigValuePublic
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentConfigValuePublicTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentConfigValuePublicType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_from_blueprint_id")]
        public global::System.Guid? ValidFromBlueprintId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_to_blueprint_id")]
        public global::System.Guid? ValidToBlueprintId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigValuePublic" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigValuePublic(
            string key,
            global::G.AgentConfigValuePublicType type,
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
        /// Initializes a new instance of the <see cref="AgentConfigValuePublic" /> class.
        /// </summary>
        public AgentConfigValuePublic()
        {
        }
    }
}