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
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_global_styles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PositiveGlobalStyles { get; set; }

        /// <summary>
        /// The styles and musical directions that should not be present in the entire song. Use English language for best result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_global_styles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NegativeGlobalStyles { get; set; }

        /// <summary>
        /// The sections of the song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SongSection> Sections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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