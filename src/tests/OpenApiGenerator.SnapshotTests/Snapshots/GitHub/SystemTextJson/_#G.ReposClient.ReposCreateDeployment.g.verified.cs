//HintName: G.ReposClient.ReposCreateDeployment.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Create a deployment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Deployment> ReposCreateDeploymentAsync(
            string owner,
            string repo,
            ReposCreateDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/deployments", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<Deployment?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a deployment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="@ref"></param>
        /// <param name="task"></param>
        /// <param name="autoMerge"></param>
        /// <param name="requiredContexts"></param>
        /// <param name="payload"></param>
        /// <param name="environment"></param>
        /// <param name="description"></param>
        /// <param name="transientEnvironment"></param>
        /// <param name="productionEnvironment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Deployment> ReposCreateDeploymentAsync(
            string owner,
            string repo,
            string @ref,
            string? task = "deploy",
            bool autoMerge = true,
            global::System.Collections.Generic.IList<string?>? requiredContexts = default,
            global::System.OneOf<object?, string?> payload = default,
            string? environment = "production",
            string? description = "",
            bool transientEnvironment = false,
            bool productionEnvironment = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposCreateDeploymentRequest
            {
                Ref = @ref,
                Task = task,
                AutoMerge = autoMerge,
                RequiredContexts = requiredContexts,
                Payload = payload,
                Environment = environment,
                Description = description,
                TransientEnvironment = transientEnvironment,
                ProductionEnvironment = productionEnvironment,
            };

            return await ReposCreateDeploymentAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}