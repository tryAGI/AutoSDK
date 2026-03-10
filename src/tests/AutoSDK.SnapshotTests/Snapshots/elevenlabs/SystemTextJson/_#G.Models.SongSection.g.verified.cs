//HintName: G.Models.SongSection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SongSection
    {
        /// <summary>
        /// The name of the section. Must be between 1 and 100 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SectionName { get; set; }

        /// <summary>
        /// The styles and musical directions that should be present in this section. Use English language for best result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_local_styles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PositiveLocalStyles { get; set; }

        /// <summary>
        /// The styles and musical directions that should not be present in this section. Use English language for best result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_local_styles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NegativeLocalStyles { get; set; }

        /// <summary>
        /// The duration of the section in milliseconds. Must be between 3000ms and 120000ms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// The lyrics of the section. Max 200 characters per line.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Lines { get; set; }

        /// <summary>
        /// Optional source to extract the section from. Used for inpainting. Only available to enterprise clients with access to the inpainting feature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_from")]
        public global::G.SectionSource? SourceFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SongSection" /> class.
        /// </summary>
        /// <param name="sectionName">
        /// The name of the section. Must be between 1 and 100 characters.
        /// </param>
        /// <param name="positiveLocalStyles">
        /// The styles and musical directions that should be present in this section. Use English language for best result.
        /// </param>
        /// <param name="negativeLocalStyles">
        /// The styles and musical directions that should not be present in this section. Use English language for best result.
        /// </param>
        /// <param name="durationMs">
        /// The duration of the section in milliseconds. Must be between 3000ms and 120000ms.
        /// </param>
        /// <param name="lines">
        /// The lyrics of the section. Max 200 characters per line.
        /// </param>
        /// <param name="sourceFrom">
        /// Optional source to extract the section from. Used for inpainting. Only available to enterprise clients with access to the inpainting feature.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SongSection(
            string sectionName,
            global::System.Collections.Generic.IList<string> positiveLocalStyles,
            global::System.Collections.Generic.IList<string> negativeLocalStyles,
            int durationMs,
            global::System.Collections.Generic.IList<string> lines,
            global::G.SectionSource? sourceFrom)
        {
            this.SectionName = sectionName ?? throw new global::System.ArgumentNullException(nameof(sectionName));
            this.PositiveLocalStyles = positiveLocalStyles ?? throw new global::System.ArgumentNullException(nameof(positiveLocalStyles));
            this.NegativeLocalStyles = negativeLocalStyles ?? throw new global::System.ArgumentNullException(nameof(negativeLocalStyles));
            this.DurationMs = durationMs;
            this.Lines = lines ?? throw new global::System.ArgumentNullException(nameof(lines));
            this.SourceFrom = sourceFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SongSection" /> class.
        /// </summary>
        public SongSection()
        {
        }
    }
}