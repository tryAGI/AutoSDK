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
        [global::Newtonsoft.Json.JsonProperty("characters_unconverted", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharactersUnconverted { get; set; } = default!;

        /// <summary>
        /// The number of converted characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("characters_converted", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharactersConverted { get; set; } = default!;

        /// <summary>
        /// The number of converted paragraphs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("paragraphs_converted", Required = global::Newtonsoft.Json.Required.Always)]
        public int ParagraphsConverted { get; set; } = default!;

        /// <summary>
        /// The number of unconverted paragraphs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("paragraphs_unconverted", Required = global::Newtonsoft.Json.Required.Always)]
        public int ParagraphsUnconverted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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