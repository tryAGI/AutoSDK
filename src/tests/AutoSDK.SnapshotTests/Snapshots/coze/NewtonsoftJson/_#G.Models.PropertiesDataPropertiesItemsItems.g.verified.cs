//HintName: G.Models.PropertiesDataPropertiesItemsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesDataPropertiesItemsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_published")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_user_id")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// 发布态返回publish_time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_at")]
        public int? PublishedAt { get; set; }

        /// <summary>
        /// 草稿返回update_time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public int? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesItemsItems" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="folderId"></param>
        /// <param name="iconUrl"></param>
        /// <param name="id"></param>
        /// <param name="isPublished"></param>
        /// <param name="name"></param>
        /// <param name="ownerUserId"></param>
        /// <param name="publishedAt">
        /// 发布态返回publish_time
        /// </param>
        /// <param name="updatedAt">
        /// 草稿返回update_time
        /// </param>
        public PropertiesDataPropertiesItemsItems(
            string? description,
            string? folderId,
            string? iconUrl,
            string? id,
            bool? isPublished,
            string? name,
            string? ownerUserId,
            int? publishedAt,
            int? updatedAt)
        {
            this.Description = description;
            this.FolderId = folderId;
            this.IconUrl = iconUrl;
            this.Id = id;
            this.IsPublished = isPublished;
            this.Name = name;
            this.OwnerUserId = ownerUserId;
            this.PublishedAt = publishedAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesItemsItems" /> class.
        /// </summary>
        public PropertiesDataPropertiesItemsItems()
        {
        }
    }
}