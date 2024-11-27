//HintName: G.Models.StartAddPDFImageResourceJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartAddPDFImageResourceJobRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileURI")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileURI { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAddPDFImageResourceJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="fileName"></param>
        /// <param name="fileURI"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartAddPDFImageResourceJobRequest(
            global::System.Guid projectId,
            global::System.Guid userId,
            string fileName,
            string fileURI)
        {
            this.ProjectId = projectId;
            this.UserId = userId;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileURI = fileURI ?? throw new global::System.ArgumentNullException(nameof(fileURI));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAddPDFImageResourceJobRequest" /> class.
        /// </summary>
        public StartAddPDFImageResourceJobRequest()
        {
        }
    }
}