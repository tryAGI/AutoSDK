//HintName: G.Models.AccessList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccessList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessTags")]
        public int? AccessTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessResources")]
        public int? AccessResources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessExcerpts")]
        public int? AccessExcerpts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessDescriptors")]
        public int? AccessDescriptors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessDesFields")]
        public int? AccessDesFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessSecurity")]
        public int? AccessSecurity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessUsers")]
        public int? AccessUsers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessList" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="accessTags"></param>
        /// <param name="accessResources"></param>
        /// <param name="accessExcerpts"></param>
        /// <param name="accessDescriptors"></param>
        /// <param name="accessDesFields"></param>
        /// <param name="accessSecurity"></param>
        /// <param name="accessUsers"></param>
        public AccessList(
            global::System.Guid? id,
            string? title,
            string? description,
            int? accessTags,
            int? accessResources,
            int? accessExcerpts,
            int? accessDescriptors,
            int? accessDesFields,
            int? accessSecurity,
            int? accessUsers)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.AccessTags = accessTags;
            this.AccessResources = accessResources;
            this.AccessExcerpts = accessExcerpts;
            this.AccessDescriptors = accessDescriptors;
            this.AccessDesFields = accessDesFields;
            this.AccessSecurity = accessSecurity;
            this.AccessUsers = accessUsers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessList" /> class.
        /// </summary>
        public AccessList()
        {
        }
    }
}