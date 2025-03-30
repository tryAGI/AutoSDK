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
        /// 
        /// </summary>
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
        /// <param name="chapter"></param>
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