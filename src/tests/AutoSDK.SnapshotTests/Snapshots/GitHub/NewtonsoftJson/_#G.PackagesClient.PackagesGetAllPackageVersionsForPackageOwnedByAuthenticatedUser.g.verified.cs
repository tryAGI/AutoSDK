//HintName: G.PackagesClient.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        partial void PreparePackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType packageType,
            ref string packageName,
            ref int? page,
            ref int? perPage,
            ref global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState? state);
        partial void PreparePackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType packageType,
            string packageName,
            int? page,
            int? perPage,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState? state);
        partial void ProcessPackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List package versions for a package owned by the authenticated user<br/>
        /// Lists package versions for a package owned by the authenticated user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="state">
        /// Default Value: active
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PackageVersion>> PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserAsync(
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType packageType,
            string packageName,
            int? page = 1,
            int? perPage = 30,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState? state = global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState.Active,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PreparePackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserArguments(
                httpClient: _httpClient,
                packageType: ref packageType,
                packageName: ref packageName,
                page: ref page,
                perPage: ref perPage,
                state: ref state);

            var packageTypeValue = packageType switch
            {
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Npm => "npm",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Maven => "maven",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Rubygems => "rubygems",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Docker => "docker",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Nuget => "nuget",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState.Active => "active",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState.Deleted => "deleted",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/user/packages/{packageTypeValue}/{packageName}/versions",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("state", stateValue?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                packageType: packageType,
                packageName: packageName,
                page: page,
                perPage: perPage,
                state: state);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.PackageVersion>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}