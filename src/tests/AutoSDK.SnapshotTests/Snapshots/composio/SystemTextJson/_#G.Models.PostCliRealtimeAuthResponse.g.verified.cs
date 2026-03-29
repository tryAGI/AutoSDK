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
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Auth { get; set; }

        /// <summary>
        /// Channel data for presence channels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_data")]
        public string? ChannelData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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