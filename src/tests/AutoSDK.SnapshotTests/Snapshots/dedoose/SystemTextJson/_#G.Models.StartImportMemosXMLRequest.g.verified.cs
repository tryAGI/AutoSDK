//HintName: G.Models.StartImportMemosXMLRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartImportMemosXMLRequest
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartImportMemosXMLRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileURI"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartImportMemosXMLRequest(
            global::System.Guid projectId,
            string fileURI)
        {
            this.ProjectId = projectId;
            this.FileURI = fileURI ?? throw new global::System.ArgumentNullException(nameof(fileURI));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartImportMemosXMLRequest" /> class.
        /// </summary>
        public StartImportMemosXMLRequest()
        {
        }
    }
}