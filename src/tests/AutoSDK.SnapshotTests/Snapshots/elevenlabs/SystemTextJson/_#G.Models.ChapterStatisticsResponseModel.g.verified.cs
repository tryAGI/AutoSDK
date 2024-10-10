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
    }
}