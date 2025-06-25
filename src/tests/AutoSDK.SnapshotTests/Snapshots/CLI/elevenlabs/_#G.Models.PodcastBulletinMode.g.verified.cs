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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PodcastBulletinModeTypeJsonConverter))]
        public global::G.PodcastBulletinModeType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        /// <param name="bulletin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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