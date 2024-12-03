//HintName: G.Models.RemoveTagApplicationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveTagApplicationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagAppId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TagAppId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveTagApplicationRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tagAppId"></param>
        public RemoveTagApplicationRequest(
            global::System.Guid projectId,
            global::System.Guid tagAppId)
        {
            this.ProjectId = projectId;
            this.TagAppId = tagAppId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveTagApplicationRequest" /> class.
        /// </summary>
        public RemoveTagApplicationRequest()
        {
        }
    }
}