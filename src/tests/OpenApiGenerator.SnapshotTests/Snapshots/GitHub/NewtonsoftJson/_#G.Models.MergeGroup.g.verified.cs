//HintName: G.Models.MergeGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A group of pull requests that the merge queue has grouped together to be merged.
    /// </summary>
    public sealed partial class MergeGroup
    {
        /// <summary>
        /// The SHA of the merge group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeadSha { get; set; } = default!;

        /// <summary>
        /// The full ref of the merge group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeadRef { get; set; } = default!;

        /// <summary>
        /// The SHA of the merge group's parent commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string BaseSha { get; set; } = default!;

        /// <summary>
        /// The full ref of the branch the merge group will be merged into.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string BaseRef { get; set; } = default!;

        /// <summary>
        /// A commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleCommit? HeadCommit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}