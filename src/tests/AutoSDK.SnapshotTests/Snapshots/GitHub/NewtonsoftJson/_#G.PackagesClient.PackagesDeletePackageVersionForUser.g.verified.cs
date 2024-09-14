//HintName: G.PackagesClient.PackagesDeletePackageVersionForUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        partial void PreparePackagesDeletePackageVersionForUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.PackagesDeletePackageVersionForUserPackageType packageType,
            ref string packageName,
            ref string username,
            ref int packageVersionId);
        partial void PreparePackagesDeletePackageVersionForUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PackagesDeletePackageVersionForUserPackageType packageType,
            string packageName,
            string username,
            int packageVersionId);
        partial void ProcessPackagesDeletePackageVersionForUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPackagesDeletePackageVersionForUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete package version for a user<br/>
        /// Deletes a specific package version for a user. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.<br/>
        /// If the `package_type` belongs to a GitHub Packages registry that supports granular permissions, the authenticated user must have admin permissions to the package. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#granular-permissions-for-userorganization-scoped-packages)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` and `delete:packages` scopes to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="username"></param>
        /// <param name="packageVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> PackagesDeletePackageVersionForUserAsync(
            global::G.PackagesDeletePackageVersionForUserPackageType packageType,
            string packageName,
            string username,
            int packageVersionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PreparePackagesDeletePackageVersionForUserArguments(
                httpClient: _httpClient,
                packageType: ref packageType,
                packageName: ref packageName,
                username: ref username,
                packageVersionId: ref packageVersionId);

            var packageTypeValue = packageType switch
            {
                global::G.PackagesDeletePackageVersionForUserPackageType.Npm => "npm",
                global::G.PackagesDeletePackageVersionForUserPackageType.Maven => "maven",
                global::G.PackagesDeletePackageVersionForUserPackageType.Rubygems => "rubygems",
                global::G.PackagesDeletePackageVersionForUserPackageType.Docker => "docker",
                global::G.PackagesDeletePackageVersionForUserPackageType.Nuget => "nuget",
                global::G.PackagesDeletePackageVersionForUserPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/users/{username}/packages/{packageTypeValue}/{packageName}/versions/{packageVersionId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePackagesDeletePackageVersionForUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                packageType: packageType,
                packageName: packageName,
                username: username,
                packageVersionId: packageVersionId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPackagesDeletePackageVersionForUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPackagesDeletePackageVersionForUserResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BasicError?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}