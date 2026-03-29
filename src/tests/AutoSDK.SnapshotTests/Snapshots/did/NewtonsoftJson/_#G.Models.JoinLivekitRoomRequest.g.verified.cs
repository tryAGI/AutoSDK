//HintName: G.Models.JoinLivekitRoomRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JoinLivekitRoomRequest
    {
        /// <summary>
        /// Configuration for the input audio fed into the avatar's video generator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JoinLivekitRoomRequestAudioConfig AudioConfig { get; set; } = default!;

        /// <summary>
        /// LiveKit transport config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JoinLivekitRoomRequestTransport Transport { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinLivekitRoomRequest" /> class.
        /// </summary>
        /// <param name="audioConfig">
        /// Configuration for the input audio fed into the avatar's video generator
        /// </param>
        /// <param name="transport">
        /// LiveKit transport config
        /// </param>
        public JoinLivekitRoomRequest(
            global::G.JoinLivekitRoomRequestAudioConfig audioConfig,
            global::G.JoinLivekitRoomRequestTransport transport)
        {
            this.AudioConfig = audioConfig ?? throw new global::System.ArgumentNullException(nameof(audioConfig));
            this.Transport = transport ?? throw new global::System.ArgumentNullException(nameof(transport));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinLivekitRoomRequest" /> class.
        /// </summary>
        public JoinLivekitRoomRequest()
        {
        }
    }
}