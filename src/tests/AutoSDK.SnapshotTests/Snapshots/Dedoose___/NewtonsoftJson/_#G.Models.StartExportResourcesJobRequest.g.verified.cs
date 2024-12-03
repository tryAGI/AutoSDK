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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> ResourceIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeDescriptorInfo", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IncludeDescriptorInfo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeCodeCounts", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IncludeCodeCounts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportResourcesJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceIds"></param>
        /// <param name="includeDescriptorInfo"></param>
        /// <param name="includeCodeCounts"></param>
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