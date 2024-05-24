//HintName: G.PackagesClient.PackagesRestorePackageForOrg.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// Restore a package for an organization
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="org"></param>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PackagesRestorePackageForOrgAsync(
            PackagesRestorePackageForOrgPackageType packageType,
            string packageName,
            string org,
            string token,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesRestorePackageForOrgPackageType.Npm => "npm",
                PackagesRestorePackageForOrgPackageType.Maven => "maven",
                PackagesRestorePackageForOrgPackageType.Rubygems => "rubygems",
                PackagesRestorePackageForOrgPackageType.Docker => "docker",
                PackagesRestorePackageForOrgPackageType.Nuget => "nuget",
                PackagesRestorePackageForOrgPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/packages/{packageTypeValue}/{packageName}/restore?token={token}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}