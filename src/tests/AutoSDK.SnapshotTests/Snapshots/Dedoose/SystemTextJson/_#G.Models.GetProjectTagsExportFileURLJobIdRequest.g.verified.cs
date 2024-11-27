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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileExtension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileExtension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeExcerpts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeExcerpts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedSymKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedSymKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTagsExportFileURLJobIdRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="includeExcerpts"></param>
        /// <param name="encryptedSymKey"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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