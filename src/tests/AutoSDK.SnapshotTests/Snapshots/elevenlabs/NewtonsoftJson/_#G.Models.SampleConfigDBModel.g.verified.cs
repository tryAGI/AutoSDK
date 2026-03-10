//HintName: G.Models.SampleConfigDBModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SampleConfigDBModel
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_sample")]
        public bool? IsSample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_type")]
        public global::G.SampleConfigDBModelParentType2? ParentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapter_ids")]
        public global::System.Collections.Generic.IList<string>? ChapterIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleConfigDBModel" /> class.
        /// </summary>
        /// <param name="isSample">
        /// Default Value: false
        /// </param>
        /// <param name="parentId"></param>
        /// <param name="parentType"></param>
        /// <param name="chapterIds"></param>
        public SampleConfigDBModel(
            bool? isSample,
            string? parentId,
            global::G.SampleConfigDBModelParentType2? parentType,
            global::System.Collections.Generic.IList<string>? chapterIds)
        {
            this.IsSample = isSample;
            this.ParentId = parentId;
            this.ParentType = parentType;
            this.ChapterIds = chapterIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleConfigDBModel" /> class.
        /// </summary>
        public SampleConfigDBModel()
        {
        }
    }
}