//HintName: G.Models.StartProjectImportJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartProjectImportJobRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("fileURI")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileURI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartProjectImportJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileURI"></param>
        /// <param name="password"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartProjectImportJobRequest(
            global::System.Guid projectId,
            string fileURI,
            string password)
        {
            this.ProjectId = projectId;
            this.FileURI = fileURI ?? throw new global::System.ArgumentNullException(nameof(fileURI));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartProjectImportJobRequest" /> class.
        /// </summary>
        public StartProjectImportJobRequest()
        {
        }
    }
}