//HintName: G.PackagesClient.PackagesGetPackageForOrganization.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// Get a package for an organization
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Package> PackagesGetPackageForOrganizationAsync(
            PackagesGetPackageForOrganizationPackageType packageType,
            string packageName,
            string org,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesGetPackageForOrganizationPackageType.Npm => "npm",
                PackagesGetPackageForOrganizationPackageType.Maven => "maven",
                PackagesGetPackageForOrganizationPackageType.Rubygems => "rubygems",
                PackagesGetPackageForOrganizationPackageType.Docker => "docker",
                PackagesGetPackageForOrganizationPackageType.Nuget => "nuget",
                PackagesGetPackageForOrganizationPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/packages/{packageTypeValue}/{packageName}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Package>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}