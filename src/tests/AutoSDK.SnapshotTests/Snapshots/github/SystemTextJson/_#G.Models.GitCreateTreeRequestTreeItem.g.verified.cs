//HintName: G.Models.GitCreateTreeRequestTreeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitCreateTreeRequestTreeItem
    {
        /// <summary>
        /// The file referenced in the tree.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The file mode; one of `100644` for file (blob), `100755` for executable (blob), `040000` for subdirectory (tree), `160000` for submodule (commit), or `120000` for a blob that specifies the path of a symlink.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GitCreateTreeRequestTreeItemModeJsonConverter))]
        public global::G.GitCreateTreeRequestTreeItemMode? Mode { get; set; }

        /// <summary>
        /// Either `blob`, `tree`, or `commit`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GitCreateTreeRequestTreeItemTypeJsonConverter))]
        public global::G.GitCreateTreeRequestTreeItemType? Type { get; set; }

        /// <summary>
        /// The SHA1 checksum ID of the object in the tree. Also called `tree.sha`. If the value is `null` then the file will be deleted.  <br/>
        ///   <br/>
        /// **Note:** Use either `tree.sha` or `content` to specify the contents of the entry. Using both `tree.sha` and `content` will return an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// The content you want this file to have. GitHub will write this blob out and use that SHA for this entry. Use either this, or `tree.sha`.  <br/>
        ///   <br/>
        /// **Note:** Use either `tree.sha` or `content` to specify the contents of the entry. Using both `tree.sha` and `content` will return an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateTreeRequestTreeItem" /> class.
        /// </summary>
        /// <param name="path">
        /// The file referenced in the tree.
        /// </param>
        /// <param name="mode">
        /// The file mode; one of `100644` for file (blob), `100755` for executable (blob), `040000` for subdirectory (tree), `160000` for submodule (commit), or `120000` for a blob that specifies the path of a symlink.
        /// </param>
        /// <param name="type">
        /// Either `blob`, `tree`, or `commit`.
        /// </param>
        /// <param name="sha">
        /// The SHA1 checksum ID of the object in the tree. Also called `tree.sha`. If the value is `null` then the file will be deleted.  <br/>
        ///   <br/>
        /// **Note:** Use either `tree.sha` or `content` to specify the contents of the entry. Using both `tree.sha` and `content` will return an error.
        /// </param>
        /// <param name="content">
        /// The content you want this file to have. GitHub will write this blob out and use that SHA for this entry. Use either this, or `tree.sha`.  <br/>
        ///   <br/>
        /// **Note:** Use either `tree.sha` or `content` to specify the contents of the entry. Using both `tree.sha` and `content` will return an error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GitCreateTreeRequestTreeItem(
            string? path,
            global::G.GitCreateTreeRequestTreeItemMode? mode,
            global::G.GitCreateTreeRequestTreeItemType? type,
            string? sha,
            string? content)
        {
            this.Path = path;
            this.Mode = mode;
            this.Type = type;
            this.Sha = sha;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateTreeRequestTreeItem" /> class.
        /// </summary>
        public GitCreateTreeRequestTreeItem()
        {
        }
    }
}