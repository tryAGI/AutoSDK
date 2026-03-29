//HintName: G.Models.BotSimpleInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BotSimpleInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_published")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_user_id")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// 发布态返回publish_time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        public int? PublishedAt { get; set; }

        /// <summary>
        /// 草稿返回update_time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public int? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BotSimpleInfo" /> class.
        /// </summary>
        /// <param name="description"></param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BotSimpleInfo(
            string? description,
            string? iconUrl,
            string? id,
            bool? isPublished,
            string? name,
            string? ownerUserId,
            int? publishedAt,
            int? updatedAt)
        {
            this.Description = description;
            this.IconUrl = iconUrl;
            this.Id = id;
            this.IsPublished = isPublished;
            this.Name = name;
            this.OwnerUserId = ownerUserId;
            this.PublishedAt = publishedAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BotSimpleInfo" /> class.
        /// </summary>
        public BotSimpleInfo()
        {
        }
    }
}