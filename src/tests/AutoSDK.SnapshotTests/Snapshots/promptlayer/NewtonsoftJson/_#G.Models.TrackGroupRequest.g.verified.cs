//HintName: G.Models.TrackGroupRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackGroupRequest
    {
        /// <summary>
        /// The unique identifier for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; } = default!;

        /// <summary>
        /// The unique identifier for the group to be associated with the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int GroupId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackGroupRequest" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier for the request.
        /// </param>
        /// <param name="groupId">
        /// The unique identifier for the group to be associated with the request.
        /// </param>
        public TrackGroupRequest(
            int requestId,
            int groupId)
        {
            this.RequestId = requestId;
            this.GroupId = groupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackGroupRequest" /> class.
        /// </summary>
        public TrackGroupRequest()
        {
        }
    }
}