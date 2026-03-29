//HintName: G.Models.HeartbeatResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartbeatResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nanosecond heartbeat")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Nanosecond_heartbeat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartbeatResponse" /> class.
        /// </summary>
        /// <param name="nanosecond_heartbeat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartbeatResponse(
            long nanosecond_heartbeat)
        {
            this.Nanosecond_heartbeat = nanosecond_heartbeat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartbeatResponse" /> class.
        /// </summary>
        public HeartbeatResponse()
        {
        }
    }
}