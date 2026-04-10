//HintName: G.Models.PromptPartial.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptPartial
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection_id")]
        public global::System.Guid? CollectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("string")]
        public string? String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public double? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_partial_version_id")]
        public global::System.Guid? PromptPartialVersionId { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptPartialStatusJsonConverter))]
        public global::G.PromptPartialStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPartial" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="collectionId"></param>
        /// <param name="string"></param>
        /// <param name="version"></param>
        /// <param name="versionDescription"></param>
        /// <param name="promptPartialVersionId"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="status"></param>
        public PromptPartial(
            global::System.Guid? id,
            string? slug,
            string? name,
            global::System.Guid? collectionId,
            string? @string,
            double? version,
            string? versionDescription,
            global::System.Guid? promptPartialVersionId,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            global::G.PromptPartialStatus? status)
        {
            this.Id = id;
            this.Slug = slug;
            this.Name = name;
            this.CollectionId = collectionId;
            this.String = @string;
            this.Version = version;
            this.VersionDescription = versionDescription;
            this.PromptPartialVersionId = promptPartialVersionId;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPartial" /> class.
        /// </summary>
        public PromptPartial()
        {
        }
    }
}