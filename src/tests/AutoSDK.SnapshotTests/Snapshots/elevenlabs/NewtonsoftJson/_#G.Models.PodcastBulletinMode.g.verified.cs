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
        /// <default>"bulletin"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "bulletin";

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
            global::G.PodcastBulletinModeData bulletin,
            string type = "bulletin")
        {
            this.Bulletin = bulletin ?? throw new global::System.ArgumentNullException(nameof(bulletin));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastBulletinMode" /> class.
        /// </summary>
        public PodcastBulletinMode()
        {
        }
    }
}