//HintName: G.Models.ChapterContentBlockInputModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterContentBlockInputModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_type")]
        public global::G.ChapterContentBlockInputModelSubType2? SubType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChapterContentParagraphTtsNodeInputModel> Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_id")]
        public string? BlockId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockInputModel" /> class.
        /// </summary>
        /// <param name="subType"></param>
        /// <param name="nodes"></param>
        /// <param name="blockId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChapterContentBlockInputModel(
            global::System.Collections.Generic.IList<global::G.ChapterContentParagraphTtsNodeInputModel> nodes,
            global::G.ChapterContentBlockInputModelSubType2? subType,
            string? blockId)
        {
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.SubType = subType;
            this.BlockId = blockId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockInputModel" /> class.
        /// </summary>
        public ChapterContentBlockInputModel()
        {
        }
    }
}