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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeleteResourcesJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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