//HintName: G.Models.PodcastConversationModeData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PodcastConversationModeData
    {
        /// <summary>
        /// The ID of the host voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("host_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string HostVoiceId { get; set; } = default!;

        /// <summary>
        /// The ID of the guest voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guest_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GuestVoiceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastConversationModeData" /> class.
        /// </summary>
        /// <param name="hostVoiceId">
        /// The ID of the host voice.
        /// </param>
        /// <param name="guestVoiceId">
        /// The ID of the guest voice.
        /// </param>
        public PodcastConversationModeData(
            string hostVoiceId,
            string guestVoiceId)
        {
            this.HostVoiceId = hostVoiceId ?? throw new global::System.ArgumentNullException(nameof(hostVoiceId));
            this.GuestVoiceId = guestVoiceId ?? throw new global::System.ArgumentNullException(nameof(guestVoiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastConversationModeData" /> class.
        /// </summary>
        public PodcastConversationModeData()
        {
        }
    }
}