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
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestId { get; set; }

        /// <summary>
        /// The unique identifier for the group to be associated with the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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