//HintName: G.Models.GistCommitChangeStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GistCommitChangeStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistCommitChangeStatus" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="additions"></param>
        /// <param name="deletions"></param>
        public GistCommitChangeStatus(
            int? total,
            int? additions,
            int? deletions)
        {
            this.Total = total;
            this.Additions = additions;
            this.Deletions = deletions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistCommitChangeStatus" /> class.
        /// </summary>
        public GistCommitChangeStatus()
        {
        }
    }
}