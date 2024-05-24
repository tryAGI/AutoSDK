//HintName: G.PackagesClient.PackagesListPackagesForOrganization.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// List packages for an organization
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="org"></param>
        /// <param name="visibility"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PackagesListPackagesForOrganizationAsync(
            PackagesListPackagesForOrganizationPackageType packageType,
            string org,
            PackagesListPackagesForOrganizationVisibility visibility,
            int page,
            int perPage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesListPackagesForOrganizationPackageType.Npm => "npm",
                PackagesListPackagesForOrganizationPackageType.Maven => "maven",
                PackagesListPackagesForOrganizationPackageType.Rubygems => "rubygems",
                PackagesListPackagesForOrganizationPackageType.Docker => "docker",
                PackagesListPackagesForOrganizationPackageType.Nuget => "nuget",
                PackagesListPackagesForOrganizationPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var visibilityValue = visibility switch
            {
                PackagesListPackagesForOrganizationVisibility.Public => "public",
                PackagesListPackagesForOrganizationVisibility.Private => "private",
                PackagesListPackagesForOrganizationVisibility.Internal => "internal",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/packages?package_type={packageTypeValue}&visibility={visibilityValue}&page={page}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}