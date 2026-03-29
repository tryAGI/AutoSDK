//HintName: G.Models.OpenGetSpaceFolderData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenGetSpaceFolderData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::System.Collections.Generic.IList<global::G.FolderSimpleInfo>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGetSpaceFolderData" /> class.
        /// </summary>
        /// <param name="hasMore"></param>
        /// <param name="items"></param>
        /// <param name="totalCount"></param>
        public OpenGetSpaceFolderData(
            bool? hasMore,
            global::System.Collections.Generic.IList<global::G.FolderSimpleInfo>? items,
            int? totalCount)
        {
            this.HasMore = hasMore;
            this.Items = items;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGetSpaceFolderData" /> class.
        /// </summary>
        public OpenGetSpaceFolderData()
        {
        }
    }
}