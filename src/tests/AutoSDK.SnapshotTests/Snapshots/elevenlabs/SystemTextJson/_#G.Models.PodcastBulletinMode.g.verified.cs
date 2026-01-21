//HintName: G.Models.PodcastBulletinMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"bulletin":{"host_voice_id":"aw1NgEzBg83R7vgmiJt6"},"type":"bulletin"}
    /// </summary>
    public sealed partial class PodcastBulletinMode
    {
        /// <summary>
        /// The type of podcast to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The voice settings for the bulletin.<br/>
        /// Example: {"host_voice_id":"aw1NgEzBg83R7vgmiJt6"}
        /// </summary>
        /// <example>{"host_voice_id":"aw1NgEzBg83R7vgmiJt6"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulletin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PodcastBulletinModeData Bulletin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastBulletinMode" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of podcast to create.
        /// </param>
        /// <param name="bulletin">
        /// The voice settings for the bulletin.<br/>
        /// Example: {"host_voice_id":"aw1NgEzBg83R7vgmiJt6"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PodcastBulletinMode(
            string type,
            global::G.PodcastBulletinModeData bulletin)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Bulletin = bulletin ?? throw new global::System.ArgumentNullException(nameof(bulletin));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastBulletinMode" /> class.
        /// </summary>
        public PodcastBulletinMode()
        {
        }
    }
}