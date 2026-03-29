//HintName: G.Models.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_id")]
        public string? SenderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_item_id")]
        public string? BatchItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItem" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="name"></param>
        /// <param name="otid"></param>
        /// <param name="senderId"></param>
        /// <param name="batchItemId"></param>
        /// <param name="groupId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItem(
            global::G.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole role,
            string content,
            string? name,
            string? otid,
            string? senderId,
            string? batchItemId,
            string? groupId)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Name = name;
            this.Otid = otid;
            this.SenderId = senderId;
            this.BatchItemId = batchItemId;
            this.GroupId = groupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItem" /> class.
        /// </summary>
        public TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItem()
        {
        }
    }
}