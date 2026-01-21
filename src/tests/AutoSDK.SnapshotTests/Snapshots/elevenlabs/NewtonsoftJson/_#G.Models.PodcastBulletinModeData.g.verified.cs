//HintName: G.Models.PodcastBulletinModeData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"host_voice_id":"aw1NgEzBg83R7vgmiJt6"}
    /// </summary>
    public sealed partial class PodcastBulletinModeData
    {
        /// <summary>
        /// The ID of the host voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("host_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string HostVoiceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastBulletinModeData" /> class.
        /// </summary>
        /// <param name="hostVoiceId">
        /// The ID of the host voice.
        /// </param>
        public PodcastBulletinModeData(
            string hostVoiceId)
        {
            this.HostVoiceId = hostVoiceId ?? throw new global::System.ArgumentNullException(nameof(hostVoiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastBulletinModeData" /> class.
        /// </summary>
        public PodcastBulletinModeData()
        {
        }
    }
}