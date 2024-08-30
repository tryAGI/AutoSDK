//HintName: G.PackagesClient.PackagesGetAllPackageVersionsForPackageOwnedByOrg.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        partial void PreparePackagesGetAllPackageVersionsForPackageOwnedByOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType packageType,
            ref string packageName,
            ref string org,
            ref int page,
            ref int perPage,
            ref global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState? state);
        partial void PreparePackagesGetAllPackageVersionsForPackageOwnedByOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType packageType,
            string packageName,
            string org,
            int page,
            int perPage,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState? state);
        partial void ProcessPackagesGetAllPackageVersionsForPackageOwnedByOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPackagesGetAllPackageVersionsForPackageOwnedByOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List package versions for a package owned by an organization<br/>
        /// Lists package versions for a package owned by an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint if the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="org"></param>
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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PackageVersion>> PackagesGetAllPackageVersionsForPackageOwnedByOrgAsync(
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType packageType,
            string packageName,
            string org,
            int page,
            int perPage,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState? state,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PreparePackagesGetAllPackageVersionsForPackageOwnedByOrgArguments(
                httpClient: _httpClient,
                packageType: ref packageType,
                packageName: ref packageName,
                org: ref org,
                page: ref page,
                perPage: ref perPage,
                state: ref state);

            var packageTypeValue = packageType switch
            {
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Npm => "npm",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Maven => "maven",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Rubygems => "rubygems",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Docker => "docker",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Nuget => "nuget",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState.Active => "active",
                global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState.Deleted => "deleted",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/packages/{packageTypeValue}/{packageName}/versions?page={page}&per_page={perPage}&state={(global::System.Uri.EscapeDataString(stateValue?.ToString() ?? string.Empty))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePackagesGetAllPackageVersionsForPackageOwnedByOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                packageType: packageType,
                packageName: packageName,
                org: org,
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
            ProcessPackagesGetAllPackageVersionsForPackageOwnedByOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPackagesGetAllPackageVersionsForPackageOwnedByOrgResponseContent(
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