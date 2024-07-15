//HintName: G.PackagesClient.PackagesGetAllPackageVersionsForPackageOwnedByUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        partial void PreparePackagesGetAllPackageVersionsForPackageOwnedByUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType packageType,
            ref string packageName,
            ref string username);
        partial void PreparePackagesGetAllPackageVersionsForPackageOwnedByUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType packageType,
            string packageName,
            string username);
        partial void ProcessPackagesGetAllPackageVersionsForPackageOwnedByUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPackagesGetAllPackageVersionsForPackageOwnedByUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List package versions for a package owned by a user<br/>
        /// Lists package versions for a public package owned by a specified user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PackageVersion>> PackagesGetAllPackageVersionsForPackageOwnedByUserAsync(
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType packageType,
            string packageName,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PreparePackagesGetAllPackageVersionsForPackageOwnedByUserArguments(
                httpClient: _httpClient,
                packageType: ref packageType,
                packageName: ref packageName,
                username: ref username);

            var packageTypeValue = packageType switch
            {
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Npm => "npm",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Maven => "maven",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Rubygems => "rubygems",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Docker => "docker",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Nuget => "nuget",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/users/{username}/packages/{packageTypeValue}/{packageName}/versions", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePackagesGetAllPackageVersionsForPackageOwnedByUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                packageType: packageType,
                packageName: packageName,
                username: username);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPackagesGetAllPackageVersionsForPackageOwnedByUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPackagesGetAllPackageVersionsForPackageOwnedByUserResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.PackageVersion>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}