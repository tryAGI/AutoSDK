//HintName: G.Models.StartExportResourcesJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExportResourcesJobRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeDescriptorInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeDescriptorInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeCodeCounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeCodeCounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportResourcesJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceIds"></param>
        /// <param name="includeDescriptorInfo"></param>
        /// <param name="includeCodeCounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartExportResourcesJobRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> resourceIds,
            bool includeDescriptorInfo,
            bool includeCodeCounts)
        {
            this.ProjectId = projectId;
            this.ResourceIds = resourceIds ?? throw new global::System.ArgumentNullException(nameof(resourceIds));
            this.IncludeDescriptorInfo = includeDescriptorInfo;
            this.IncludeCodeCounts = includeCodeCounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportResourcesJobRequest" /> class.
        /// </summary>
        public StartExportResourcesJobRequest()
        {
        }
    }
}