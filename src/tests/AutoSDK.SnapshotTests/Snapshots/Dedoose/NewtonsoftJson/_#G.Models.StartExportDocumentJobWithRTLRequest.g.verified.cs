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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ResourceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeExRegions", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IncludeExRegions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rtl", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Rtl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exportExtension", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExportExtension { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="StartExportDocumentJobWithRTLRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="includeExRegions"></param>
        /// <param name="rtl"></param>
        /// <param name="exportExtension"></param>
        /// <param name="encryptedSymKey"></param>
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