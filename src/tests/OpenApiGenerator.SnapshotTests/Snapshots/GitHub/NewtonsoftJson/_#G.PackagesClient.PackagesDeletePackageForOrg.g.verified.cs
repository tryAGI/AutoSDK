//HintName: G.PackagesClient.PackagesDeletePackageForOrg.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// Delete a package for an organization
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PackagesDeletePackageForOrgAsync(
            PackagesDeletePackageForOrgPackageType packageType,
            string packageName,
            string org,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesDeletePackageForOrgPackageType.Npm => "npm",
                PackagesDeletePackageForOrgPackageType.Maven => "maven",
                PackagesDeletePackageForOrgPackageType.Rubygems => "rubygems",
                PackagesDeletePackageForOrgPackageType.Docker => "docker",
                PackagesDeletePackageForOrgPackageType.Nuget => "nuget",
                PackagesDeletePackageForOrgPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/packages/{packageTypeValue}/{packageName}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}