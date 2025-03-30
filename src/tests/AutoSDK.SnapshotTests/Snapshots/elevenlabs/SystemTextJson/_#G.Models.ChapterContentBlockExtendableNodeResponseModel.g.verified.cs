//HintName: G.Models.ChapterContentBlockExtendableNodeResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Not used. Make sure you anticipate new types in the future.
    /// </summary>
    public sealed partial class ChapterContentBlockExtendableNodeResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChapterContentBlockExtendableNodeResponseModelTypeJsonConverter))]
        public global::G.ChapterContentBlockExtendableNodeResponseModelType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockExtendableNodeResponseModel" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChapterContentBlockExtendableNodeResponseModel(
            global::G.ChapterContentBlockExtendableNodeResponseModelType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockExtendableNodeResponseModel" /> class.
        /// </summary>
        public ChapterContentBlockExtendableNodeResponseModel()
        {
        }
    }
}