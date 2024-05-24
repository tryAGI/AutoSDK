//HintName: G.DependencyGraphClient.DependencyGraphCreateRepositorySnapshot.g.cs

#nullable enable

namespace G
{
    public partial class DependencyGraphClient
    {
        /// <summary>
        /// Create a snapshot of dependencies for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DependencyGraphCreateRepositorySnapshotAsync(
            string owner,
            string repo,
            Snapshot request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/dependency-graph/snapshots", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Create a snapshot of dependencies for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="version"></param>
        /// <param name="job"></param>
        /// <param name="sha"></param>
        /// <param name="@ref"></param>
        /// <param name="detector"></param>
        /// <param name="metadata"></param>
        /// <param name="manifests"></param>
        /// <param name="scanned"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DependencyGraphCreateRepositorySnapshotAsync(
            string owner,
            string repo,
            int version,
            SnapshotJob job,
            string sha,
            string @ref,
            SnapshotDetector detector,
            global::System.DateTime scanned,
            Metadata? metadata = default,
            object? manifests = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new Snapshot
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

            await DependencyGraphCreateRepositorySnapshotAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}