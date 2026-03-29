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
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChannelName { get; set; }

        /// <summary>
        /// The socket ID for Pusher authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socket_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SocketId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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