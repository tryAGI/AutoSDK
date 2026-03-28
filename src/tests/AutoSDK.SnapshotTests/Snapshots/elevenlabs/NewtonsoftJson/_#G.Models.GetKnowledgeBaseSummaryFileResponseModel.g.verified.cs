//HintName: G.Models.GetKnowledgeBaseSummaryFileResponseModel.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKnowledgeBaseSummaryFileResponseModel
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
        public global::System.Collections.Generic.IList<global::G.KnowledgeBaseFolderPathSegmentSummaryResponseModel>? FolderPath { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed in the future, use the separate endpoint to get dependent agents instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependent_agents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DependentAgentsItem> DependentAgents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"file"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "file";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseSummaryFileResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="supportedUsages"></param>
        /// <param name="accessInfo">
        /// Example: {"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </param>
        /// <param name="dependentAgents">
        /// This field is deprecated and will be removed in the future, use the separate endpoint to get dependent agents instead.
        /// </param>
        /// <param name="folderParentId">
        /// The ID of the parent folder, or null if the document is at the root level.
        /// </param>
        /// <param name="folderPath">
        /// The folder path segments leading to this entity, from root to parent folder.
        /// </param>
        /// <param name="type"></param>
        public GetKnowledgeBaseSummaryFileResponseModel(
            string id,
            string name,
            global::G.KnowledgeBaseDocumentMetadataResponseModel metadata,
            global::System.Collections.Generic.IList<global::G.DocumentUsageModeEnum> supportedUsages,
            global::G.ResourceAccessInfo accessInfo,
            global::System.Collections.Generic.IList<global::G.DependentAgentsItem> dependentAgents,
            string? folderParentId,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseFolderPathSegmentSummaryResponseModel>? folderPath,
            string type = "file")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.SupportedUsages = supportedUsages ?? throw new global::System.ArgumentNullException(nameof(supportedUsages));
            this.AccessInfo = accessInfo ?? throw new global::System.ArgumentNullException(nameof(accessInfo));
            this.FolderParentId = folderParentId;
            this.FolderPath = folderPath;
            this.DependentAgents = dependentAgents ?? throw new global::System.ArgumentNullException(nameof(dependentAgents));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseSummaryFileResponseModel" /> class.
        /// </summary>
        public GetKnowledgeBaseSummaryFileResponseModel()
        {
        }
    }
}