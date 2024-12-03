//HintName: G.IGitClient.GitCreateTree.g.cs
#nullable enable

namespace G
{
    public partial interface IGitClient
    {
        /// <summary>
        /// Create a tree<br/>
        /// The tree creation API accepts nested entries. If you specify both a tree and a nested path modifying that tree, this endpoint will overwrite the contents of the tree with the new path contents, and create a new tree structure.<br/>
        /// If you use this endpoint to add, delete, or modify the file contents in a tree, you will need to commit the tree and then update a branch to point to the commit. For more information see "[Create a commit](https://docs.github.com/rest/git/commits#create-a-commit)" and "[Update a reference](https://docs.github.com/rest/git/refs#update-a-reference)."<br/>
        /// Returns an error if you try to delete a file that does not exist.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GitTree> GitCreateTreeAsync(
            string owner,
            string repo,
            global::G.GitCreateTreeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a tree<br/>
        /// The tree creation API accepts nested entries. If you specify both a tree and a nested path modifying that tree, this endpoint will overwrite the contents of the tree with the new path contents, and create a new tree structure.<br/>
        /// If you use this endpoint to add, delete, or modify the file contents in a tree, you will need to commit the tree and then update a branch to point to the commit. For more information see "[Create a commit](https://docs.github.com/rest/git/commits#create-a-commit)" and "[Update a reference](https://docs.github.com/rest/git/refs#update-a-reference)."<br/>
        /// Returns an error if you try to delete a file that does not exist.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="tree">
        /// Objects (of `path`, `mode`, `type`, and `sha`) specifying a tree structure.
        /// </param>
        /// <param name="baseTree">
        /// The SHA1 of an existing Git tree object which will be used as the base for the new tree. If provided, a new Git tree object will be created from entries in the Git tree object pointed to by `base_tree` and entries defined in the `tree` parameter. Entries defined in the `tree` parameter will overwrite items from `base_tree` with the same `path`. If you're creating new changes on a branch, then normally you'd set `base_tree` to the SHA1 of the Git tree object of the current latest commit on the branch you're working on.<br/>
        /// If not provided, GitHub will create a new Git tree object from only the entries defined in the `tree` parameter. If you create a new commit pointing to such a tree, then all files which were a part of the parent commit's tree and were not defined in the `tree` parameter will be listed as deleted by the new commit.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GitTree> GitCreateTreeAsync(
            string owner,
            string repo,
            global::System.Collections.Generic.IList<global::G.GitCreateTreeRequestTreeItem> tree,
            string? baseTree = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}