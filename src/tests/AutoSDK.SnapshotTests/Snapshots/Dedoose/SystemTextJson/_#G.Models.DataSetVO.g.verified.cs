//HintName: G.Models.DataSetVO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataSetVO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIdKey")]
        public string? ProjectIdKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdById")]
        public global::System.Guid? CreatedById { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createStamp")]
        public global::System.DateTime? CreateStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desciption")]
        public string? Desciption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectIdLists")]
        public global::G.DataSetObjectIds? ObjectIdLists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("areExcerptsFiltered")]
        public bool? AreExcerptsFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("areResourcesFiltered")]
        public bool? AreResourcesFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("areTagsFiltered")]
        public bool? AreTagsFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("areUsersFiltered")]
        public bool? AreUsersFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("areDescriptorsFiltered")]
        public bool? AreDescriptorsFiltered { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetVO" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="projectIdKey">
        /// Included only in responses
        /// </param>
        /// <param name="createdById"></param>
        /// <param name="createStamp"></param>
        /// <param name="title"></param>
        /// <param name="desciption"></param>
        /// <param name="objectIdLists"></param>
        /// <param name="areExcerptsFiltered"></param>
        /// <param name="areResourcesFiltered"></param>
        /// <param name="areTagsFiltered"></param>
        /// <param name="areUsersFiltered"></param>
        /// <param name="areDescriptorsFiltered"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DataSetVO(
            global::System.Guid? id,
            global::System.Guid? projectId,
            string? projectIdKey,
            global::System.Guid? createdById,
            global::System.DateTime? createStamp,
            string? title,
            string? desciption,
            global::G.DataSetObjectIds? objectIdLists,
            bool? areExcerptsFiltered,
            bool? areResourcesFiltered,
            bool? areTagsFiltered,
            bool? areUsersFiltered,
            bool? areDescriptorsFiltered)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.ProjectIdKey = projectIdKey;
            this.CreatedById = createdById;
            this.CreateStamp = createStamp;
            this.Title = title;
            this.Desciption = desciption;
            this.ObjectIdLists = objectIdLists;
            this.AreExcerptsFiltered = areExcerptsFiltered;
            this.AreResourcesFiltered = areResourcesFiltered;
            this.AreTagsFiltered = areTagsFiltered;
            this.AreUsersFiltered = areUsersFiltered;
            this.AreDescriptorsFiltered = areDescriptorsFiltered;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetVO" /> class.
        /// </summary>
        public DataSetVO()
        {
        }
    }
}