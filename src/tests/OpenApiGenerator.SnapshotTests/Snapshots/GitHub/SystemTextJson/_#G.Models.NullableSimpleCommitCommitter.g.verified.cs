//HintName: G.Models.NullableSimpleCommitCommitter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the Git committer
    /// </summary>
    public sealed partial class NullableSimpleCommitCommitter
    {
        /// <summary>
        /// Name of the commit's committer
        /// <br/>Example: Monalisa Octocat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Git email address of the commit's committer
        /// <br/>Example: monalisa.octocat@example.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}