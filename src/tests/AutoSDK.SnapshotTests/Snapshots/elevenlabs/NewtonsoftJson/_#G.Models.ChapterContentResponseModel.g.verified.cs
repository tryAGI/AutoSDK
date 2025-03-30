//HintName: G.Models.ChapterContentResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterContentResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blocks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChapterContentBlockResponseModel> Blocks { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentResponseModel" /> class.
        /// </summary>
        /// <param name="blocks"></param>
        public ChapterContentResponseModel(
            global::System.Collections.Generic.IList<global::G.ChapterContentBlockResponseModel> blocks)
        {
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentResponseModel" /> class.
        /// </summary>
        public ChapterContentResponseModel()
        {
        }
    }
}