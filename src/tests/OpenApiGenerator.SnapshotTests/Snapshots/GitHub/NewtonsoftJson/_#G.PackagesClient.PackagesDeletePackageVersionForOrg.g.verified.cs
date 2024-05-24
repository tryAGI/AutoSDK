//HintName: G.PackagesClient.PackagesDeletePackageVersionForOrg.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// Delete package version for an organization
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="org"></param>
        /// <param name="packageVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PackagesDeletePackageVersionForOrgAsync(
            PackagesDeletePackageVersionForOrgPackageType packageType,
            string packageName,
            string org,
            int packageVersionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesDeletePackageVersionForOrgPackageType.Npm => "npm",
                PackagesDeletePackageVersionForOrgPackageType.Maven => "maven",
                PackagesDeletePackageVersionForOrgPackageType.Rubygems => "rubygems",
                PackagesDeletePackageVersionForOrgPackageType.Docker => "docker",
                PackagesDeletePackageVersionForOrgPackageType.Nuget => "nuget",
                PackagesDeletePackageVersionForOrgPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/packages/{packageTypeValue}/{packageName}/versions/{packageVersionId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}