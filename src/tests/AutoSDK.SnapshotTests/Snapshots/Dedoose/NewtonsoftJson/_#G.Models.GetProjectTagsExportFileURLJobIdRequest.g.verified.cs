//HintName: G.Models.GetProjectTagsExportFileURLJobIdRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectTagsExportFileURLJobIdRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileExtension", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileExtension { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeExcerpts", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IncludeExcerpts { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encryptedSymKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string EncryptedSymKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTagsExportFileURLJobIdRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="includeExcerpts"></param>
        /// <param name="encryptedSymKey"></param>
        public GetProjectTagsExportFileURLJobIdRequest(
            global::System.Guid projectId,
            string fileExtension,
            bool includeExcerpts,
            string encryptedSymKey)
        {
            this.ProjectId = projectId;
            this.FileExtension = fileExtension ?? throw new global::System.ArgumentNullException(nameof(fileExtension));
            this.IncludeExcerpts = includeExcerpts;
            this.EncryptedSymKey = encryptedSymKey ?? throw new global::System.ArgumentNullException(nameof(encryptedSymKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTagsExportFileURLJobIdRequest" /> class.
        /// </summary>
        public GetProjectTagsExportFileURLJobIdRequest()
        {
        }
    }
}