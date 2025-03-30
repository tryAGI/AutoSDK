//HintName: G.Models.GetKnowledgeBaseFileResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKnowledgeBaseFileResponseModel
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
        [global::Newtonsoft.Json.JsonProperty("prompt_injectable", Required = global::Newtonsoft.Json.Required.Always)]
        public bool PromptInjectable { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResourceAccessInfo AccessInfo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extracted_inner_html", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExtractedInnerHtml { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GetKnowledgeBaseFileResponseModelType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseFileResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="promptInjectable"></param>
        /// <param name="accessInfo"></param>
        /// <param name="extractedInnerHtml"></param>
        /// <param name="type"></param>
        public GetKnowledgeBaseFileResponseModel(
            string id,
            string name,
            global::G.KnowledgeBaseDocumentMetadataResponseModel metadata,
            bool promptInjectable,
            global::G.ResourceAccessInfo accessInfo,
            string extractedInnerHtml,
            global::G.GetKnowledgeBaseFileResponseModelType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.PromptInjectable = promptInjectable;
            this.AccessInfo = accessInfo ?? throw new global::System.ArgumentNullException(nameof(accessInfo));
            this.ExtractedInnerHtml = extractedInnerHtml ?? throw new global::System.ArgumentNullException(nameof(extractedInnerHtml));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseFileResponseModel" /> class.
        /// </summary>
        public GetKnowledgeBaseFileResponseModel()
        {
        }
    }
}