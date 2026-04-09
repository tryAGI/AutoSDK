//HintName: G.Models.JoinLivekitRoomRequestTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// LiveKit transport config
    /// </summary>
    public sealed partial class JoinLivekitRoomRequestTransport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JoinLivekitRoomRequestTransportProviderJsonConverter))]
        public global::G.JoinLivekitRoomRequestTransportProvider Provider { get; set; }

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
        /// Initializes a new instance of the <see cref="JoinLivekitRoomRequestTransport" /> class.
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
        public JoinLivekitRoomRequestTransport(
            string roomName,
            string serverUrl,
            string token,
            global::G.JoinLivekitRoomRequestTransportProvider provider)
        {
            this.Provider = provider;
            this.RoomName = roomName ?? throw new global::System.ArgumentNullException(nameof(roomName));
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinLivekitRoomRequestTransport" /> class.
        /// </summary>
        public JoinLivekitRoomRequestTransport()
        {
        }
    }
}