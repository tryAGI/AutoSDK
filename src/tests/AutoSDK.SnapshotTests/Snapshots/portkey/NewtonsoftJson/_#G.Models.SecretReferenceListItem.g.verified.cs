//HintName: G.Models.SecretReferenceListItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretReferenceListItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SecretReferenceListItemManagerTypeJsonConverter))]
        public global::G.SecretReferenceListItemManagerType? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SecretReferenceListItemStatusJsonConverter))]
        public global::G.SecretReferenceListItemStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SecretReferenceListItemObjectJsonConverter))]
        public global::G.SecretReferenceListItemObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretReferenceListItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="managerType"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="object"></param>
        public SecretReferenceListItem(
            global::System.Guid? id,
            string? name,
            string? slug,
            global::G.SecretReferenceListItemManagerType? managerType,
            global::G.SecretReferenceListItemStatus? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            global::G.SecretReferenceListItemObject? @object)
        {
            this.Id = id;
            this.Name = name;
            this.Slug = slug;
            this.ManagerType = managerType;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretReferenceListItem" /> class.
        /// </summary>
        public SecretReferenceListItem()
        {
        }
    }
}