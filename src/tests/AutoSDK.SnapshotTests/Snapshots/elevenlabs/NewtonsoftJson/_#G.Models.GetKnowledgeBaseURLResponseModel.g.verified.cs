//HintName: G.Models.GetKnowledgeBaseURLResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKnowledgeBaseURLResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.KnowledgeBaseDocumentMetadataResponseModel Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supported_usages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DocumentUsageModeEnum> SupportedUsages { get; set; } = default!;

        /// <summary>
        /// Example: {"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </summary>
        /// <example>{"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}</example>
        [global::Newtonsoft.Json.JsonProperty("access_info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResourceAccessInfo AccessInfo { get; set; } = default!;

        /// <summary>
        /// The ID of the parent folder, or null if the document is at the root level.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_parent_id")]
        public string? FolderParentId { get; set; }

        /// <summary>
        /// The folder path segments leading to this entity, from root to parent folder.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_path")]
        public global::System.Collections.Generic.IList<global::G.KnowledgeBaseFolderPathSegmentResponseModel>? FolderPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"url"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "url";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extracted_inner_html", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExtractedInnerHtml { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseURLResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="supportedUsages"></param>
        /// <param name="accessInfo">
        /// Example: {"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </param>
        /// <param name="folderParentId">
        /// The ID of the parent folder, or null if the document is at the root level.
        /// </param>
        /// <param name="folderPath">
        /// The folder path segments leading to this entity, from root to parent folder.
        /// </param>
        /// <param name="type"></param>
        /// <param name="url"></param>
        /// <param name="extractedInnerHtml"></param>
        public GetKnowledgeBaseURLResponseModel(
            string id,
            string name,
            global::G.KnowledgeBaseDocumentMetadataResponseModel metadata,
            global::System.Collections.Generic.IList<global::G.DocumentUsageModeEnum> supportedUsages,
            global::G.ResourceAccessInfo accessInfo,
            string url,
            string extractedInnerHtml,
            string? folderParentId,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseFolderPathSegmentResponseModel>? folderPath,
            string type = "url")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.SupportedUsages = supportedUsages ?? throw new global::System.ArgumentNullException(nameof(supportedUsages));
            this.AccessInfo = accessInfo ?? throw new global::System.ArgumentNullException(nameof(accessInfo));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExtractedInnerHtml = extractedInnerHtml ?? throw new global::System.ArgumentNullException(nameof(extractedInnerHtml));
            this.FolderParentId = folderParentId;
            this.FolderPath = folderPath;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseURLResponseModel" /> class.
        /// </summary>
        public GetKnowledgeBaseURLResponseModel()
        {
        }
    }
}