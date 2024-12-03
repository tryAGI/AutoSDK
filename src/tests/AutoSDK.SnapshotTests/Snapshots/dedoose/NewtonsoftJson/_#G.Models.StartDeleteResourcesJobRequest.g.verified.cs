//HintName: G.Models.StartDeleteResourcesJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartDeleteResourcesJobRequest
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeleteResourcesJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceIds"></param>
        public StartDeleteResourcesJobRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> resourceIds)
        {
            this.ProjectId = projectId;
            this.ResourceIds = resourceIds ?? throw new global::System.ArgumentNullException(nameof(resourceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeleteResourcesJobRequest" /> class.
        /// </summary>
        public StartDeleteResourcesJobRequest()
        {
        }
    }
}