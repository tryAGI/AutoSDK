//HintName: G.Models.EditChapterResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditChapterResponseModel
    {
        /// <summary>
        /// Example: {"can_be_downloaded":true,"chapter_id":"aw1NgEzBg83R7vgmiJt6","conversion_progress":0.5,"last_conversion_date_unix":1714204800,"last_conversion_error":"Error message","name":"Chapter 1","state":"converting","statistics":{"characters_converted":500,"characters_unconverted":1000,"paragraphs_converted":20,"paragraphs_unconverted":10}}
        /// </summary>
        /// <example>{"can_be_downloaded":true,"chapter_id":"aw1NgEzBg83R7vgmiJt6","conversion_progress":0.5,"last_conversion_date_unix":1714204800,"last_conversion_error":"Error message","name":"Chapter 1","state":"converting","statistics":{"characters_converted":500,"characters_unconverted":1000,"paragraphs_converted":20,"paragraphs_unconverted":10}}</example>
        [global::Newtonsoft.Json.JsonProperty("chapter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChapterWithContentResponseModel Chapter { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditChapterResponseModel" /> class.
        /// </summary>
        /// <param name="chapter">
        /// Example: {"can_be_downloaded":true,"chapter_id":"aw1NgEzBg83R7vgmiJt6","conversion_progress":0.5,"last_conversion_date_unix":1714204800,"last_conversion_error":"Error message","name":"Chapter 1","state":"converting","statistics":{"characters_converted":500,"characters_unconverted":1000,"paragraphs_converted":20,"paragraphs_unconverted":10}}
        /// </param>
        public EditChapterResponseModel(
            global::G.ChapterWithContentResponseModel chapter)
        {
            this.Chapter = chapter ?? throw new global::System.ArgumentNullException(nameof(chapter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditChapterResponseModel" /> class.
        /// </summary>
        public EditChapterResponseModel()
        {
        }
    }
}