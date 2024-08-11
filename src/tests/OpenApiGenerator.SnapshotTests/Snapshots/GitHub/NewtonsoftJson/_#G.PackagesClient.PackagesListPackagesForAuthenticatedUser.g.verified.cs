//HintName: G.PackagesClient.PackagesListPackagesForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        partial void PreparePackagesListPackagesForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.PackagesListPackagesForAuthenticatedUserPackageType packageType,
            ref global::G.PackagesListPackagesForAuthenticatedUserVisibility? visibility,
            ref int page,
            ref int perPage);
        partial void PreparePackagesListPackagesForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PackagesListPackagesForAuthenticatedUserPackageType packageType,
            global::G.PackagesListPackagesForAuthenticatedUserVisibility? visibility,
            int page,
            int perPage);
        partial void ProcessPackagesListPackagesForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPackagesListPackagesForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List packages for the authenticated user's namespace<br/>
        /// Lists packages owned by the authenticated user within the user's namespace.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="visibility"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Package>> PackagesListPackagesForAuthenticatedUserAsync(
            global::G.PackagesListPackagesForAuthenticatedUserPackageType packageType,
            global::G.PackagesListPackagesForAuthenticatedUserVisibility? visibility,
            int page,
            int perPage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PreparePackagesListPackagesForAuthenticatedUserArguments(
                httpClient: _httpClient,
                packageType: ref packageType,
                visibility: ref visibility,
                page: ref page,
                perPage: ref perPage);

            var packageTypeValue = packageType switch
            {
                global::G.PackagesListPackagesForAuthenticatedUserPackageType.Npm => "npm",
                global::G.PackagesListPackagesForAuthenticatedUserPackageType.Maven => "maven",
                global::G.PackagesListPackagesForAuthenticatedUserPackageType.Rubygems => "rubygems",
                global::G.PackagesListPackagesForAuthenticatedUserPackageType.Docker => "docker",
                global::G.PackagesListPackagesForAuthenticatedUserPackageType.Nuget => "nuget",
                global::G.PackagesListPackagesForAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var visibilityValue = visibility switch
            {
                global::G.PackagesListPackagesForAuthenticatedUserVisibility.Public => "public",
                global::G.PackagesListPackagesForAuthenticatedUserVisibility.Private => "private",
                global::G.PackagesListPackagesForAuthenticatedUserVisibility.Internal => "internal",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/user/packages?package_type={packageTypeValue}&visibility={visibilityValue}&page={page}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePackagesListPackagesForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                packageType: packageType,
                visibility: visibility,
                page: page,
                perPage: perPage);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPackagesListPackagesForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPackagesListPackagesForAuthenticatedUserResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Package>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}