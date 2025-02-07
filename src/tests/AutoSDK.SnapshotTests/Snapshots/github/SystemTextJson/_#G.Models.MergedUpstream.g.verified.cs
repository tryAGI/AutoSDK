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
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MergedUpstreamMergeTypeJsonConverter))]
        public global::G.MergedUpstreamMergeType? MergeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_branch")]
        public string? BaseBranch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergedUpstream" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="mergeType"></param>
        /// <param name="baseBranch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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