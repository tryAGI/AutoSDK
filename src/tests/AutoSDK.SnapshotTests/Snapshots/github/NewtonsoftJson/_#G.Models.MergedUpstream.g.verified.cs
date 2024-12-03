//HintName: G.Models.MergedUpstream.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Results of a successful merge upstream request
    /// </summary>
    public sealed partial class MergedUpstream
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_type")]
        public global::G.MergedUpstreamMergeType? MergeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_branch")]
        public string? BaseBranch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergedUpstream" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="mergeType"></param>
        /// <param name="baseBranch"></param>
        public MergedUpstream(
            string? message,
            global::G.MergedUpstreamMergeType? mergeType,
            string? baseBranch)
        {
            this.Message = message;
            this.MergeType = mergeType;
            this.BaseBranch = baseBranch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergedUpstream" /> class.
        /// </summary>
        public MergedUpstream()
        {
        }
    }
}