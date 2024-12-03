//HintName: G.Models.WebhookDiscussionCategoryChangedChangesCategoryFrom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDiscussionCategoryChangedChangesCategoryFrom
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emoji", Required = global::Newtonsoft.Json.Required.Always)]
        public string Emoji { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_answerable", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAnswerable { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RepositoryId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDiscussionCategoryChangedChangesCategoryFrom" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="emoji"></param>
        /// <param name="id"></param>
        /// <param name="isAnswerable"></param>
        /// <param name="name"></param>
        /// <param name="nodeId"></param>
        /// <param name="repositoryId"></param>
        /// <param name="slug"></param>
        /// <param name="updatedAt"></param>
        public WebhookDiscussionCategoryChangedChangesCategoryFrom(
            global::System.DateTime createdAt,
            string description,
            string emoji,
            int id,
            bool isAnswerable,
            string name,
            int repositoryId,
            string slug,
            string updatedAt,
            string? nodeId)
        {
            this.CreatedAt = createdAt;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Emoji = emoji ?? throw new global::System.ArgumentNullException(nameof(emoji));
            this.Id = id;
            this.IsAnswerable = isAnswerable;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RepositoryId = repositoryId;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.NodeId = nodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDiscussionCategoryChangedChangesCategoryFrom" /> class.
        /// </summary>
        public WebhookDiscussionCategoryChangedChangesCategoryFrom()
        {
        }
    }
}