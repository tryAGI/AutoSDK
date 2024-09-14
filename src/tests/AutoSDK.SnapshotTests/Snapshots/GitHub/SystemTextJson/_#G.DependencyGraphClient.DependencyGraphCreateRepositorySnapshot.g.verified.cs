//HintName: G.DependencyGraphClient.DependencyGraphCreateRepositorySnapshot.g.cs

#nullable enable

namespace G
{
    public partial class DependencyGraphClient
    {
        partial void PrepareDependencyGraphCreateRepositorySnapshotArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.Snapshot request);
        partial void PrepareDependencyGraphCreateRepositorySnapshotRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.Snapshot request);
        partial void ProcessDependencyGraphCreateRepositorySnapshotResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDependencyGraphCreateRepositorySnapshotResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a snapshot of dependencies for a repository<br/>
        /// Create a new snapshot of a repository's dependencies.<br/>
        /// The authenticated user must have access to the repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DependencyGraphCreateRepositorySnapshotResponse> DependencyGraphCreateRepositorySnapshotAsync(
            string owner,
            string repo,
            global::G.Snapshot request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareDependencyGraphCreateRepositorySnapshotArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/dependency-graph/snapshots", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDependencyGraphCreateRepositorySnapshotRequest(
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
            ProcessDependencyGraphCreateRepositorySnapshotResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDependencyGraphCreateRepositorySnapshotResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.DependencyGraphCreateRepositorySnapshotResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a snapshot of dependencies for a repository<br/>
        /// Create a new snapshot of a repository's dependencies.<br/>
        /// The authenticated user must have access to the repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="version">
        /// The version of the repository snapshot submission.
        /// </param>
        /// <param name="job"></param>
        /// <param name="sha">
        /// The commit SHA associated with this dependency snapshot. Maximum length: 40 characters.<br/>
        /// Example: ddc951f4b1293222421f2c8df679786153acf689
        /// </param>
        /// <param name="ref">
        /// The repository branch that triggered this snapshot.<br/>
        /// Example: refs/heads/main
        /// </param>
        /// <param name="detector">
        /// A description of the detector used.
        /// </param>
        /// <param name="metadata">
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </param>
        /// <param name="manifests">
        /// A collection of package manifests, which are a collection of related dependencies declared in a file or representing a logical group of dependencies.
        /// </param>
        /// <param name="scanned">
        /// The time at which the snapshot was scanned.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DependencyGraphCreateRepositorySnapshotResponse> DependencyGraphCreateRepositorySnapshotAsync(
            string owner,
            string repo,
            int version,
            global::G.SnapshotJob job,
            string sha,
            string @ref,
            global::G.SnapshotDetector detector,
            global::System.DateTime scanned,
            global::G.Metadata? metadata = default,
            global::G.SnapshotManifests? manifests = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.Snapshot
            {
                Version = version,
                Job = job,
                Sha = sha,
                Ref = @ref,
                Detector = detector,
                Metadata = metadata,
                Manifests = manifests,
                Scanned = scanned,
            };

            return await DependencyGraphCreateRepositorySnapshotAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}