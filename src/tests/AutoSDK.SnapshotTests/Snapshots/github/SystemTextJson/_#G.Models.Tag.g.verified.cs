//HintName: G.Models.Tag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tag
    /// </summary>
    public sealed partial class Tag
    {
        /// <summary>
        /// Example: v0.1
        /// </summary>
        /// <example>v0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TagCommit Commit { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/zipball/v0.1
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/zipball/v0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("zipball_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ZipballUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/tarball/v0.1
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/tarball/v0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tarball_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TarballUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: v0.1
        /// </param>
        /// <param name="commit"></param>
        /// <param name="zipballUrl">
        /// Example: https://github.com/octocat/Hello-World/zipball/v0.1
        /// </param>
        /// <param name="tarballUrl">
        /// Example: https://github.com/octocat/Hello-World/tarball/v0.1
        /// </param>
        /// <param name="nodeId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Tag(
            string name,
            global::G.TagCommit commit,
            string zipballUrl,
            string tarballUrl,
            string nodeId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.ZipballUrl = zipballUrl ?? throw new global::System.ArgumentNullException(nameof(zipballUrl));
            this.TarballUrl = tarballUrl ?? throw new global::System.ArgumentNullException(nameof(tarballUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        public Tag()
        {
        }
    }
}