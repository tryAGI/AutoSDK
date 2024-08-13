//HintName: G.ReposClient.ReposCreateUsingTemplate.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateUsingTemplateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string templateOwner,
            ref string templateRepo,
            global::G.ReposCreateUsingTemplateRequest request);
        partial void PrepareReposCreateUsingTemplateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string templateOwner,
            string templateRepo,
            global::G.ReposCreateUsingTemplateRequest request);
        partial void ProcessReposCreateUsingTemplateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateUsingTemplateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a repository using a template<br/>
        /// Creates a new repository using a repository template. Use the `template_owner` and `template_repo` route parameters to specify the repository to use as the template. If the repository is not public, the authenticated user must own or be a member of an organization that owns the repository. To check if a repository is available to use as a template, get the repository's information using the [Get a repository](https://docs.github.com/rest/repos/repos#get-a-repository) endpoint and check that the `is_template` key is `true`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `public_repo` or `repo` scope to create a public repository, and `repo` scope to create a private repository.
        /// </summary>
        /// <param name="templateOwner"></param>
        /// <param name="templateRepo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FullRepository> ReposCreateUsingTemplateAsync(
            string templateOwner,
            string templateRepo,
            global::G.ReposCreateUsingTemplateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposCreateUsingTemplateArguments(
                httpClient: _httpClient,
                templateOwner: ref templateOwner,
                templateRepo: ref templateRepo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{templateOwner}/{templateRepo}/generate", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposCreateUsingTemplateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                templateOwner: templateOwner,
                templateRepo: templateRepo,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposCreateUsingTemplateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposCreateUsingTemplateResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.FullRepository?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a repository using a template<br/>
        /// Creates a new repository using a repository template. Use the `template_owner` and `template_repo` route parameters to specify the repository to use as the template. If the repository is not public, the authenticated user must own or be a member of an organization that owns the repository. To check if a repository is available to use as a template, get the repository's information using the [Get a repository](https://docs.github.com/rest/repos/repos#get-a-repository) endpoint and check that the `is_template` key is `true`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `public_repo` or `repo` scope to create a public repository, and `repo` scope to create a private repository.
        /// </summary>
        /// <param name="templateOwner"></param>
        /// <param name="templateRepo"></param>
        /// <param name="owner">
        /// The organization or person who will own the new repository. To create a new repository in an organization, the authenticated user must be a member of the specified organization.
        /// </param>
        /// <param name="name">
        /// The name of the new repository.
        /// </param>
        /// <param name="description">
        /// A short description of the new repository.
        /// </param>
        /// <param name="includeAllBranches">
        /// Set to `true` to include the directory structure and files from all branches in the template repository, and not just the default branch. Default: `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="private">
        /// Either `true` to create a new private repository or `false` to create a new public one.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FullRepository> ReposCreateUsingTemplateAsync(
            string templateOwner,
            string templateRepo,
            string name,
            string? owner = default,
            string? description = default,
            bool includeAllBranches = false,
            bool @private = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposCreateUsingTemplateRequest
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