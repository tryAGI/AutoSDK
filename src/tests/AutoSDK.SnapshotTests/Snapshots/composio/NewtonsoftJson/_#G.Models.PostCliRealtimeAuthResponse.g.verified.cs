//HintName: G.Models.PostCliRealtimeAuthResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostCliRealtimeAuthResponse
    {
        /// <summary>
        /// The authentication string for Pusher
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth", Required = global::Newtonsoft.Json.Required.Always)]
        public string Auth { get; set; } = default!;

        /// <summary>
        /// Channel data for presence channels
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_data")]
        public string? ChannelData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliRealtimeAuthResponse" /> class.
        /// </summary>
        /// <param name="auth">
        /// The authentication string for Pusher
        /// </param>
        /// <param name="channelData">
        /// Channel data for presence channels
        /// </param>
        public PostCliRealtimeAuthResponse(
            string auth,
            string? channelData)
        {
            this.Auth = auth ?? throw new global::System.ArgumentNullException(nameof(auth));
            this.ChannelData = channelData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliRealtimeAuthResponse" /> class.
        /// </summary>
        public PostCliRealtimeAuthResponse()
        {
        }
    }
}