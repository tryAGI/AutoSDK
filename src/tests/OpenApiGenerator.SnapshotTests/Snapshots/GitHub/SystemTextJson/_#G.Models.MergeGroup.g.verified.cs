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
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// The full ref of the merge group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadRef { get; set; }

        /// <summary>
        /// The SHA of the merge group's parent commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseSha { get; set; }

        /// <summary>
        /// The full ref of the branch the merge group will be merged into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseRef { get; set; }

        /// <summary>
        /// A commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required SimpleCommit HeadCommit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}