//HintName: G.Models.StartExportDocumentJobWithRTLRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExportDocumentJobWithRTLRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeExRegions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeExRegions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rtl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Rtl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportExtension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExportExtension { get; set; }

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
        /// Initializes a new instance of the <see cref="StartExportDocumentJobWithRTLRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="includeExRegions"></param>
        /// <param name="rtl"></param>
        /// <param name="exportExtension"></param>
        /// <param name="encryptedSymKey"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartExportDocumentJobWithRTLRequest(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            bool includeExRegions,
            bool rtl,
            string exportExtension,
            string encryptedSymKey)
        {
            this.ProjectId = projectId;
            this.ResourceId = resourceId;
            this.IncludeExRegions = includeExRegions;
            this.Rtl = rtl;
            this.ExportExtension = exportExtension ?? throw new global::System.ArgumentNullException(nameof(exportExtension));
            this.EncryptedSymKey = encryptedSymKey ?? throw new global::System.ArgumentNullException(nameof(encryptedSymKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportDocumentJobWithRTLRequest" /> class.
        /// </summary>
        public StartExportDocumentJobWithRTLRequest()
        {
        }
    }
}