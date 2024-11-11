//HintName: G.Models.ChapterStatisticsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterStatisticsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_unconverted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharactersUnconverted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_converted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharactersConverted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paragraphs_converted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ParagraphsConverted { get; set; }

        /// <summary>
        /// 
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
        /// <param name="charactersUnconverted"></param>
        /// <param name="charactersConverted"></param>
        /// <param name="paragraphsConverted"></param>
        /// <param name="paragraphsUnconverted"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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