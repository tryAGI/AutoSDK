//HintName: G.Models.GitCreateTreeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitCreateTreeRequest
    {
        /// <summary>
        /// Objects (of `path`, `mode`, `type`, and `sha`) specifying a tree structure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GitCreateTreeRequestTreeItem> Tree { get; set; }

        /// <summary>
        /// The SHA1 of an existing Git tree object which will be used as the base for the new tree. If provided, a new Git tree object will be created from entries in the Git tree object pointed to by `base_tree` and entries defined in the `tree` parameter. Entries defined in the `tree` parameter will overwrite items from `base_tree` with the same `path`. If you're creating new changes on a branch, then normally you'd set `base_tree` to the SHA1 of the Git tree object of the current latest commit on the branch you're working on.<br/>
        /// If not provided, GitHub will create a new Git tree object from only the entries defined in the `tree` parameter. If you create a new commit pointing to such a tree, then all files which were a part of the parent commit's tree and were not defined in the `tree` parameter will be listed as deleted by the new commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_tree")]
        public string? BaseTree { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateTreeRequest" /> class.
        /// </summary>
        /// <param name="tree">
        /// Objects (of `path`, `mode`, `type`, and `sha`) specifying a tree structure.
        /// </param>
        /// <param name="baseTree">
        /// The SHA1 of an existing Git tree object which will be used as the base for the new tree. If provided, a new Git tree object will be created from entries in the Git tree object pointed to by `base_tree` and entries defined in the `tree` parameter. Entries defined in the `tree` parameter will overwrite items from `base_tree` with the same `path`. If you're creating new changes on a branch, then normally you'd set `base_tree` to the SHA1 of the Git tree object of the current latest commit on the branch you're working on.<br/>
        /// If not provided, GitHub will create a new Git tree object from only the entries defined in the `tree` parameter. If you create a new commit pointing to such a tree, then all files which were a part of the parent commit's tree and were not defined in the `tree` parameter will be listed as deleted by the new commit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GitCreateTreeRequest(
            global::System.Collections.Generic.IList<global::G.GitCreateTreeRequestTreeItem> tree,
            string? baseTree)
        {
            this.Tree = tree ?? throw new global::System.ArgumentNullException(nameof(tree));
            this.BaseTree = baseTree;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateTreeRequest" /> class.
        /// </summary>
        public GitCreateTreeRequest()
        {
        }
    }
}