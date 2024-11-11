//HintName: G.Models.TagAppDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TagAppDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagId")]
        public global::System.Guid? TagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceId")]
        public global::System.Guid? ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excerptId")]
        public global::System.Guid? ExcerptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createStamp")]
        public global::System.DateTime? CreateStamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagAppDTO" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="tagId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="weight"></param>
        /// <param name="userId"></param>
        /// <param name="createStamp"></param>
        public TagAppDTO(
            global::System.Guid? id,
            global::System.Guid? projectId,
            global::System.Guid? tagId,
            global::System.Guid? resourceId,
            global::System.Guid? excerptId,
            double? weight,
            global::System.Guid? userId,
            global::System.DateTime? createStamp)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.TagId = tagId;
            this.ResourceId = resourceId;
            this.ExcerptId = excerptId;
            this.Weight = weight;
            this.UserId = userId;
            this.CreateStamp = createStamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagAppDTO" /> class.
        /// </summary>
        public TagAppDTO()
        {
        }
    }
}