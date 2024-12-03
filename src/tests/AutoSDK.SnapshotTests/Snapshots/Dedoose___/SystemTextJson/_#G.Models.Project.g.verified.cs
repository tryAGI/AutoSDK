//HintName: G.Models.Project.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Project
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
        [global::System.Text.Json.Serialization.JsonPropertyName("adminIDL")]
        public global::System.Guid? AdminIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createStamp")]
        public global::System.DateTime? CreateStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public global::System.Guid? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("symmetricHash")]
        public string? SymmetricHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="adminIDL"></param>
        /// <param name="createStamp"></param>
        /// <param name="createdBy"></param>
        /// <param name="symmetricHash"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Project(
            global::System.Guid? id,
            string? title,
            string? description,
            global::System.Guid? adminIDL,
            global::System.DateTime? createStamp,
            global::System.Guid? createdBy,
            string? symmetricHash)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.AdminIDL = adminIDL;
            this.CreateStamp = createStamp;
            this.CreatedBy = createdBy;
            this.SymmetricHash = symmetricHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }
    }
}