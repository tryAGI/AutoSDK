//HintName: G.Models.MusicPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]}
    /// </summary>
    public sealed partial class MusicPrompt
    {
        /// <summary>
        /// The styles and musical directions that should be present in the entire song. Use English language for best result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("positive_global_styles", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> PositiveGlobalStyles { get; set; } = default!;

        /// <summary>
        /// The styles and musical directions that should not be present in the entire song. Use English language for best result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negative_global_styles", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> NegativeGlobalStyles { get; set; } = default!;

        /// <summary>
        /// The sections of the song.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sections", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SongSection> Sections { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicPrompt" /> class.
        /// </summary>
        /// <param name="positiveGlobalStyles">
        /// The styles and musical directions that should be present in the entire song. Use English language for best result.
        /// </param>
        /// <param name="negativeGlobalStyles">
        /// The styles and musical directions that should not be present in the entire song. Use English language for best result.
        /// </param>
        /// <param name="sections">
        /// The sections of the song.
        /// </param>
        public MusicPrompt(
            global::System.Collections.Generic.IList<string> positiveGlobalStyles,
            global::System.Collections.Generic.IList<string> negativeGlobalStyles,
            global::System.Collections.Generic.IList<global::G.SongSection> sections)
        {
            this.PositiveGlobalStyles = positiveGlobalStyles ?? throw new global::System.ArgumentNullException(nameof(positiveGlobalStyles));
            this.NegativeGlobalStyles = negativeGlobalStyles ?? throw new global::System.ArgumentNullException(nameof(negativeGlobalStyles));
            this.Sections = sections ?? throw new global::System.ArgumentNullException(nameof(sections));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicPrompt" /> class.
        /// </summary>
        public MusicPrompt()
        {
        }
    }
}