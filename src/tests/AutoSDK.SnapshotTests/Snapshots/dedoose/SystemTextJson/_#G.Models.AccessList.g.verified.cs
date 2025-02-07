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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessTags")]
        public int? AccessTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessResources")]
        public int? AccessResources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessExcerpts")]
        public int? AccessExcerpts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessDescriptors")]
        public int? AccessDescriptors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessDesFields")]
        public int? AccessDesFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessSecurity")]
        public int? AccessSecurity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessUsers")]
        public int? AccessUsers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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