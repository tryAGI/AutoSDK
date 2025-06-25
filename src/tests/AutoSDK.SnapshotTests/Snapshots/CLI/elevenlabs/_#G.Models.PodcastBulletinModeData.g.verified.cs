//HintName: G.Models.PodcastBulletinModeData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PodcastBulletinModeData
    {
        /// <summary>
        /// The ID of the host voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HostVoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastBulletinModeData" /> class.
        /// </summary>
        /// <param name="hostVoiceId">
        /// The ID of the host voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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