//HintName: G.ReposClient.ReposCreateUsingTemplate.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Create a repository using a template
        /// </summary>
        /// <param name="templateOwner"></param>
        /// <param name="templateRepo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FullRepository> ReposCreateUsingTemplateAsync(
            string templateOwner,
            string templateRepo,
            ReposCreateUsingTemplateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{templateOwner}/{templateRepo}/generate", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<FullRepository?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a repository using a template
        /// </summary>
        /// <param name="templateOwner"></param>
        /// <param name="templateRepo"></param>
        /// <param name="owner"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="includeAllBranches"></param>
        /// <param name="@private"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FullRepository> ReposCreateUsingTemplateAsync(
            string templateOwner,
            string templateRepo,
            string name,
            string? owner = default,
            string? description = default,
            bool includeAllBranches = false,
            bool @private = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposCreateUsingTemplateRequest
            {
                Owner = owner,
                Name = name,
                Description = description,
                IncludeAllBranches = includeAllBranches,
                Private = @private,
            };

            return await ReposCreateUsingTemplateAsync(
                templateOwner: templateOwner,
                templateRepo: templateRepo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}