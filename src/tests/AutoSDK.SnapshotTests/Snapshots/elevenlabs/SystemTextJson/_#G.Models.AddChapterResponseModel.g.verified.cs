//HintName: G.Models.AddChapterResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddChapterResponseModel
    {
        /// <summary>
        /// Example: {"can_be_downloaded":true,"chapter_id":"aw1NgEzBg83R7vgmiJt6","content":{"blocks":[]},"conversion_progress":0.5,"last_conversion_date_unix":1714204800,"name":"Chapter 1","state":"default","statistics":{"characters_converted":200,"characters_unconverted":100,"paragraphs_converted":5,"paragraphs_unconverted":3}}
        /// </summary>
        /// <example>{"can_be_downloaded":true,"chapter_id":"aw1NgEzBg83R7vgmiJt6","content":{"blocks":[]},"conversion_progress":0.5,"last_conversion_date_unix":1714204800,"name":"Chapter 1","state":"default","statistics":{"characters_converted":200,"characters_unconverted":100,"paragraphs_converted":5,"paragraphs_unconverted":3}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChapterWithContentResponseModel Chapter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddChapterResponseModel" /> class.
        /// </summary>
        /// <param name="chapter">
        /// Example: {"can_be_downloaded":true,"chapter_id":"aw1NgEzBg83R7vgmiJt6","content":{"blocks":[]},"conversion_progress":0.5,"last_conversion_date_unix":1714204800,"name":"Chapter 1","state":"default","statistics":{"characters_converted":200,"characters_unconverted":100,"paragraphs_converted":5,"paragraphs_unconverted":3}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddChapterResponseModel(
            global::G.ChapterWithContentResponseModel chapter)
        {
            this.Chapter = chapter ?? throw new global::System.ArgumentNullException(nameof(chapter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddChapterResponseModel" /> class.
        /// </summary>
        public AddChapterResponseModel()
        {
        }
    }
}