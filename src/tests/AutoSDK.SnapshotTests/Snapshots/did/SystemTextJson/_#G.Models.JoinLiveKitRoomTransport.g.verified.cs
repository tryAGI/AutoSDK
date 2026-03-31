//HintName: G.Models.JoinLiveKitRoomTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JoinLiveKitRoomTransport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JoinLiveKitRoomTransportProviderJsonConverter))]
        public global::G.JoinLiveKitRoomTransportProvider Provider { get; set; }

        /// <summary>
        /// Name of the existing LiveKit room
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("room_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoomName { get; set; }

        /// <summary>
        /// LiveKit server WebSocket URL to connect to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerUrl { get; set; }

        /// <summary>
        /// Room token for the participant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinLiveKitRoomTransport" /> class.
        /// </summary>
        /// <param name="roomName">
        /// Name of the existing LiveKit room
        /// </param>
        /// <param name="serverUrl">
        /// LiveKit server WebSocket URL to connect to
        /// </param>
        /// <param name="token">
        /// Room token for the participant
        /// </param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JoinLiveKitRoomTransport(
            string roomName,
            string serverUrl,
            string token,
            global::G.JoinLiveKitRoomTransportProvider provider)
        {
            this.Provider = provider;
            this.RoomName = roomName ?? throw new global::System.ArgumentNullException(nameof(roomName));
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinLiveKitRoomTransport" /> class.
        /// </summary>
        public JoinLiveKitRoomTransport()
        {
        }
    }
}