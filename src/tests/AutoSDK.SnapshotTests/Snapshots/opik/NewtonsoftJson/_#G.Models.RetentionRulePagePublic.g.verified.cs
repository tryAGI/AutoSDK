//HintName: G.Models.RetentionRulePagePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetentionRulePagePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::System.Collections.Generic.IList<global::G.RetentionRulePublic>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public long? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionRulePagePublic" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="total"></param>
        public RetentionRulePagePublic(
            global::System.Collections.Generic.IList<global::G.RetentionRulePublic>? content,
            int? page,
            int? size,
            long? total)
        {
            this.Content = content;
            this.Page = page;
            this.Size = size;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionRulePagePublic" /> class.
        /// </summary>
        public RetentionRulePagePublic()
        {
        }
    }
}