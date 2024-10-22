//HintName: G.MigrationsClient.MigrationsMapCommitAuthor.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        partial void PrepareMigrationsMapCommitAuthorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int authorId,
            global::G.MigrationsMapCommitAuthorRequest request);
        partial void PrepareMigrationsMapCommitAuthorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int authorId,
            global::G.MigrationsMapCommitAuthorRequest request);
        partial void ProcessMigrationsMapCommitAuthorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMigrationsMapCommitAuthorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Map a commit author<br/>
        /// Update an author's identity for the import. Your application can continue updating authors any time before you push<br/>
        /// new commits to the repository.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="authorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.PorterAuthor> MigrationsMapCommitAuthorAsync(
            string owner,
            string repo,
            int authorId,
            global::G.MigrationsMapCommitAuthorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMigrationsMapCommitAuthorArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                authorId: ref authorId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/import/authors/{authorId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMigrationsMapCommitAuthorRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                authorId: authorId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMigrationsMapCommitAuthorResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessMigrationsMapCommitAuthorResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.PorterAuthor.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Map a commit author<br/>
        /// Update an author's identity for the import. Your application can continue updating authors any time before you push<br/>
        /// new commits to the repository.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="authorId"></param>
        /// <param name="email">
        /// The new Git author email.
        /// </param>
        /// <param name="name">
        /// The new Git author name.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.PorterAuthor> MigrationsMapCommitAuthorAsync(
            string owner,
            string repo,
            int authorId,
            string? email = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.MigrationsMapCommitAuthorRequest
            {
                Email = email,
                Name = name,
            };

            return await MigrationsMapCommitAuthorAsync(
                owner: owner,
                repo: repo,
                authorId: authorId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}