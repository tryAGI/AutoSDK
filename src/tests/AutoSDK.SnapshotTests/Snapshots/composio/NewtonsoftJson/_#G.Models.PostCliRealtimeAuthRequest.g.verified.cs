//HintName: G.Models.PostCliRealtimeAuthRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostCliRealtimeAuthRequest
    {
        /// <summary>
        /// The channel name to authenticate for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChannelName { get; set; } = default!;

        /// <summary>
        /// The socket ID for Pusher authentication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("socket_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SocketId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliRealtimeAuthRequest" /> class.
        /// </summary>
        /// <param name="channelName">
        /// The channel name to authenticate for
        /// </param>
        /// <param name="socketId">
        /// The socket ID for Pusher authentication
        /// </param>
        public PostCliRealtimeAuthRequest(
            string channelName,
            string socketId)
        {
            this.ChannelName = channelName ?? throw new global::System.ArgumentNullException(nameof(channelName));
            this.SocketId = socketId ?? throw new global::System.ArgumentNullException(nameof(socketId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliRealtimeAuthRequest" /> class.
        /// </summary>
        public PostCliRealtimeAuthRequest()
        {
        }
    }
}