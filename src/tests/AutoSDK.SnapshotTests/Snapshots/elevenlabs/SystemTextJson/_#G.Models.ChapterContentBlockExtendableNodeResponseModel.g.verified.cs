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
        /// <default>"_other"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "_other";

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
            string type = "_other")
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