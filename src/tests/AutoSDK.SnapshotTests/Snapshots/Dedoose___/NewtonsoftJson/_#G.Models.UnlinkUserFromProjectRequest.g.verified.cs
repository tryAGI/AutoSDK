//HintName: G.Models.UnlinkUserFromProjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnlinkUserFromProjectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlinkUserFromProjectRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        public UnlinkUserFromProjectRequest(
            global::System.Guid projectId,
            global::System.Guid userId)
        {
            this.ProjectId = projectId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlinkUserFromProjectRequest" /> class.
        /// </summary>
        public UnlinkUserFromProjectRequest()
        {
        }
    }
}