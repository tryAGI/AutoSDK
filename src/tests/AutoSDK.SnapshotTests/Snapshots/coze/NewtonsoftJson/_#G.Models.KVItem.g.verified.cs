//HintName: G.Models.KVItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KVItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keyword")]
        public string? Keyword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KVItem" /> class.
        /// </summary>
        /// <param name="createTime"></param>
        /// <param name="keyword"></param>
        /// <param name="updateTime"></param>
        /// <param name="value"></param>
        public KVItem(
            int? createTime,
            string? keyword,
            int? updateTime,
            string? value)
        {
            this.CreateTime = createTime;
            this.Keyword = keyword;
            this.UpdateTime = updateTime;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KVItem" /> class.
        /// </summary>
        public KVItem()
        {
        }
    }
}