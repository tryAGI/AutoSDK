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
        [global::Newtonsoft.Json.JsonProperty("nanosecond heartbeat", Required = global::Newtonsoft.Json.Required.Always)]
        public long Nanosecond_heartbeat { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartbeatResponse" /> class.
        /// </summary>
        /// <param name="nanosecond_heartbeat"></param>
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