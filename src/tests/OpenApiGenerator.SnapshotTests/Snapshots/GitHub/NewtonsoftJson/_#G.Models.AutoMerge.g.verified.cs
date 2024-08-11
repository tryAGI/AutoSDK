//HintName: G.Models.AutoMerge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of auto merging a pull request.
    /// </summary>
    public sealed partial class AutoMerge
    {
        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser EnabledBy { get; set; } = default!;

        /// <summary>
        /// The merge method to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_method", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AutoMergeMergeMethod MergeMethod { get; set; } = default!;

        /// <summary>
        /// Title for the merge commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_title", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitTitle { get; set; } = default!;

        /// <summary>
        /// Commit message for the merge commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitMessage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}