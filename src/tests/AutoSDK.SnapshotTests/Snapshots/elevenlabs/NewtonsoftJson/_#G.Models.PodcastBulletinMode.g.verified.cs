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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The voice settings for the bulletin.<br/>
        /// Example: {"host_voice_id":"aw1NgEzBg83R7vgmiJt6"}
        /// </summary>
        /// <example>{"host_voice_id":"aw1NgEzBg83R7vgmiJt6"}</example>
        [global::Newtonsoft.Json.JsonProperty("bulletin", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PodcastBulletinModeData Bulletin { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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