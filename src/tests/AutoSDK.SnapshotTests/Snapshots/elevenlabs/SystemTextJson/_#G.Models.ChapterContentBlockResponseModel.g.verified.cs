//HintName: G.Models.ChapterContentBlockResponseModel.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterContentBlockResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlockId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChapterContentBlockTtsNodeResponseModel, global::G.ChapterContentBlockExtendableNodeResponseModel>> Nodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockResponseModel" /> class.
        /// </summary>
        /// <param name="blockId"></param>
        /// <param name="nodes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChapterContentBlockResponseModel(
            string blockId,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChapterContentBlockTtsNodeResponseModel, global::G.ChapterContentBlockExtendableNodeResponseModel>> nodes)
        {
            this.BlockId = blockId ?? throw new global::System.ArgumentNullException(nameof(blockId));
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockResponseModel" /> class.
        /// </summary>
        public ChapterContentBlockResponseModel()
        {
        }
    }
}