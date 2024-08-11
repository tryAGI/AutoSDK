//HintName: G.GitClient.GitCreateTree.g.cs

#nullable enable

namespace G
{
    public partial class GitClient
    {
        partial void PrepareGitCreateTreeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.GitCreateTreeRequest request);
        partial void PrepareGitCreateTreeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.GitCreateTreeRequest request);
        partial void ProcessGitCreateTreeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGitCreateTreeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GitTree> GitCreateTreeAsync(
            string owner,
            string repo,
            global::G.GitCreateTreeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareGitCreateTreeArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/git/trees", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGitCreateTreeRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGitCreateTreeResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGitCreateTreeResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GitTree?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

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
        public async global::System.Threading.Tasks.Task<global::G.GitTree> GitCreateTreeAsync(
            string owner,
            string repo,
            global::System.Collections.Generic.IList<global::G.GitCreateTreeRequestTreeItem> tree,
            string? baseTree = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.GitCreateTreeRequest
            {
                Tree = tree,
                BaseTree = baseTree,
            };

            return await GitCreateTreeAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}