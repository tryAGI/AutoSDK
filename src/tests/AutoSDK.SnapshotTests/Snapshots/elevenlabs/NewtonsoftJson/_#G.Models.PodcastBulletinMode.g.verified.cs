//HintName: G.Models.PodcastBulletinMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PodcastBulletinMode
    {
        /// <summary>
        /// The type of podcast to create.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PodcastBulletinModeType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        /// <param name="bulletin"></param>
        public PodcastBulletinMode(
            global::G.PodcastBulletinModeData bulletin,
            global::G.PodcastBulletinModeType type)
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