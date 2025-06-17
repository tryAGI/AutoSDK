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
        [global::Newtonsoft.Json.JsonProperty("sub_type")]
        public global::G.ChapterContentBlockInputModelSubType? SubType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nodes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChapterContentParagraphTtsNodeInputModel> Nodes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_id")]
        public string? BlockId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockInputModel" /> class.
        /// </summary>
        /// <param name="subType"></param>
        /// <param name="nodes"></param>
        /// <param name="blockId"></param>
        public ChapterContentBlockInputModel(
            global::System.Collections.Generic.IList<global::G.ChapterContentParagraphTtsNodeInputModel> nodes,
            global::G.ChapterContentBlockInputModelSubType? subType,
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