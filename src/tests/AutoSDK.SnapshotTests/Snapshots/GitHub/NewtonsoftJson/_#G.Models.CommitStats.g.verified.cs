//HintName: G.Models.CommitStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommitStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additions")]
        public int? Additions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deletions")]
        public int? Deletions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitStats" /> class.
        /// </summary>
        /// <param name="additions"></param>
        /// <param name="deletions"></param>
        /// <param name="total"></param>
        public CommitStats(
            int? additions,
            int? deletions,
            int? total)
        {
            this.Additions = additions;
            this.Deletions = deletions;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitStats" /> class.
        /// </summary>
        public CommitStats()
        {
        }
    }
}