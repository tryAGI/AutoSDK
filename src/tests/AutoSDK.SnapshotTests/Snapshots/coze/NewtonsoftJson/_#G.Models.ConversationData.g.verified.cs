//HintName: G.Models.ConversationData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector_id")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_section_id")]
        public string? LastSectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public int? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationData" /> class.
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="createdAt"></param>
        /// <param name="creatorId"></param>
        /// <param name="id"></param>
        /// <param name="lastSectionId"></param>
        /// <param name="metaData"></param>
        /// <param name="name"></param>
        /// <param name="updatedAt"></param>
        public ConversationData(
            string? connectorId,
            int? createdAt,
            string? creatorId,
            string? id,
            string? lastSectionId,
            global::System.Collections.Generic.Dictionary<string, string>? metaData,
            string? name,
            int? updatedAt)
        {
            this.ConnectorId = connectorId;
            this.CreatedAt = createdAt;
            this.CreatorId = creatorId;
            this.Id = id;
            this.LastSectionId = lastSectionId;
            this.MetaData = metaData;
            this.Name = name;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationData" /> class.
        /// </summary>
        public ConversationData()
        {
        }
    }
}