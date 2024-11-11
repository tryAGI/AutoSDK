//HintName: G.Models.GitTreeTreeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitTreeTreeItem
    {
        /// <summary>
        /// Example: test/file.rb
        /// </summary>
        /// <example>test/file.rb</example>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Example: 040000
        /// </summary>
        /// <example>040000</example>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Example: tree
        /// </summary>
        /// <example>tree</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Example: 23f6827669e43831def8a7ad935069c8bd418261
        /// </summary>
        /// <example>23f6827669e43831def8a7ad935069c8bd418261</example>
        [global::Newtonsoft.Json.JsonProperty("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/owner-482f3203ecf01f67e9deb18e/BBB_Private_Repo/git/blobs/23f6827669e43831def8a7ad935069c8bd418261
        /// </summary>
        /// <example>https://api.github.com/repos/owner-482f3203ecf01f67e9deb18e/BBB_Private_Repo/git/blobs/23f6827669e43831def8a7ad935069c8bd418261</example>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitTreeTreeItem" /> class.
        /// </summary>
        /// <param name="path">
        /// Example: test/file.rb
        /// </param>
        /// <param name="mode">
        /// Example: 040000
        /// </param>
        /// <param name="type">
        /// Example: tree
        /// </param>
        /// <param name="sha">
        /// Example: 23f6827669e43831def8a7ad935069c8bd418261
        /// </param>
        /// <param name="size">
        /// Example: 12
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/owner-482f3203ecf01f67e9deb18e/BBB_Private_Repo/git/blobs/23f6827669e43831def8a7ad935069c8bd418261
        /// </param>
        public GitTreeTreeItem(
            string? path,
            string? mode,
            string? type,
            string? sha,
            int? size,
            string? url)
        {
            this.Path = path;
            this.Mode = mode;
            this.Type = type;
            this.Sha = sha;
            this.Size = size;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitTreeTreeItem" /> class.
        /// </summary>
        public GitTreeTreeItem()
        {
        }
    }
}