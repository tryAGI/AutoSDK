//HintName: G.Models.ChapterStatisticsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"characters_converted":500,"characters_unconverted":1000,"paragraphs_converted":20,"paragraphs_unconverted":10}
    /// </summary>
    public sealed partial class ChapterStatisticsResponseModel
    {
        /// <summary>
        /// The number of unconverted characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_unconverted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharactersUnconverted { get; set; }

        /// <summary>
        /// The number of converted characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_converted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharactersConverted { get; set; }

        /// <summary>
        /// The number of converted paragraphs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paragraphs_converted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ParagraphsConverted { get; set; }

        /// <summary>
        /// The number of unconverted paragraphs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paragraphs_unconverted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ParagraphsUnconverted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterStatisticsResponseModel" /> class.
        /// </summary>
        /// <param name="charactersUnconverted">
        /// The number of unconverted characters.
        /// </param>
        /// <param name="charactersConverted">
        /// The number of converted characters.
        /// </param>
        /// <param name="paragraphsConverted">
        /// The number of converted paragraphs.
        /// </param>
        /// <param name="paragraphsUnconverted">
        /// The number of unconverted paragraphs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChapterStatisticsResponseModel(
            int charactersUnconverted,
            int charactersConverted,
            int paragraphsConverted,
            int paragraphsUnconverted)
        {
            this.CharactersUnconverted = charactersUnconverted;
            this.CharactersConverted = charactersConverted;
            this.ParagraphsConverted = paragraphsConverted;
            this.ParagraphsUnconverted = paragraphsUnconverted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterStatisticsResponseModel" /> class.
        /// </summary>
        public ChapterStatisticsResponseModel()
        {
        }
    }
}