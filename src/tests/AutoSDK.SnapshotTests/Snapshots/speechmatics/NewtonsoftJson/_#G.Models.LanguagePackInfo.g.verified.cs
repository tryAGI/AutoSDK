//HintName: G.Models.LanguagePackInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Properties of the language pack.
    /// </summary>
    public sealed partial class LanguagePackInfo
    {
        /// <summary>
        /// Full descriptive name of the language, e.g. 'Japanese'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_description")]
        public string? LanguageDescription { get; set; }

        /// <summary>
        /// The character to use to separate words.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_delimiter", Required = global::Newtonsoft.Json.Required.Always)]
        public string WordDelimiter { get; set; } = default!;

        /// <summary>
        /// The direction that words in the language should be written and read in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("writing_direction")]
        public global::G.LanguagePackInfoWritingDirection? WritingDirection { get; set; }

        /// <summary>
        /// Whether or not ITN (inverse text normalization) is available for the language pack.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("itn")]
        public bool? Itn { get; set; }

        /// <summary>
        /// Whether or not language model adaptation has been applied to the language pack.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("adapted")]
        public bool? Adapted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePackInfo" /> class.
        /// </summary>
        /// <param name="wordDelimiter">
        /// The character to use to separate words.
        /// </param>
        /// <param name="languageDescription">
        /// Full descriptive name of the language, e.g. 'Japanese'.
        /// </param>
        /// <param name="writingDirection">
        /// The direction that words in the language should be written and read in.
        /// </param>
        /// <param name="itn">
        /// Whether or not ITN (inverse text normalization) is available for the language pack.
        /// </param>
        /// <param name="adapted">
        /// Whether or not language model adaptation has been applied to the language pack.
        /// </param>
        public LanguagePackInfo(
            string wordDelimiter,
            string? languageDescription,
            global::G.LanguagePackInfoWritingDirection? writingDirection,
            bool? itn,
            bool? adapted)
        {
            this.LanguageDescription = languageDescription;
            this.WordDelimiter = wordDelimiter ?? throw new global::System.ArgumentNullException(nameof(wordDelimiter));
            this.WritingDirection = writingDirection;
            this.Itn = itn;
            this.Adapted = adapted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePackInfo" /> class.
        /// </summary>
        public LanguagePackInfo()
        {
        }
    }
}