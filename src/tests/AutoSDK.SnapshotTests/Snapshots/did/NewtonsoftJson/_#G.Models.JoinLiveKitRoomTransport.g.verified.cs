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
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JoinLiveKitRoomTransportProviderJsonConverter))]
        public global::G.JoinLiveKitRoomTransportProvider Provider { get; set; }

        /// <summary>
        /// Name of the existing LiveKit room
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("room_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string RoomName { get; set; } = default!;

        /// <summary>
        /// LiveKit server WebSocket URL to connect to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerUrl { get; set; } = default!;

        /// <summary>
        /// Room token for the participant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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