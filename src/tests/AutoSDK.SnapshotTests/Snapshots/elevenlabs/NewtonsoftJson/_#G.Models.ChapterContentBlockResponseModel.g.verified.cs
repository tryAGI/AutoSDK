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
        [global::Newtonsoft.Json.JsonProperty("block_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlockId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nodes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChapterContentBlockTtsNodeResponseModel, global::G.ChapterContentBlockExtendableNodeResponseModel>> Nodes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockResponseModel" /> class.
        /// </summary>
        /// <param name="blockId"></param>
        /// <param name="nodes"></param>
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