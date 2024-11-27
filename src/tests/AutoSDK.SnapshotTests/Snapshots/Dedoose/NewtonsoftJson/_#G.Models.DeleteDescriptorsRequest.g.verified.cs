//HintName: G.Models.DeleteDescriptorsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteDescriptorsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptorsIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> DescriptorsIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDescriptorsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="descriptorsIds"></param>
        public DeleteDescriptorsRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> descriptorsIds)
        {
            this.ProjectId = projectId;
            this.DescriptorsIds = descriptorsIds ?? throw new global::System.ArgumentNullException(nameof(descriptorsIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDescriptorsRequest" /> class.
        /// </summary>
        public DeleteDescriptorsRequest()
        {
        }
    }
}