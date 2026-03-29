//HintName: G.Models.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender_id")]
        public string? SenderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_item_id")]
        public string? BatchItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItem" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="name"></param>
        /// <param name="otid"></param>
        /// <param name="senderId"></param>
        /// <param name="batchItemId"></param>
        /// <param name="groupId"></param>
        public TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItem(
            global::G.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole role,
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
        /// Initializes a new instance of the <see cref="TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItem" /> class.
        /// </summary>
        public TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItem()
        {
        }
    }
}