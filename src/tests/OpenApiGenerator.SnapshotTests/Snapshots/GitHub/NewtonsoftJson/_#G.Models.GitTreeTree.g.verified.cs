//HintName: G.Models.GitTreeTree.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitTreeTree
    {
        /// <summary>
        /// <br/>Example: test/file.rb
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// <br/>Example: 040000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// <br/>Example: tree
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <br/>Example: 23f6827669e43831def8a7ad935069c8bd418261
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// <br/>Example: 12
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/owner-482f3203ecf01f67e9deb18e/BBB_Private_Repo/git/blobs/23f6827669e43831def8a7ad935069c8bd418261
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}