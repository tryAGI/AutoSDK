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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChapterResponseModel Chapter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddChapterResponseModel" /> class.
        /// </summary>
        /// <param name="chapter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddChapterResponseModel(
            global::G.ChapterResponseModel chapter)
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