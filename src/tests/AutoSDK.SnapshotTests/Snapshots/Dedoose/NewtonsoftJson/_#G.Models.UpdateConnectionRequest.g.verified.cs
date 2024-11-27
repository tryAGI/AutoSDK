//HintName: G.Models.UpdateConnectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConnectionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid? UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectionKey", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ConnectionKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid? ProjectId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConnectionRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="connectionKey"></param>
        /// <param name="projectId"></param>
        public UpdateConnectionRequest(
            global::System.Guid? userId,
            global::System.Guid connectionKey,
            global::System.Guid? projectId)
        {
            this.UserId = userId;
            this.ConnectionKey = connectionKey;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConnectionRequest" /> class.
        /// </summary>
        public UpdateConnectionRequest()
        {
        }
    }
}