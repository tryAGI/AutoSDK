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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TagCommit Commit { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/zipball/v0.1
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/zipball/v0.1</example>
        [global::Newtonsoft.Json.JsonProperty("zipball_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ZipballUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/tarball/v0.1
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/tarball/v0.1</example>
        [global::Newtonsoft.Json.JsonProperty("tarball_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TarballUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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